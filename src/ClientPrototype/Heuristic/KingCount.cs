﻿using System.Linq;
using Benediction.Board;

namespace Benediction.Heuristic
{
    public class KingCount : ClassifierBase
    {
        public override string Name => nameof(KingCount);
        public override double Score(State state)
        {
            return state.Aggregate(0d, (i, c) => i + (CellExtensionMethods.IsCursed(c.Value) ? CellExtensionMethods.GetSide(c.Value, 1d, -1d, 0d) * CellExtensionMethods.GetSize(c.Value) : 0d));
        }
    }
}