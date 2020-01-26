using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benediction.Actions;
using Benediction.Board;

namespace Benediction.View
{
    public partial class GamePlayerView
    {
        private void pbBoard_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateMouse(e);
            var mouseLocation = BoardPainter.GetBoardLocation(_lastMouse);

            if (_model.EditMode)
            {
                if (Movement.IsValidLocation(mouseLocation))
                {
                    _model.SelectionObject = mouseLocation;
                    BoardEditorUpdate();
                    RedrawBoard();
                }

                return;
            }

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                _lmbDown = true;
            }
            else if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                _rmbDown = true;
            }

            if (!Movement.IsValidLocation(mouseLocation)) return;
            _lastEventLocation = mouseLocation;
        }

        private void pbBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_model.EditMode) return;
            UpdateMouse(e);
            var mouseLocation = BoardPainter.GetBoardLocation(_lastMouse);
            if (!Movement.IsValidLocation(mouseLocation)) return;
            if (_lmbDown)
            {
                if (mouseLocation != _lastEventLocation)
                {
                    if (!_lmbDrag && !_rmbDrag)
                    {
                        InputEvent?.Invoke(sender,
                            new BoardLocationEventArgs
                                {Location = _lastEventLocation, MouseEvent = BoardMouseEventType.LeftDragStart});
                    }

                    InputEvent?.Invoke(sender,
                        new BoardLocationEventArgs {Location = mouseLocation, MouseEvent = BoardMouseEventType.Hover});
                    _lastEventLocation = mouseLocation;
                    if (!_rmbDrag) _lmbDrag = true;
                }
            }
            else if (_rmbDown)
            {
                if (mouseLocation != _lastEventLocation)
                {
                    if (!_lmbDrag && !_rmbDrag)
                    {
                        InputEvent?.Invoke(sender,
                            new BoardLocationEventArgs
                                {Location = _lastEventLocation, MouseEvent = BoardMouseEventType.RightDragStart});
                    }

                    InputEvent?.Invoke(sender,
                        new BoardLocationEventArgs {Location = mouseLocation, MouseEvent = BoardMouseEventType.Hover});
                    _lastEventLocation = mouseLocation;
                    if (!_lmbDrag) _rmbDrag = true;
                }
            }
            else
            {
                if (mouseLocation != _lastEventLocation)
                {
                    InputEvent?.Invoke(sender,
                        new BoardLocationEventArgs {Location = mouseLocation, MouseEvent = BoardMouseEventType.Hover});
                    _lastEventLocation = mouseLocation;
                }
            }

            RedrawBoard();
        }

        private void pbBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (_model.EditMode) return;
            UpdateMouse(e);
            var mouseLocation = BoardPainter.GetBoardLocation(_lastMouse);
            if (!Movement.IsValidLocation(mouseLocation)) return;
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && _lmbDown)
            {
                _lmbDown = false;
                InputEvent?.Invoke(sender,
                    new BoardLocationEventArgs
                    {
                        Location = mouseLocation,
                        MouseEvent = _rmbDrag
                            ? BoardMouseEventType.PartialDropContinueDrag
                            : _lmbDrag
                                ? BoardMouseEventType.LeftDragEnd
                                : BoardMouseEventType.LeftClick
                    });
                _lmbDrag = false;
            }
            else if ((e.Button & MouseButtons.Right) == MouseButtons.Right && _rmbDown)
            {
                _rmbDown = false;
                InputEvent?.Invoke(sender,
                    new BoardLocationEventArgs
                    {
                        Location = mouseLocation,
                        MouseEvent = _lmbDrag
                            ? BoardMouseEventType.PartialDropContinueDrag
                            : _rmbDrag
                                ? BoardMouseEventType.RightDragEnd
                                : BoardMouseEventType.RightClick
                    });
                _rmbDrag = false;
            }

            _lastEventLocation = mouseLocation;
            BoardEditorUpdate();
        }

        private void btnEditBoard_Click(object sender, EventArgs e)
        {
            NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs {EventType = NavigationEventType.ToggleEditMode});
        }

        private void btnClearMove_Click(object sender, EventArgs e)
        {
            NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs {EventType = NavigationEventType.ClearMove});
        }

        private void btnCommitMove_Click(object sender, EventArgs e)
        {
            NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs {EventType = NavigationEventType.CommitMove});
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (_model.EditMode)
            {
                NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs {EventType = NavigationEventType.ToggleEditMode});
            }

            NavigateEvent?.Invoke(sender,
                new BoardNavigationEventArgs {EventType = NavigationEventType.NewGame, Selected = new State()});
            btnCommitMove.Select();
        }
        private void dgvGameState_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvGameState.RowCount) return;
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvGameState.Rows[e.RowIndex].Cells.Count) return;

            if (!(dgvGameState.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag is State selectedState)) return;

            if (selectedState.Equals(_model.CommittedState))
            {
                NavigateEvent?.Invoke(sender,
                    new BoardNavigationEventArgs
                    {
                        EventType = NavigationEventType.ClearMove,
                        Selected = selectedState
                    });
            }
            else
            {
                NavigateEvent?.Invoke(sender,
                    new BoardNavigationEventArgs
                    {
                        EventType = NavigationEventType.ShowHistory,
                        Selected = selectedState
                    });
            }
        }
    }
}