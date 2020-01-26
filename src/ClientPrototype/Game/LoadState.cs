using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Game state transition representing a game state loaded from saved state information,
    /// for which no history information is present.
    /// </summary>
    public class LoadState : StateTransition
    {
        public override string ToString() => "Loaded";
        public override State NewState { get; set; }
        public override int EmptyColumn => -1;

        public LoadState(State state)
        {
            NewState = state;
        }
    }
}