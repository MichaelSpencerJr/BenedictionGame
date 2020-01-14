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
        public ActionSide Side { get; }

        /// <summary>
        /// Represents the board location this action is taking place on or from.
        /// </summary>
        public Location Location { get; }

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
        public abstract string CheckError(State initialState);

        public string CheckErrorBase(State initialState)
        {
            if ((initialState.Flags & (StateFlags.RedWin | StateFlags.BlueWin)) > 0)
            {
                return "Winner Already Decided";
            }

            if (Side == ActionSide.Blue &&
                (initialState.Flags & (StateFlags.BlueAction1 | StateFlags.BlueAction2)) == 0)
            {
                return "Not Blue's Turn";
            }

            if (Side == ActionSide.Red &&
                (initialState.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2)) == 0)
            {
                return "Not Red's Turn";
            }

            if (!Movement.IsValidLocation(Location))
            {
                return "Not a valid board location.";
            }

            return null;
        }

        /// <summary>
        /// Applies this move to the supplied game board, returning a modified game board.
        /// Inter-turn logic is not applied here, so be sure to call <seealso cref="PrepareNextTurn"/> on the return value's flags.
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
        /// Updates game state flags to indicate win condition (if a king has been taken) and to flag
        /// the next move (if no win condition).
        /// </summary>
        /// <param name="initialState">Game state flags immediately after last turn complete</param>
        /// <returns>Game state flags for start of next turn or for end of game condition</returns>
        public static State PrepareNextTurn(State initialState)
        {
            var retval = initialState.DeepCopy();

            if ((initialState.Flags & StateFlags.RedKingTaken) > 0)
            {
                retval.Flags = initialState.Flags | StateFlags.BlueWin;
            }
            else if ((initialState.Flags & StateFlags.BlueKingTaken) > 0)
            {
                retval.Flags = initialState.Flags | StateFlags.RedWin;
            }

            if ((initialState.Flags & (StateFlags.RedWin | StateFlags.BlueWin)) > 0)
            {
                retval.Flags = initialState.Flags & (StateFlags.RedKingTaken | StateFlags.BlueKingTaken | StateFlags.RedWin |
                                       StateFlags.BlueWin);
                return retval;
            }
            if ((initialState.Flags & StateFlags.RedAction1) > 0)
            {
                retval.Flags = (initialState.Flags & ~StateFlags.RedAction1) | StateFlags.RedAction2;
            }
            else if ((initialState.Flags & StateFlags.RedAction2) > 0)
            {
                retval.Flags = (initialState.Flags & ~StateFlags.RedAction2) | StateFlags.BlueAction1;
                UnlockAllLockedPieces(retval);
            }
            else if ((initialState.Flags & StateFlags.BlueAction1) > 0)
            {
                retval.Flags = (initialState.Flags & ~StateFlags.BlueAction1) | StateFlags.BlueAction2;
            }

            if ((initialState.Flags & StateFlags.BlueAction2) > 0)
            {
                retval.Flags = (initialState.Flags & ~StateFlags.BlueAction2) | StateFlags.RedAction1;
                UnlockAllLockedPieces(retval);
            }

            return retval;
        }

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

        public string CheckLocationEmpty(State initialState)
        {
            if (initialState[Location] != Cell.Empty)
            {
                return $"Location {Location} Not Empty";
            }

            return null;
        }
    }
}
