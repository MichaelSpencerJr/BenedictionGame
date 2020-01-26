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
        /// <inheritdoc />
        public GamePlayerState UiState { get; set; }

        /// <inheritdoc />
        public SelectionState SelectionState { get; set; }

        /// <inheritdoc />
        public GameState Game { get; set; }

        /// <inheritdoc />
        public State CommittedState { get; set; }

        /// <inheritdoc />
        public IDictionary<Guid, ProposedState> AvailableActions { get; set; }

        /// <inheritdoc />
        public IOrderedEnumerable<ProposedState> ActionsByObjectTargetSize => AvailableActions?.Values.Where(ps =>
                (!Movement.IsValidLocation(SelectionObject) || ps.Action.Location == SelectionObject)
                && (!Movement.IsValidLocation(SelectionTarget) || !(ps.Action is GameTargetAction gta) ||
                    gta.Target == SelectionTarget)
                && (!SelectedVariation.HasValue || ps.Action.Size == SelectedVariation.Value))
            .OrderBy(ps => ps.Action.Size);

        /// <inheritdoc />
        public IOrderedEnumerable<ProposedState> ActionsByObjectTarget => AvailableActions?.Values.Where(ps =>
                (!Movement.IsValidLocation(SelectionObject) || ps.Action.Location == SelectionObject)
                && (!Movement.IsValidLocation(SelectionTarget) || !(ps.Action is GameTargetAction gta) ||
                    gta.Target == SelectionTarget))
            .OrderBy(ps => ps.Action.Size);

        /// <inheritdoc />
        public IEnumerable<Location> HighlightLocations
        {
            get
            {
                if (!Movement.IsValidLocation(SelectionObject) || Movement.IsValidLocation(SelectionTarget))
                    return null;

                return ActionsByObjectTarget?.Select(ps => ps.Action).OfType<GameTargetAction>()
                    .Select(gta => gta.Target).Distinct();
            }
        }

        /// <inheritdoc />
        public int? MinVariation
        {
            get { return (ActionsByObjectTarget?.Any() ?? false) ? ActionsByObjectTarget?.Min(ps => ps.Action.Size) : null; }
        }

        /// <inheritdoc />
        public int? MaxVariation
        {
            get { return (ActionsByObjectTarget?.Any() ?? false) ? ActionsByObjectTarget?.Max(ps => ps.Action.Size) : null; }
        }

        /// <inheritdoc />
        public State EditorState { get; set; }

        /// <inheritdoc />
        public Location SelectionObject { get; set; }

        /// <inheritdoc />
        public Location SelectionTarget { get; set; }

        /// <inheritdoc />
        public int? SelectedVariation { get; set; }

        /// <inheritdoc />
        public Cell InHand { get; set; }

        /// <inheritdoc />
        public RestrictionState Restrictions { get; set; }

        /// <inheritdoc />
        public bool EditMode { get; set; }
    }
}
