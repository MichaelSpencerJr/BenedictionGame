using System;
using Benediction.Actions;
using Benediction.Board;
using Benediction.Heuristic;

namespace Benediction.Controller
{
    public class ProposedState
    {
        public Guid Key { get; set; }
        public GameAction Action { get; set; }
        public State Result { get; set; }
        public HeuristicPolarity Polarity { get; set; }
        public double Heuristic { get; set; }

        public override string ToString() => $"{Action?.ToString() ?? string.Empty} - {Heuristic:0.00}";
    }
}