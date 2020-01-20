using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;
using Benediction.Controller;
using Benediction.Game;

namespace Benediction.Model
{
    public class GamePlayerModel : IGamePlayerModel
    {
        public GamePlayerState UiState { get; set; }
        public SelectionState SelectionState { get; set; }
        public GameState Game { get; set; }
        public State CommittedState { get; set; }
        public IDictionary<Guid, ProposedState> AvailableActions { get; set; }
        public State EditorState { get; set; }
        public Location SelectionObject { get; set; }
        public Location SelectionTarget { get; set; }
        public Cell InHand { get; set; }
    }
}
