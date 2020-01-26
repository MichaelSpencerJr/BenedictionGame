using System;
using System.Collections.Generic;
using System.Drawing;
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
        private void btnClearBoard_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            _model.EditorState = new State();
            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnExportBoard_Click(object sender, EventArgs e)
        {
            txtBoardData.Text = _model.CommittedState.ToString();
        }

        private void btnImportBoard_Click(object sender, EventArgs e)
        {
            try
            {
                NavigateEvent?.Invoke(sender,
                    new BoardNavigationEventArgs
                        {EventType = NavigationEventType.LoadGame, Selected = new State(txtBoardData.Text.Trim())});
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Unable to load board");
            }
        }

        private void btnUnselectCell_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            _model.SelectionObject = Board.Location.Undefined;
            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnClearEmptyCell_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.EditorState[_model.SelectionObject] = Cell.Empty;
            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnRedHomeHere_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.EditorState.RedHome = _model.SelectionObject;

            if (_model.EditorState.BlueHome == _model.EditorState.RedHome)
            {
                _model.EditorState.BlueHome = Board.Location.Undefined;
            }

            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnBlueHomeHere_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.EditorState.BlueHome = _model.SelectionObject;

            if (_model.EditorState.BlueHome == _model.EditorState.RedHome)
            {
                _model.EditorState.RedHome = Board.Location.Undefined;
            }

            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnBlockadeHere_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.EditorState[_model.SelectionObject] = Cell.Block;
            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnRedPieceHere_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if (!_model.EditorState[_model.SelectionObject].IsPiece())
            {
                _model.EditorState[_model.SelectionObject] = Cell.SideRed | Cell.Size1;
            }
            else
            {
                _model.EditorState[_model.SelectionObject] = _model.EditorState[_model.SelectionObject].SetFlag(Cell.SideRed, true);
            }

            RedrawBoard();
            BoardEditorUpdate();
        }

        private void btnBluePieceHere_Click(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if (!_model.EditorState[_model.SelectionObject].IsPiece())
            {
                _model.EditorState[_model.SelectionObject] = Cell.Size1;
            }
            else
            {
                _model.EditorState[_model.SelectionObject] = _model.EditorState[_model.SelectionObject].SetFlag(Cell.SideRed, false);
            }

            RedrawBoard();
            BoardEditorUpdate();
        }

        private void nudStackSize_ValueChanged(object sender, EventArgs e)
        {
            if (!_model.EditMode) return;
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if (!_model.EditorState[_model.SelectionObject].IsPiece()) return;
            var newSize = Convert.ToInt32(nudStackSize.Value);
            if (newSize < 1 || newSize > 15) return;
            _model.EditorState[_model.SelectionObject] = _model.EditorState[_model.SelectionObject].SetSize(newSize);

            RedrawBoard();
            BoardEditorUpdate();
        }

        private void chkCell_CheckedChanged(object sender, EventArgs e)
        {
            if (!_model.EditMode || !Movement.IsValidLocation(_model.SelectionObject) ||
                !_model.EditorState[_model.SelectionObject].IsPiece() || !(sender is CheckBox cb))
            {
                return;
            }

            Cell targetFlag;

            if (cb == chkKing) targetFlag = Cell.King;
            else if (cb == chkBlessed) targetFlag = Cell.Blessed;
            else if (cb == chkCursePending) targetFlag = Cell.CursePending;
            else if (cb == chkCursed) targetFlag = Cell.Cursed;
            else if (cb == chkLocked) targetFlag = Cell.Locked;
            else return;

            _model.EditorState[_model.SelectionObject] =
                _model.EditorState[_model.SelectionObject].SetFlag(targetFlag, cb.Checked);
            
            RedrawBoard();
            BoardEditorUpdate();
        }

        private void chkFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!_model.EditMode || !(sender is CheckBox cb))
            {
                return;
            }

            StateFlags targetFlag;

            if (cb == chkRedT1) targetFlag = StateFlags.RedAction1;
            else if (cb == chkRedT2) targetFlag = StateFlags.RedAction2;
            else if (cb == chkBlueT1) targetFlag = StateFlags.BlueAction1;
            else if (cb == chkBlueT2) targetFlag = StateFlags.BlueAction2;
            else if (cb == chkRedKingTaken) targetFlag = StateFlags.RedKingTaken;
            else if (cb == chkBlueKingTaken) targetFlag = StateFlags.BlueKingTaken;
            else if (cb == chkRedWin) targetFlag = StateFlags.RedWin;
            else if (cb == chkBlueWin) targetFlag = StateFlags.BlueWin;
            else return;

            _model.EditorState.Flags = _model.EditorState.Flags.SetFlag(targetFlag, cb.Checked);

            RedrawBoard();
        }

        private void btnBoardImageToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(BoardPainter.DrawBoard(_model.EditorState ?? _model.CommittedState, Board.Location.Undefined,
                Board.Location.Undefined, null, false, Point.Empty));
        }


        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            NavigateEvent?.Invoke(sender,
                new BoardNavigationEventArgs {EventType = NavigationEventType.Editor, Selected = _model.EditorState});
        }
    }
}
