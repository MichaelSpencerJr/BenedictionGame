using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;
using Benediction.Controller;
using Benediction.Game;
using Benediction.Model;

namespace Testing.SpecFlow.Mock
{
    class MockModel : IGamePlayerModel
    {
        public GamePlayerState UiState { get; set; }
        public SelectionState SelectionState { get; set; }
        public GameState Game { get; set; }
        public State CommittedState { get; set; }
        public IDictionary<Guid, ProposedState> AvailableActions { get; set; }
        public IOrderedEnumerable<ProposedState> ActionsByObjectTargetSize { get; }
        public IOrderedEnumerable<ProposedState> ActionsByObjectTarget { get; }
        public IEnumerable<Location> HighlightLocations { get; }
        public int? MinVariation { get; }
        public int? MaxVariation { get; }
        public State EditorState { get; set; }
        public Location SelectionObject { get; set; }
        public Location SelectionTarget { get; set; }
        public int? SelectedVariation { get; set; }
        public Cell InHand { get; set; }
        public RestrictionState Restrictions { get; set; }
        public bool EditMode { get; set; }
    }
}
