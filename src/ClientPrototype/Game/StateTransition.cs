using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Single game state transition affecting a previous state and modifying it
    /// </summary>
    public abstract class StateTransition : StateInfo
    {
        /// <summary>
        /// Game state before this transition is applied
        /// </summary>
        public State InitialState { get; set; }
    }
}