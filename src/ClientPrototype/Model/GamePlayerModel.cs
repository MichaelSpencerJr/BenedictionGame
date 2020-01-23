using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
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

        public IOrderedEnumerable<ProposedState> SelectionFilteredActions => AvailableActions?.Values.Where(ps =>
                (!Movement.IsValidLocation(SelectionObject) || ps.Action.Location == SelectionObject)
                && (!Movement.IsValidLocation(SelectionTarget) || !(ps.Action is GameTargetAction gta) ||
                    gta.Target == SelectionTarget)
                && (!SelectedVariation.HasValue || ps.Action.Size == SelectedVariation.Value))
            .OrderBy(ps => ps.Action.Size);

        public IOrderedEnumerable<ProposedState> AllSelectionActions => AvailableActions?.Values.Where(ps =>
                (!Movement.IsValidLocation(SelectionObject) || ps.Action.Location == SelectionObject)
                && (!Movement.IsValidLocation(SelectionTarget) || !(ps.Action is GameTargetAction gta) ||
                    gta.Target == SelectionTarget))
            .OrderBy(ps => ps.Action.Size);

        public IEnumerable<Location> HighlightLocations
        {
            get
            {
                if (!Movement.IsValidLocation(SelectionObject) || Movement.IsValidLocation(SelectionTarget))
                    return null;

                return SelectionFilteredActions?.Select(ps => ps.Action).OfType<GameTargetAction>()
                    .Select(gta => gta.Target).Distinct();
            }
        }

        public int? MinVariation
        {
            get { return (AllSelectionActions?.Any() ?? false) ? AllSelectionActions?.Min(ps => ps.Action.Size) : null; }
        }

        public int? MaxVariation
        {
            get { return (AllSelectionActions?.Any() ?? false) ? AllSelectionActions?.Max(ps => ps.Action.Size) : null; }
        }

        public State EditorState { get; set; }
        public Location SelectionObject { get; set; }
        public Location SelectionTarget { get; set; }
        public int? SelectedVariation { get; set; }
        public Cell InHand { get; set; }
    }
}
