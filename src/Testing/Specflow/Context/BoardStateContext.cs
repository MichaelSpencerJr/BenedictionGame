using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;
using Benediction.Controller;

namespace Testing.SpecFlow.Context
{
    public class BoardStateContext
    {
        public State BoardState { get; set; }
        public string LastMessage { get; set; }
        public Exception LastError { get; set; }
        public IEnumerable<ProposedState> AvailableActions { get; set; }
        public IDictionary<string, State> StateLibrary { get; set; } = new Dictionary<string, State>(StringComparer.InvariantCultureIgnoreCase);
    }
}
