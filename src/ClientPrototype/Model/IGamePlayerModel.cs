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

        /// <summary>Computed and Stored List of Actions Available This Move</summary>
        IDictionary<Guid, ProposedState> AvailableActions { get; set; }

        /// <summary>Computed List of Actions Matching Selection -- narrowing and dead-ending, not rotating</summary>
        IOrderedEnumerable<ProposedState> ActionsByObjectTargetSize { get; }

        /// <summary>Computed List of Actions Matching Object and Target -- rotating, not narrowing</summary>
        IOrderedEnumerable<ProposedState> ActionsByObjectTarget { get; }

        /// <summary>Computed List of Action Targets when Only Object Is Selected</summary>
        IEnumerable<Location> HighlightLocations { get; }

        /// <summary>Computed Minimum Piece Count or Variation Matching Object and Target</summary>
        int? MinVariation { get; }

        /// <summary>Computed Maximum Piece Count or Variation Matching Object and Target</summary>
        int? MaxVariation { get; }

        /// <summary>Temporary / Display Game Board, used for visualizing a move in progress</summary>
        State EditorState { get; set; }

        /// <summary>Current Object of a selected move in progress</summary>
        Location SelectionObject { get; set; }

        /// <summary>Current Target of a selected move in progress</summary>
        Location SelectionTarget { get; set; }

        /// <summary>Currently Selected Variation</summary>
        int? SelectedVariation { get; set; }

        /// <summary>Piece definition current in-hand, rendered as pinned to the mouse cursor</summary>
        Cell InHand { get; set; }

        /// <summary>Game modification restrictions in effect, if any</summary>
        RestrictionState Restrictions { get; set; }

        /// <summary>True if board UI state is currently in editor mode</summary>
        bool EditMode { get; set; }
    }
}