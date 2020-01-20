using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Single game state modification, either overwriting previous state with a new state or
    /// transitioning from one state to another.
    /// </summary>
    public abstract class StateInfo
    {
        public new abstract string ToString();

        /// <summary>
        /// Game state applied by this transition
        /// </summary>
        public State NewState { get; set; }

        /// <summary>
        /// For container actions which contain sets of other actions, indicates the index into the container
        /// where the first empty move exists.  Or -1 to indicate this is not a container action.
        /// </summary>
        public abstract int EmptyColumn { get; }
    }
}