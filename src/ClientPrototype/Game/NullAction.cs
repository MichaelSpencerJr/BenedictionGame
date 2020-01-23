using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Game state transition which does nothing.  For example, a set of four
    /// moves (red, red, blue, blue) which haven't happened yet.
    /// </summary>
    public class NullAction : StateTransition
    {
        public override string ToString() => string.Empty;
        public override State NewState { get; set; }
        public override int EmptyColumn => -1;
    }
}