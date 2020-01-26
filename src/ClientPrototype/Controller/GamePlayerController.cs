using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
using Benediction.Board;
using Benediction.Game;
using Benediction.Model;
using Benediction.View;

namespace Benediction.Controller
{
    public class GamePlayerController : IGamePlayerController
    {
        public IGamePlayerModel Model { get; set; }
        public IGamePlayerView View { get; set; }

        public GamePlayerController(IGamePlayerModel model, IGamePlayerView view)
        {
            Model = model;
            View = view;
            view.InputEvent += ViewOnInputEvent;
            view.NavigateEvent += ViewOnNavigateEvent;
            Model.CommittedState = Model.Game.Last().NewState;
            Model.SelectionObject = Location.Undefined;
            Model.SelectionTarget = Location.Undefined;
            Model.SelectedVariation = null;
            Model.EditorState = Model.CommittedState.DeepCopy();
            Model.InHand = Cell.Empty;
            Model.SelectionState = SelectionState.Unselected;
            var seenList = new HashSet<Guid>();
            Model.AvailableActions =
                AvailableActionController.GetAvailableActions(Model.CommittedState, seenList);
            Model.EditMode = false;
            Model.Restrictions = RestrictionState.None;
        }

        private void ViewOnNavigateEvent(object sender, BoardNavigationEventArgs e)
        {
            switch (e.EventType)
            {
                case NavigationEventType.ClearMove:
                    ClearMove();
                    break;
                case NavigationEventType.CommitMove:
                    CommitMove();
                    break;
                case NavigationEventType.ShowHistory:
                    ShowHistory(e.Selected);
                    break;
                case NavigationEventType.NewGame:
                    NewGame();
                    break;
                case NavigationEventType.LoadGame:
                    LoadGame(e.Selected);
                    break;
                case NavigationEventType.ToggleEditMode:
                    ToggleEditMode();
                    break;
                case NavigationEventType.Editor:
                    CommitEditedBoard(e.Selected);
                    break;
            }
             
            View.RedrawBoard();
            View.UpdateGameMoveGrid();
            View.BoardEditorUpdate();
        }

        private void ClearMove()
        {
            Model.SelectionObject = Location.Undefined;
            Model.SelectionTarget = Location.Undefined;
            Model.SelectedVariation = null;
            Model.EditorState = Model.CommittedState.DeepCopy();
            Model.InHand = Cell.Empty;
            Model.SelectionState = SelectionState.Unselected;
        }

        private void CommitMove()
        {
            if ((Model.SelectionState == SelectionState.EmptySelected ||
                 Model.SelectionState == SelectionState.MoveSelected) && Model.ActionsByObjectTargetSize.Any())
            {
                var (updatedModel, errorMessage) =
                    Model.Game.CommitPlayerMove(Model.ActionsByObjectTargetSize.First().Action);
                if (errorMessage == null)
                {
                    Model.CommittedState = updatedModel;
                    ClearMove();
                    var seenList = new HashSet<Guid>();
                    Model.AvailableActions =
                        AvailableActionController.GetAvailableActions(Model.CommittedState, seenList);
                }
            }
        }
        
        private void ShowHistory(State state)
        {
            Model.EditorState = state.DeepCopy();
            Model.AvailableActions = null;
        }

        private void NewGame()
        {
            Model.Game = new GameState {new NewGame()};
            Model.CommittedState = Model.Game.Last().NewState;
            Model.EditMode = false;
            ClearMove();
            Model.AvailableActions =
                AvailableActionController.GetAvailableActions(Model.CommittedState, new HashSet<Guid>());
        }

        private void LoadGame(State state)
        {
            Model.Game = new GameState {new LoadState(state)};
            Model.CommittedState = state;
            Model.EditMode = false;
            Model.EditorState = state.DeepCopy();
            ClearMove();
            Model.AvailableActions =
                AvailableActionController.GetAvailableActions(Model.CommittedState, new HashSet<Guid>());
        }

        private void ToggleEditMode()
        {
            Model.EditMode = !Model.EditMode;
            Model.EditorState = Model.CommittedState.DeepCopy();
            ClearMove();
            Model.AvailableActions = Model.EditMode ? null :
                AvailableActionController.GetAvailableActions(Model.CommittedState, new HashSet<Guid>());
        }

        private void CommitEditedBoard(State state)
        {
            Model.Game.Add(new BoardEditor {InitialState = Model.CommittedState, NewState = state});
            Model.CommittedState = state;
            Model.EditMode = false;
            Model.EditorState = state.DeepCopy();
            ClearMove();
            Model.AvailableActions =
                AvailableActionController.GetAvailableActions(Model.CommittedState, new HashSet<Guid>());
        }

        private static int GetEditorSlot(StateFlags flags)
        {
            if (flags.HasFlag(StateFlags.RedAction2)) return 0;
            if (flags.HasFlag(StateFlags.BlueAction1)) return 1;
            if (flags.HasFlag(StateFlags.BlueAction2)) return 2;
            return 3;
        }


        private void SelectLowestVariation()
        {
            Model.SelectedVariation = Model.MinVariation;
        }

        private void SelectHighestVariation()
        {
            Model.SelectedVariation = Model.MaxVariation;
        }

        private void SelectVariationByMouseButton(bool isLeftMouseButton)
        {
            if (isLeftMouseButton)
            {
                SelectHighestVariation();
            }
            else
            {
                SelectLowestVariation();
            }
        }

        private void SelectNextVariation()
        {
            var next = Model.ActionsByObjectTarget.Select(ps => ps.Action.Size)
                .Where(i => i > (Model.SelectedVariation ?? int.MinValue)).ToArray();

            if (next.Any())
            {
                Model.SelectedVariation = next.Min();
            }
            else
            {
                SelectLowestVariation();
            }
        }

        private void VisualizeSelectedMove()
        {
            switch (Model.SelectionState)
            {
                case SelectionState.Unselected:
                    Model.EditorState = Model.CommittedState.DeepCopy();
                    Model.InHand = Cell.Empty;
                    break;
                case SelectionState.EmptySelected:
                case SelectionState.MoveSelected:
                    if (Model.ActionsByObjectTarget?.Any() ?? false)
                    {
                        Model.EditorState = Model.ActionsByObjectTargetSize.First().Action.Apply(Model.CommittedState);
                    }
                    else
                    {
                        Model.EditorState = Model.CommittedState.DeepCopy();
                    }
                    Model.InHand = Cell.Empty;
                    break;
                case SelectionState.PieceInHand:
                    Model.EditorState = Model.CommittedState.DeepCopy();
                    Model.InHand = Model.EditorState[Model.SelectionObject];
                    Model.EditorState[Model.SelectionObject] = Cell.Empty;
                    break;
                case SelectionState.SplitInHand:
                    Model.EditorState = Model.CommittedState.DeepCopy();
                    var min = Model.MinVariation ?? 1;
                    var max = Model.MaxVariation ?? Model.EditorState[Model.SelectionObject].GetSize();
                    var takeWith = Math.Max(1, max - min);
                    Model.InHand = Model.EditorState[Model.SelectionObject].SetSize(takeWith);
                    Model.EditorState[Model.SelectionObject] = Model.EditorState[Model.SelectionObject].SetSize(Math.Max(1, min));
                    break;
            }
            //Console.WriteLine($"{Model.SelectionState}: {Model.SelectionObject} -> {Model.SelectionTarget} {Model.MinVariation}--{Model.SelectedVariation}--{Model.MaxVariation}");
            //if (Model.AvailableActions != null) Console.WriteLine($"{Model.AvailableActions.Count} available total");
            //else return;
            //Console.Write("AllSelectionActions: ");
            //foreach (var action in Model.ActionsByObjectTarget) Console.Write(action.ToString() + " ");
            //Console.WriteLine();
            //Console.Write("SelectionFilteredActions: ");
            //foreach (var action in Model.ActionsByObjectTargetSize) Console.Write(action.ToString() + " ");
            //Console.WriteLine();
            //if (Model.HighlightLocations != null) foreach (var loc in Model.HighlightLocations) Console.Write(loc.ToString() + " ");
            //Console.WriteLine();
            //Console.WriteLine();

            View.RedrawBoard();
            View.UpdateGameMoveGrid();
        }

        private void ViewOnInputEvent(object sender, BoardLocationEventArgs e)
        {
            if (!Movement.IsValidLocation(e.Location)) return;
            var contents = Model.CommittedState[e.Location];
            var targetType = GetMouseTargetType(Model, e.Location, contents);

            switch (Model.SelectionState)
            {
                case SelectionState.Unselected:
                    HandleInputUnselected(e, targetType, contents);
                    break;
                case SelectionState.EmptySelected:
                    HandleInputEmptySelected(e, targetType, contents);
                    break;
                case SelectionState.PieceInHand:
                    HandleInputPieceInHand(e, targetType, contents);
                    break;
                case SelectionState.SplitInHand:
                    HandleInputSplitInHand(e, targetType, contents);
                    break;
                case SelectionState.MoveSelected:
                    HandleInputMoveSelected(e, targetType, contents);
                    break;
            }
        }

        private void HandleInputUnselected(BoardLocationEventArgs e, MouseTargetFlags targetType, Cell contents)
        {
            if (e.MouseEvent != BoardMouseEventType.LeftClick && e.MouseEvent != BoardMouseEventType.LeftDragStart &&
                e.MouseEvent != BoardMouseEventType.RightClick && e.MouseEvent != BoardMouseEventType.RightDragStart) return;

            var lmb = e.MouseEvent != BoardMouseEventType.RightClick &&
                      e.MouseEvent != BoardMouseEventType.RightDragStart;

            switch (targetType)
            {
                case DeselectedEmptySpace:
                    Model.SelectionObject = e.Location;
                    Model.SelectionState = SelectionState.EmptySelected;
                    SelectVariationByMouseButton(lmb);
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnPiece:
                    Model.SelectionObject = e.Location;
                    Model.SelectionState = SelectionState.PieceInHand;
                    SelectHighestVariation();
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnStack:
                    Model.SelectionObject = e.Location;
                    SelectVariationByMouseButton(lmb);
                    Model.SelectionState = lmb ? SelectionState.PieceInHand : SelectionState.SplitInHand;
                    VisualizeSelectedMove();
                    break;
            }
        }

        private void HandleInputEmptySelected(BoardLocationEventArgs e, MouseTargetFlags targetType, Cell contents)
        {
            if (e.MouseEvent != BoardMouseEventType.LeftClick && e.MouseEvent != BoardMouseEventType.LeftDragStart &&
                e.MouseEvent != BoardMouseEventType.RightClick && e.MouseEvent != BoardMouseEventType.RightDragStart) return;

            var lmb = e.MouseEvent != BoardMouseEventType.RightClick &&
                      e.MouseEvent != BoardMouseEventType.RightDragStart;


            switch (targetType)
            {
                case DeselectedEmptySpace:
                    Model.SelectionObject = e.Location;
                    SelectVariationByMouseButton(lmb);
                    VisualizeSelectedMove();
                    break;
                case SelectedEmptySpace:
                    SelectNextVariation();
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnPiece:
                    Model.SelectionObject = e.Location;
                    Model.SelectionState = SelectionState.PieceInHand;
                    SelectHighestVariation();
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnStack:
                    Model.SelectionObject = e.Location;
                    Model.SelectionState = lmb ? SelectionState.PieceInHand : SelectionState.SplitInHand;
                    SelectVariationByMouseButton(lmb);
                    VisualizeSelectedMove();
                    break;
                case DeselectedOpponentPiece:
                case DeselectedOpponentStack:
                    Model.SelectionObject = Location.Undefined;
                    Model.SelectionState = SelectionState.Unselected;
                    Model.SelectedVariation = null;
                    VisualizeSelectedMove();
                    break;
            }
        }

        private void HandleInputPieceInHand(BoardLocationEventArgs e, MouseTargetFlags targetType, Cell contents)
        {
            if (e.MouseEvent != BoardMouseEventType.LeftClick && e.MouseEvent != BoardMouseEventType.LeftDragEnd &&
                e.MouseEvent != BoardMouseEventType.RightClick && e.MouseEvent != BoardMouseEventType.RightDragEnd &&
                e.MouseEvent != BoardMouseEventType.PartialDropContinueDrag) return;

            var lmb = e.MouseEvent != BoardMouseEventType.RightClick &&
                      e.MouseEvent != BoardMouseEventType.RightDragEnd&&
                      e.MouseEvent != BoardMouseEventType.PartialDropContinueDrag;

            switch (targetType)
            {
                case DeselectedEmptySpace: //not a valid target for this piece -- keep piece in hand
                case DeselectedOwnPiece:
                case DeselectedOpponentPiece:
                case DeselectedOwnStack:
                case DeselectedOpponentStack:
                    break;
                case HighlightedEmptySpace: //valid target for this piece
                case HighlightedOwnPiece:
                case HighlightedOpponentPiece:
                case HighlightedOwnStack:
                case HighlightedOpponentStack:
                    Model.SelectionTarget = e.Location;
                    Model.SelectionState = SelectionState.MoveSelected;
                    SelectVariationByMouseButton(lmb);
                    VisualizeSelectedMove();
                    break;
                case SelectedOwnPiece: //re-clicked the same piece we just picked up, or dropped it back where we picked it up from
                case SelectedOwnStack:
                    Model.SelectionTarget = Location.Undefined;
                    Model.SelectionObject = Location.Undefined;
                    Model.SelectionState = SelectionState.Unselected;
                    Model.SelectedVariation = null;
                    VisualizeSelectedMove();
                    break;
            }
        }

        private void HandleInputSplitInHand(BoardLocationEventArgs e, MouseTargetFlags targetType, Cell contents)
        {
            if (e.MouseEvent != BoardMouseEventType.LeftClick && e.MouseEvent != BoardMouseEventType.LeftDragEnd &&
                e.MouseEvent != BoardMouseEventType.RightClick && e.MouseEvent != BoardMouseEventType.RightDragEnd &&
                e.MouseEvent != BoardMouseEventType.PartialDropContinueDrag) return;

            var lmb = e.MouseEvent != BoardMouseEventType.RightClick &&
                      e.MouseEvent != BoardMouseEventType.RightDragEnd&&
                      e.MouseEvent != BoardMouseEventType.PartialDropContinueDrag;

            switch (targetType)
            {
                case DeselectedEmptySpace: //not a valid target for this piece -- keep piece in hand
                case DeselectedOwnPiece:
                case DeselectedOpponentPiece:
                case DeselectedOwnStack:
                case DeselectedOpponentStack:
                    break;
                case HighlightedEmptySpace: //valid target for this piece
                case HighlightedOwnPiece:
                case HighlightedOpponentPiece:
                case HighlightedOwnStack:
                case HighlightedOpponentStack:
                    Model.SelectionTarget = e.Location;
                    SelectLowestVariation();
                    Model.SelectionState = SelectionState.MoveSelected;
                    VisualizeSelectedMove();
                    break;
                case SelectedOwnPiece: //re-clicked the same piece we just picked up
                    Model.SelectionObject = Location.Undefined;
                    Model.SelectionTarget = Location.Undefined;
                    Model.SelectionState = SelectionState.Unselected;
                    Model.SelectedVariation = null;
                    VisualizeSelectedMove();
                    break;
                case SelectedOwnStack: //re-clicked the same stack we just picked up part of
                    if (lmb) //on left click, put the partial stack back down.
                    {
                        Model.SelectionObject = Location.Undefined;
                        Model.SelectionTarget = Location.Undefined;
                        Model.SelectionState = SelectionState.Unselected;
                        Model.SelectedVariation = null;
                    }
                    else //on right click, pick up the rest of the stack and make it a full piece
                    {
                        SelectHighestVariation();
                        Model.SelectionState = SelectionState.PieceInHand;
                    }
                    VisualizeSelectedMove();
                    break;
            }
        }

        private void HandleInputMoveSelected(BoardLocationEventArgs e, MouseTargetFlags targetType, Cell contents)
        {
            if (e.MouseEvent != BoardMouseEventType.LeftClick && e.MouseEvent != BoardMouseEventType.LeftDragStart &&
                e.MouseEvent != BoardMouseEventType.RightClick && e.MouseEvent != BoardMouseEventType.RightDragStart) return;

            var lmb = e.MouseEvent != BoardMouseEventType.RightClick &&
                      e.MouseEvent != BoardMouseEventType.RightDragStart;

            switch (targetType)
            {
                case DeselectedEmptySpace: //undoing selected move and changing to a place/block
                    Model.SelectionObject = e.Location;
                    Model.SelectionTarget = Location.Undefined;
                    Model.SelectionState = SelectionState.EmptySelected;
                    SelectVariationByMouseButton(lmb);
                    VisualizeSelectedMove();
                    break;
                case TargetedEmptySpace: //picking dropped piece back up to place it somewhere else on LMB
                case SelectedOwnPiece:   //or rotating selection options on RMB
                case TargetedOwnPiece:
                case TargetedOpponentPiece:
                case SelectedOwnStack:
                case TargetedOwnStack:
                case TargetedOpponentStack:
                    if (lmb)
                    {
                        Model.SelectionTarget = Location.Undefined;
                        if (Model.SelectedVariation == Model.MaxVariation)
                        {
                            //pick up entire piece
                            Model.SelectionState = SelectionState.PieceInHand;
                            SelectHighestVariation();
                        }
                        else
                        {
                            //partial stack was placed so pick up partial stack
                            Model.SelectionState = SelectionState.SplitInHand;
                            SelectLowestVariation();
                        }
                    }
                    else
                    {
                        SelectNextVariation();
                        //Model.SelectionState = Model.SelectedVariation == Model.MaxVariation
                        //    ? SelectionState.PieceInHand
                        //    : SelectionState.SplitInHand;
                    }
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnPiece: //abandoning existing move and picking up a new piece
                    Model.SelectionObject = e.Location;
                    Model.SelectionTarget = Location.Undefined;
                    Model.SelectionState = SelectionState.PieceInHand;
                    SelectHighestVariation();
                    VisualizeSelectedMove();
                    break;
                case DeselectedOwnStack: //abandoning existing move and picking up all or part of a new stack
                    Model.SelectionObject = e.Location;
                    Model.SelectionTarget = Location.Undefined;
                    SelectVariationByMouseButton(lmb);
                    Model.SelectionState = lmb ? SelectionState.PieceInHand : SelectionState.SplitInHand;
                    VisualizeSelectedMove();
                    break;
            }
        }

        private static MouseTargetFlags GetMouseTargetType(IGamePlayerModel model, Location location, Cell contents)
        {
            var flags = MouseTargetFlags.None;
            
            if (location == model.SelectionObject)
            {
                flags |= MouseTargetFlags.Selection;
            }
            else if (location == model.SelectionTarget)
            {
                flags |= MouseTargetFlags.Selection | MouseTargetFlags.Target;
            }
            else if (model.HighlightLocations?.Contains(location) ?? false)
            {
                flags |= MouseTargetFlags.Target;
            }

            if (!contents.IsPiece()) return flags;

            if (contents.GetSide(model.CommittedState.Flags.IsRedTurn(), model.CommittedState.Flags.IsBlueTurn(), false))
            {
                flags |= MouseTargetFlags.OwnPiece;
            }
            else
            {
                flags |= MouseTargetFlags.OpponentPiece;
            }

            if (contents.IsStack())
            {
                flags |= MouseTargetFlags.Stack;
            }

            return flags;
        }

        private const MouseTargetFlags DeselectedEmptySpace = MouseTargetFlags.None;
        private const MouseTargetFlags HighlightedEmptySpace = MouseTargetFlags.Target;
        private const MouseTargetFlags SelectedEmptySpace = MouseTargetFlags.Selection;
        private const MouseTargetFlags TargetedEmptySpace = MouseTargetFlags.Selection | MouseTargetFlags.Target;
        private const MouseTargetFlags DeselectedOwnPiece = MouseTargetFlags.OwnPiece;
        private const MouseTargetFlags HighlightedOwnPiece = MouseTargetFlags.OwnPiece | MouseTargetFlags.Target;
        private const MouseTargetFlags SelectedOwnPiece = MouseTargetFlags.OwnPiece | MouseTargetFlags.Selection;
        private const MouseTargetFlags TargetedOwnPiece = MouseTargetFlags.OwnPiece | MouseTargetFlags.Selection | MouseTargetFlags.Target;
        private const MouseTargetFlags DeselectedOpponentPiece = MouseTargetFlags.OpponentPiece;
        private const MouseTargetFlags HighlightedOpponentPiece = MouseTargetFlags.OpponentPiece | MouseTargetFlags.Target;
        private const MouseTargetFlags SelectedOpponentPiece = MouseTargetFlags.OpponentPiece | MouseTargetFlags.Selection;
        private const MouseTargetFlags TargetedOpponentPiece = MouseTargetFlags.OpponentPiece | MouseTargetFlags.Selection | MouseTargetFlags.Target;
        private const MouseTargetFlags DeselectedOwnStack = MouseTargetFlags.Stack | MouseTargetFlags.OwnPiece;
        private const MouseTargetFlags HighlightedOwnStack = MouseTargetFlags.Stack | MouseTargetFlags.OwnPiece | MouseTargetFlags.Target;
        private const MouseTargetFlags SelectedOwnStack = MouseTargetFlags.Stack | MouseTargetFlags.OwnPiece | MouseTargetFlags.Selection;
        private const MouseTargetFlags TargetedOwnStack = MouseTargetFlags.Stack | MouseTargetFlags.OwnPiece | MouseTargetFlags.Selection | MouseTargetFlags.Target;
        private const MouseTargetFlags DeselectedOpponentStack = MouseTargetFlags.Stack | MouseTargetFlags.OpponentPiece;
        private const MouseTargetFlags HighlightedOpponentStack = MouseTargetFlags.Stack | MouseTargetFlags.OpponentPiece | MouseTargetFlags.Target;
        private const MouseTargetFlags SelectedOpponentStack = MouseTargetFlags.Stack | MouseTargetFlags.OpponentPiece | MouseTargetFlags.Selection;
        private const MouseTargetFlags TargetedOpponentStack = MouseTargetFlags.Stack | MouseTargetFlags.OpponentPiece | MouseTargetFlags.Selection | MouseTargetFlags.Target;
    }
}
