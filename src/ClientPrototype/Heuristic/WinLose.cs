using Benediction.Board;

namespace Benediction.Heuristic
{
    public class WinLose : ClassifierBase
    {
        public override string Name => nameof(WinLose);
        public override double Score(State state)
        {
            if (!state.Flags.GameWon()) return 0d;
            return (state.Flags & StateFlags.RedWin) != 0 ? double.PositiveInfinity : double.NegativeInfinity;
        }
    }
}