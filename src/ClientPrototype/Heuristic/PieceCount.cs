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
        public override double Score(State state)
        {
            return state.Aggregate(0d, (i, c) => i + (c.Value.IsPiece() ? c.Value.GetSide(1d, -1d, 0d) * c.Value.GetSize() : 0d));
        }
    }
}
