using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Game state modification which clears all pieces and flags from the current game state.
    /// </summary>
    public class ClearBoard : StateInfo
    {
        public override string ToString() => "Clear Board";
        public override int EmptyColumn => -1;
        public override State NewState
        {
            get => StateManager.Create();
            set { }
        }
    }
}