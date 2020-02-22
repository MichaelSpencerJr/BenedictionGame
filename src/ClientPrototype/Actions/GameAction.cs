using System.Linq;
using Benediction.Board;
using Benediction.Controller;

namespace Benediction.Actions
{
    /// <summary>
    /// Represents a single game action performed by a player
    /// </summary>
    public abstract class GameAction
    {
        /// <summary>
        /// Represents which player (which side, red or blue) is performing this action.
        /// </summary>
        public ActionSide Side { get; set; }

        /// <summary>
        /// Represents the board location this action is taking place on or from.
        /// </summary>
        public Location Location { get; set; }
 
        public abstract int Size { get; set; }

        /// <summary>
        /// Name of this game action
        /// </summary>
        public abstract string Action { get; }

        /// <summary>
        /// Tests if this move can be performed on the current game board, and if not,
        /// returns a brief text explanation of why it cannot be performed.
        /// </summary>
        /// <param name="initialState">Game board this move is being considered for</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        /// <remarks>Each error checker returns null if a move is allowed, so for brevity these top-level error checkers use
        /// the null-coalescing operator ?? to perform multiple checks in sequence.  From left to right each check is performed.
        /// If the check returns a string (because that rule blocked the move) then the string is immediately returned and no further
        /// checks are performed.  If the check returns null (because that rule had no problem with the move) then the ?? operator
        /// causes the next check in the sequence to be performed.  The process continues until the last rule is checked.
        /// If all rules pass, null is returned to the caller to indicate the move is allowed.</remarks>
        public abstract string CheckError(State initialState);

        /// <summary>
        /// Common error checks which must performed at the start of all player actions:
        /// Confirms the game is not over, the player submitting the move is active,
        /// and the move location is valid.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckErrorBase(State state)
        {
            if (state.Flags.GameWon())
            {
                return "Game Over!";
            }

            if (Side == ActionSide.Blue && state.Flags.IsRedTurn())
            {
                return "Your Move, Red";
            }

            if (Side == ActionSide.Red && state.Flags.IsBlueTurn())
            {
                return "Your Move, Blue";
            }

            if (!Movement.IsValidLocation(Location))
            {
                return "Please Select a Location";
            }

            return null;
        }

        /// <summary>
        /// Applies this move to the supplied game board, returning a modified game board.
        /// Inter-turn logic is not applied here, so be sure to call <seealso cref="PrepareNextTurn"/> on the return value.
        /// </summary>
        /// <param name="initialState">State of the game board this move is applied to</param>
        /// <returns>State of the game board after this move is applied</returns>
        public abstract State Apply(State initialState);

        /// <summary>
        /// Short description of this move in chess-like notation
        /// </summary>
        /// <returns>Short description</returns>
        public new abstract string ToString();

        /// <summary>
        /// Processes game rules which apply after and between player turns.
        /// </summary>
        /// <param name="state">Game state immediately after a player turn has ended.</param>
        /// <returns>Game over state, if a win was detected, or game state ready for next player turn</returns>
        public static State PrepareNextTurn(State state)
        {
            state.Flags = state.Flags.HandleKingCaptureFlag();

            CheckKingCreation(ref state);
            BlessAnyBridges(ref state);
            CheckBlessedKings(ref state);
            ApplyCurses(ref state);

            if (state.Flags.IsSecondTurn())
            {
                UnlockAllLockedPieces(ref state);
            }

            state.Flags = state.Flags.NextTurn();

            if (!state.Flags.GameEnded())
            {
                var side = state.Flags.IsRedTurn() ? ActionSide.Red : ActionSide.Blue;
                if (!AvailableActionController.AllActions(state, side).Any())
                {
                    state.Flags = state.Flags.IsRedTurn() ? StateFlags.BlueWin : StateFlags.RedWin;
                }
            }

            return state;
        }

        private static void CheckKingCreation(ref State state)
        {
            if (state[state.RedHome].IsPiece() && !state[state.RedHome].IsKing())
            {
                state[state.RedHome] = state[state.RedHome].King(true).Blessed(false).CursePending(false).Cursed(false);
            }

            if (state[state.BlueHome].IsPiece() && !state[state.BlueHome].IsKing())
            {
                state[state.BlueHome] = state[state.BlueHome].King(true).Blessed(false).CursePending(false).Cursed(false);
            }
        }

        /// <summary>
        /// Uses <seealso cref="BridgeDetector"/> to find any pieces which are part of a bridge, and blesses those pieces.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void BlessAnyBridges(ref State state)
        {
            foreach (var bridgeLocation in BridgeDetector.GetBridgeSpaces(state, ActionSide.Red))
            {
                if (!state[bridgeLocation].IsCursed()) state[bridgeLocation] = state[bridgeLocation].Blessed(true);
            }

            foreach (var bridgeLocation in BridgeDetector.GetBridgeSpaces(state, ActionSide.Blue))
            {
                if (!state[bridgeLocation].IsCursed()) state[bridgeLocation] = state[bridgeLocation].Blessed(true);
            }
        }

        /// <summary>
        /// Checks if either side has a blessed king, and sets the win flag for that side if so.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void CheckBlessedKings(ref State state)
        {
            foreach (var location in state.AllBoardLocations)
            {
                if (state[location].IsBlessed() && state[location].IsKing())
                {
                    state.Flags |= state[location].GetSide(StateFlags.RedWin, StateFlags.BlueWin, StateFlags.Undefined);
                }
            }
        }

        /// <summary>
        /// Checks if either side has a pending curse which hasn't attached yet (because it can still be prevented with a blessing.)
        /// If no blessing or king flag is found, applies the curse.  Otherwise removes the pending curse.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void ApplyCurses(ref State state)
        {
            foreach (var location in state.AllBoardLocations)
            {
                state[location] = state[location].HandleCursePending();
            }
        }

        /// <summary>
        /// Removes all lock flags from all pieces, since locks only persist between a player's first and second moves.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void UnlockAllLockedPieces(ref State state)
        {
            foreach (var location in state.AllBoardLocations)
            {
                state[location] = state[location].Locked(false);
            }
        }

        /// <summary>
        /// Formats a set of four moves as a line of chess-like notation.
        /// </summary>
        /// <param name="red1">Red's first move</param>
        /// <param name="red2">Red's second move</param>
        /// <param name="blue1">Blue's first move</param>
        /// <param name="blue2">Blue's second move</param>
        /// <returns>A line of four moves, like "@A1 @A3 / @E5 @D6"</returns>
        public static string DescribeGameTurn(GameAction red1, GameAction red2, GameAction blue1, GameAction blue2)
        {
            return $"{red1} {red2} / {blue1} {blue2}";
        }

        /// <summary>
        /// Confirms the initial location (or only location, for blocks and drops) is empty.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckLocationEmpty(State state)
        {
            if (state[Location] != Cell.Empty)
            {
                return $"Location {Location} Not Empty";
            }

            return null;
        }
    }
}
