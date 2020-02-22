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
        private State _boardState;

        public State BoardState
        {
            get => _boardState;
            set
            {
                if (value.BoardId == new Guid("c9939467-78e1-7020-6794-93c9e1782070"))
                {
                    throw new InvalidOperationException("Blank board");
                }
                _boardState = value;
            }
        }

        public string LastMessage { get; set; }
        public Exception LastError { get; set; }
        public IEnumerable<ProposedState> AvailableActions { get; set; }
        public IDictionary<string, State> StateLibrary { get; set; } = new Dictionary<string, State>(StringComparer.InvariantCultureIgnoreCase);
        public BoardImageBehavior ImageBehavior { get; set; }
        public Guid LastPrintedBoard { get; set; }
    }
}
