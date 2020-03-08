using System.Linq;
using Benediction.Board;

namespace Benediction.Heuristic
{
    public class BlessCount : ClassifierBase
    {
        public override string Name => nameof(BlessCount);
        public override double Score(State state)
        {
            return state.Aggregate(0d, (i, c) => i + (CellExtensionMethods.IsBlessed(c.Value) ? CellExtensionMethods.GetSide(c.Value, 1d, -1d, 0d) * CellExtensionMethods.GetSize(c.Value) : 0d));
        }
    }
}