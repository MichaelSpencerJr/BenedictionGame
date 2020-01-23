using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Benediction.Board;
using Benediction.Controller;
using Benediction.Game;

namespace Benediction.Model
{
    public interface IGamePlayerModel
    {
        /// <summary>Current Game Interface State</summary>
        GamePlayerState UiState { get; set; }

        /// <summary>Current Move Selection State</summary>
        SelectionState SelectionState { get; set; }

        /// <summary>Current Committed Game Sequence</summary>
        GameState Game { get; set; }
        
        /// <summary>Committed Game Board State</summary>
        State CommittedState { get; set; }

        IDictionary<Guid, ProposedState> AvailableActions { get; set; }

        IOrderedEnumerable<ProposedState> SelectionFilteredActions { get; }

        IOrderedEnumerable<ProposedState> AllSelectionActions { get; }

        IEnumerable<Location> HighlightLocations { get; }

        int? MinVariation { get; }

        int? MaxVariation { get; }

        /// <summary>Temporary / Display Game Board, used for visualizing a move in progress</summary>
        State EditorState { get; set; }

        /// <summary>Current Object of a selected move in progress</summary>
        Location SelectionObject { get; set; }

        /// <summary>Current Target of a selected move in progress</summary>
        Location SelectionTarget { get; set; }

        int? SelectedVariation { get; set; }

        /// <summary>Piece definition current in-hand, rendered as pinned to the mouse cursor</summary>
        Cell InHand { get; set; }
    }
}