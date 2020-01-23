using Benediction.Board;

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
            if ((state.Flags & (StateFlags.RedWin | StateFlags.BlueWin)) > 0)
            {
                return "Game Over!";
            }

            if (Side == ActionSide.Blue &&
                (state.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2)) > 0)
            {
                return "Your Move, Red";
            }

            if (Side == ActionSide.Red &&
                (state.Flags & (StateFlags.BlueAction1 | StateFlags.BlueAction2)) > 0)
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
        /// <param name="initialState">Game state immediately after a player turn has ended.</param>
        /// <returns>Game over state, if a win was detected, or game state ready for next player turn</returns>
        public static State PrepareNextTurn(State initialState)
        {
            var finalState = initialState.DeepCopy();

            CheckKingTaken(finalState);
            CheckKingCreation(finalState);
            BlessAnyBridges(finalState);
            CheckBlessedKings(finalState);
            ApplyCurses(finalState);
            UpdateTurnFlag(finalState);

            return finalState;
        }

        /// <summary>
        /// Updates Win flag if opposing KingTaken flag is set.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void CheckKingTaken(State state)
        {
            if ((state.Flags & StateFlags.RedKingTaken) > 0)
            {
                state.Flags |= StateFlags.BlueWin;
            }
            else if ((state.Flags & StateFlags.BlueKingTaken) > 0)
            {
                state.Flags |= StateFlags.RedWin;
            }
        }

        private static void CheckKingCreation(State state)
        {
            if ((state[state.RedHome] & Cell.SizeMask) > 0)
            {
                state[state.RedHome] |= Cell.King;
            }

            if ((state[state.BlueHome] & Cell.SizeMask) > 0)
            {
                state[state.BlueHome] |= Cell.King;
            }
        }

        /// <summary>
        /// Uses <seealso cref="BridgeDetector"/> to find any pieces which are part of a bridge, and blesses those pieces.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void BlessAnyBridges(State state)
        {
            foreach (var bridgeLocation in BridgeDetector.GetBridgeSpaces(state, ActionSide.Red))
            {
                state[bridgeLocation] |= Cell.Blessed;
            }

            foreach (var bridgeLocation in BridgeDetector.GetBridgeSpaces(state, ActionSide.Blue))
            {
                state[bridgeLocation] |= Cell.Blessed;
            }

        }

        /// <summary>
        /// Checks if either side has a blessed king, and sets the win flag for that side if so.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void CheckBlessedKings(State state)
        {
            foreach (var location in State.AllBoardLocations)
            {
                if ((state[location] & Cell.Blessed) == Cell.Blessed && (state[location] & Cell.King) == Cell.King)
                {
                    if ((state[location] & Cell.SideRed) == Cell.SideRed)
                    {
                        state.Flags |= StateFlags.RedWin;
                    }
                    else
                    {
                        state.Flags |= StateFlags.BlueWin;
                    }
                }
            }
        }

        /// <summary>
        /// Checks if either side has a pending curse which hasn't attached yet (because it can still be prevented with a blessing.)
        /// If no blessing or king flag is found, applies the curse.  Otherwise removes the pending curse.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void ApplyCurses(State state)
        {
            foreach (var location in State.AllBoardLocations)
            {
                if ((state[location] & (Cell.Blessed | Cell.King)) == 0 && (state[location] & Cell.CursePending) == Cell.CursePending)
                {
                    state[location] = (state[location] & ~Cell.CursePending) | Cell.Cursed;
                }
                else
                {
                    state[location] &= ~Cell.CursePending;
                }
            }
        }

        /// <summary>
        /// Removes all lock flags from all pieces, since locks only persist between a player's first and second moves.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void UnlockAllLockedPieces(State state)
        {
            foreach (var location in State.AllBoardLocations)
            {
                if ((state[location] & Cell.Locked) > 0)
                {
                    state[location] &= ~Cell.Locked;
                }
            }
        }

        /// <summary>
        /// Ends the game if either player has won. Otherwise advances the turn indicator to the next player turn.
        /// </summary>
        /// <param name="state">Game state</param>
        private static void UpdateTurnFlag(State state)
        {
            if ((state.Flags & (StateFlags.RedWin | StateFlags.BlueWin)) > 0)
            {
                state.Flags &= (StateFlags.RedKingTaken | StateFlags.BlueKingTaken | StateFlags.RedWin |
                                                    StateFlags.BlueWin);
            }
            else if ((state.Flags & StateFlags.RedAction1) > 0)
            {
                state.Flags = (state.Flags & ~StateFlags.RedAction1) | StateFlags.RedAction2;
            }
            else if ((state.Flags & StateFlags.RedAction2) > 0)
            {
                state.Flags = (state.Flags & ~StateFlags.RedAction2) | StateFlags.BlueAction1;
                UnlockAllLockedPieces(state);
            }
            else if ((state.Flags & StateFlags.BlueAction1) > 0)
            {
                state.Flags = (state.Flags & ~StateFlags.BlueAction1) | StateFlags.BlueAction2;
            }
            else if ((state.Flags & StateFlags.BlueAction2) > 0)
            {
                state.Flags = (state.Flags & ~StateFlags.BlueAction2) | StateFlags.RedAction1;
                UnlockAllLockedPieces(state);
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
