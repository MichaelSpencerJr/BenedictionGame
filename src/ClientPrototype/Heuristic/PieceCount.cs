using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;

namespace Benediction.Heuristic
{
    public class PieceCount : ClassifierBase
    {
        public override string Name => nameof(PieceCount);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? 1d : -1d;
            var blue = polarity == HeuristicPolarity.BluePositive ? 1d : -1d;
            return state.Values.Aggregate(0d, (i, c) => i + (c.IsPiece() ? c.GetSide(red, blue, 0d) * c.GetSize() : 0d));
        }
    }

    public class StackCount : ClassifierBase
    {
        public override string Name => nameof(StackCount);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? 1d : -1d;
            var blue = polarity == HeuristicPolarity.BluePositive ? 1d : -1d;
            return state.Values.Aggregate(0d, (i, c) => i + (c.IsStack() ? c.GetSide(red, blue, 0d) * c.GetSize() : 0d));
        }
    }

    public class BlessCount : ClassifierBase
    {
        public override string Name => nameof(BlessCount);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? 1d : -1d;
            var blue = polarity == HeuristicPolarity.BluePositive ? 1d : -1d;
            return state.Values.Aggregate(0d, (i, c) => i + (c.IsBlessed() ? c.GetSide(red, blue, 0d) * c.GetSize() : 0d));
        }
    }

    public class CurseCount : ClassifierBase
    {
        public override string Name => nameof(CurseCount);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? 1d : -1d;
            var blue = polarity == HeuristicPolarity.BluePositive ? 1d : -1d;
            return state.Values.Aggregate(0d, (i, c) => i + (c.IsCursed() ? c.GetSide(red, blue, 0d) * c.GetSize() : 0d));
        }
    }

    public class KingCount : ClassifierBase
    {
        public override string Name => nameof(KingCount);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? 1d : -1d;
            var blue = polarity == HeuristicPolarity.BluePositive ? 1d : -1d;
            return state.Values.Aggregate(0d, (i, c) => i + (c.IsCursed() ? c.GetSide(red, blue, 0d) * c.GetSize() : 0d));
        }
    }

    public class WinLose : ClassifierBase
    {
        public override string Name => nameof(WinLose);
        public override double Score(State state, HeuristicPolarity polarity)
        {
            var red = polarity == HeuristicPolarity.RedPositive ? double.PositiveInfinity : double.NegativeInfinity;
            var blue = polarity == HeuristicPolarity.BluePositive ? double.PositiveInfinity : double.NegativeInfinity;
            if (!state.Flags.GameWon()) return 0d;
            return (state.Flags & StateFlags.RedWin) != 0 ? red : blue;
        }
    }

}
