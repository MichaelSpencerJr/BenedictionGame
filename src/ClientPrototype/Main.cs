using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benediction.Actions;
using Benediction.Board;
using Exception = System.Exception;

namespace Benediction
{
    public partial class Main : Form
    {
        private State _board = new State();
        private Location _selection = Board.Location.Undefined;
        private GameAction _action;
        private bool _suspendEvents = false;

        public Main()
        {
            InitializeComponent();
        }

        private void pbBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(sender is PictureBox pbClicked)) return;
            if (pbClicked != pbBoard) return;

            var boardCoordinates = GetBoardCoordinates(e.X, e.Y);
            var location = Painter.GetBoardLocation(boardCoordinates);

            if (Movement.IsValidLocation(location))
            {
                _selection = location;
                if (_action != null)
                {
                    if (rbPlayerLocation.Checked)
                    {
                        _action.Location = location;
                    }
                    else if (rbPlayerTarget.Checked && _action is GameTargetAction gta)
                    {
                        gta.Target = location;
                    }
                }
            }
            else
            {
                _selection = Board.Location.Undefined;
            }

            DrawBoard();
            UpdateEditor();
            UpdatePlayerMoveControls();
        }

        private Point GetBoardCoordinates(int x, int y)
        {
            var actualWidth = splitContainer1.Panel1.Width;
            var actualHeight = splitContainer1.Panel1.Height;

            //First identify if we are letter-boxed or pillar-boxed
            var expectedHeight = Painter.BoardHeight * actualWidth / Painter.BoardWidth;
            if (expectedHeight > actualHeight)
            {
                //We are pillar boxed.  Identify how much of the image on the left is blank.
                var expectedWidth = actualHeight * Painter.BoardWidth / Painter.BoardHeight;
                var widthGap = (actualWidth - expectedWidth) / 2;
                return new Point((x - widthGap) * Painter.BoardHeight / actualHeight,
                    y * Painter.BoardHeight / actualHeight);
            }

            //We are letter boxed.  Identify how much of the image on the top is blank.
            expectedHeight = actualWidth * Painter.BoardHeight / Painter.BoardWidth;
            var heightGap = (actualHeight - expectedHeight) / 2;
            return new Point(x * Painter.BoardWidth / actualWidth,
                (y - heightGap) * Painter.BoardWidth / actualWidth);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DrawBoard();
            UpdateEditor();
        }

        private void DrawBoard()
        {
            pbBoard.Image = Painter.DrawBoard(_board, _selection);
        }

        private void SetEnableState(bool unselect = false, bool clearEmpty = false, bool redHome = false,
            bool blueHome = false, bool blockade = false, bool redPiece = false, bool bluePiece = false,
            bool stackSize = false, bool king = false, bool blessed = false, bool cursed = false, int stack = 0,
            bool kingSet = false, bool blessSet = false, bool curseSet = false)
        {
            btnUnselectCell.Enabled = unselect;
            btnClearEmptyCell.Enabled = clearEmpty;
            btnRedHomeHere.Enabled = redHome;
            btnBlueHomeHere.Enabled = blueHome;
            btnBlockadeHere.Enabled = blockade;
            btnRedPieceHere.Enabled = redPiece;
            btnBluePieceHere.Enabled = bluePiece;
            nudStackSize.Enabled = stackSize;
            nudStackSize.Value = stack;
            chkKing.Enabled = king;
            chkKing.Checked = kingSet;
            chkBlessed.Enabled = blessed;
            chkBlessed.Checked = blessSet;
            chkCursed.Enabled = cursed;
            chkCursed.Checked = curseSet;
        }

        private void UpdateEditor()
        {
            if (!Movement.IsValidLocation(_selection))
            {
                SetEnableState();
                return;
            }

            var isNotRedHome = _selection != _board.RedHome;
            var isNotBlueHome = _selection != _board.BlueHome;

            var selectedPiece = _board[_selection];
            if (selectedPiece == Cell.Empty)
            {
                SetEnableState(true, false, isNotRedHome, isNotBlueHome, true, true, true);
                return;
            }

            if (selectedPiece == Cell.Blockade)
            {
                SetEnableState(true, true, isNotRedHome, isNotBlueHome, true, true, true);
                return;
            }

            var size = (int)(selectedPiece & Cell.SizeMask);
            var isRed = (selectedPiece & Cell.SideRed) > 0;
            var isKing = (selectedPiece & Cell.King) > 0;
            var isBlessed = (selectedPiece & Cell.Blessed) > 0;
            var isCursed = (selectedPiece & Cell.Cursed) > 0;
            SetEnableState(true, true, isNotRedHome, isNotBlueHome, true, !isRed, isRed, true, true, true, true, size,
                isKing, isBlessed, isCursed);
        }

        private void btnClearBoard_Click(object sender, EventArgs e)
        {
            _board = new State();
            DrawBoard();
            UpdateEditor();
        }

        private void btnExportBoard_Click(object sender, EventArgs e)
        {
            txtBoardData.Text = _board.GetBase64();
        }

        private void btnImportBoard_Click(object sender, EventArgs e)
        {
            try
            {
                _board = State.FromBase64Gz(txtBoardData.Text.Trim());
                DrawBoard();
                UpdateEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Unable to load board");
            }
        }

        private void btnUnselectCell_Click(object sender, EventArgs e)
        {
            _selection = Board.Location.Undefined;
            DrawBoard();
            UpdateEditor();
        }

        private void btnClearEmptyCell_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board[_selection] = Cell.Empty;
            DrawBoard();
            UpdateEditor();
        }

        private void btnRedHomeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board.RedHome = _selection;

            if (_board.BlueHome == _board.RedHome)
            {
                _board.BlueHome = Board.Location.Undefined;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBlueHomeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board.BlueHome = _selection;

            if (_board.BlueHome == _board.RedHome)
            {
                _board.RedHome = Board.Location.Undefined;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBlockadeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board[_selection] = Cell.Blockade;
            DrawBoard();
            UpdateEditor();
        }

        private void btnRedPieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if (_board[_selection] == Cell.Empty || _board[_selection] == Cell.Blockade)
            {
                _board[_selection] = Cell.SideRed | Cell.Size1;
            }
            else
            {
                _board[_selection] |= Cell.SideRed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBluePieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if (_board[_selection] == Cell.Empty || _board[_selection] == Cell.Blockade)
            {
                _board[_selection] = Cell.Size1;
            }
            else
            {
                _board[_selection] &= ~Cell.SideRed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void nudStackSize_ValueChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & Cell.SizeMask) == 0) return;
            var newSize = Convert.ToInt32(nudStackSize.Value);
            if (newSize < 1 || newSize > 15) return;
            _board[_selection] = (_board[_selection] & ~Cell.SizeMask) | (Cell) newSize;

            DrawBoard();
            UpdateEditor();
        }

        private void chkKing_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & Cell.SizeMask) == 0) return;

            if (chkKing.Checked)
            {
                _board[_selection] |= Cell.King;
            }
            else
            {
                _board[_selection] &= ~Cell.King;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void chkBlessed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & Cell.SizeMask) == 0) return;

            if (chkBlessed.Checked)
            {
                _board[_selection] |= Cell.Blessed;
            }
            else
            {
                _board[_selection] &= ~Cell.Blessed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void chkCursed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & Cell.SizeMask) == 0) return;

            if (chkCursed.Checked)
            {
                _board[_selection] |= Cell.Cursed;
            }
            else
            {
                _board[_selection] &= ~Cell.Cursed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBoardImageToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(Painter.DrawBoard(_board, _selection));
        }

        private void UpdateFlag(bool value, StateFlags flagMask)
        {
            if (value)
            {
                _board.Flags |= flagMask;
            }
            else
            {
                _board.Flags &= ~flagMask;
            }

            DrawBoard();
        }

        private void chkRedT1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkRedT1.Checked, StateFlags.RedAction1);
        }

        private void chkRedT2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkRedT2.Checked, StateFlags.RedAction2);
        }

        private void chkBlueT1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkBlueT1.Checked, StateFlags.BlueAction1);
        }

        private void chkBlueT2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkBlueT2.Checked, StateFlags.BlueAction2);
        }

        private void chkRedKingTaken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkRedKingTaken.Checked, StateFlags.RedKingTaken);
        }

        private void chkBlueKingTaken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkBlueKingTaken.Checked, StateFlags.BlueKingTaken);
        }

        private void chkRedWin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkRedWin.Checked, StateFlags.RedWin);
        }

        private void chkBlueWin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlag(chkBlueWin.Checked, StateFlags.BlueWin);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                _board = State.FromBase64Gz("H4sIAAAAAAAEAGNgIAwUgRAGGIEQyGdSRPCZGDFUEAOeMKgwMHps4tmqYN778uuiAz6mrq1VAOt/fh2PAAAA");
                DrawBoard();
                UpdateEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Unable to load board");
            }
        }

        private void UpdatePlayerMoveControls()
        {
            if ((_board.Flags & (StateFlags.RedWin | StateFlags.BlueWin)) > 0)
            {
                groupBoxPlayer.Visible = false;
                groupBoxMove.Visible = false;
                groupBoxLocation.Visible = false;
                btnPlayerCommitMove.Enabled = false;
                return;
            }
            if (!(_action is GameAction singleAction))
            {
                groupBoxPlayer.Visible = true;
                groupBoxMove.Visible = true;
                groupBoxLocation.Visible = false;
                nudPlayerSplitNumber.Visible = false;
                btnPlayerCommitMove.Enabled = false;
                return;
            }
            groupBoxPlayer.Visible = true;
            groupBoxMove.Visible = true;
            groupBoxLocation.Visible = true;

            if (!(_action is GameTargetAction targetAction))
            {
                rbPlayerTarget.Visible = false;
                lblPlayerTarget.Visible = false;
                nudPlayerSplitNumber.Visible = false;
            }
            else
            {
                rbPlayerTarget.Visible = true;
                lblPlayerTarget.Visible = true;
                lblPlayerTarget.Text = targetAction.Target.ToString();
                if (targetAction is GameSplitAction gsa)
                {
                    nudPlayerSplitNumber.Visible = true;
                    nudPlayerSplitNumber.Value = Math.Min(14, Math.Max(1, gsa.Size));
                }
                else
                {
                    nudPlayerSplitNumber.Visible = false;
                }

            }

            lblPlayerLocation.Text = singleAction.Location.ToString();
            switch (singleAction.Side)
            {
                case ActionSide.Red:
                    rbPlayerRed.Checked = true;
                    rbPlayerBlue.Checked = false;
                    break;
                case ActionSide.Blue:
                    rbPlayerRed.Checked = false;
                    rbPlayerBlue.Checked = true;
                    break;
                default:
                    rbPlayerRed.Checked = false;
                    rbPlayerBlue.Checked = false;
                    break;
            }

            _suspendEvents = true;
            rbPlayerBlock.Checked = singleAction is GameBlockAction;
            rbPlayerDrop.Checked = singleAction is GameDropAction;
            rbPlayerMerge.Checked = singleAction is GameMergeAction;
            rbPlayerMove.Checked = singleAction is GameMoveAction;
            rbPlayerSplit.Checked = singleAction is GameSplitAction;
            var error = singleAction.CheckError(_board);
            lblPlayerMoveError.Text = error ?? singleAction.ToString();
            btnPlayerCommitMove.Enabled = error == null;
            _suspendEvents = false;
        }

        private void btnPlayerClearMove_Click(object sender, EventArgs e)
        {
            _action = null;
            UpdatePlayerMoveControls();
        }

        private void btnPlayerCommitMove_Click(object sender, EventArgs e)
        {
            _board = GameAction.PrepareNextTurn(_action.Apply(_board));
            _selection = Board.Location.Undefined;
            DrawBoard();
            UpdateEditor();
            UpdatePlayerMoveControls();
        }

        private void rbPlayerRed_CheckedChanged(object sender, EventArgs e)
        {
            if (_action != null && rbPlayerRed.Checked)
            {
                _action.Side = ActionSide.Red;
                UpdatePlayerMoveControls();
            }
        }

        private void rbPlayerBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (_action != null && rbPlayerBlue.Checked)
            {
                _action.Side = ActionSide.Blue;
                UpdatePlayerMoveControls();
            }
        }

        private ActionSide SelectedSide =>
            rbPlayerRed.Checked ? ActionSide.Red : rbPlayerBlue.Checked ? ActionSide.Blue : ActionSide.Undefined;

        private void rbPlayerBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (!_suspendEvents && rbPlayerBlock.Checked)
            {
                _action = new GameBlockAction {Side = SelectedSide, Location = _selection};
                UpdatePlayerMoveControls();
            }
        }

        private void rbPlayerDrop_CheckedChanged(object sender, EventArgs e)
        {
            if (!_suspendEvents && rbPlayerDrop.Checked)
            {
                _action = new GameDropAction {Side = SelectedSide, Location = _selection};
                UpdatePlayerMoveControls();
            }
        }

        private void rbPlayerMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (!_suspendEvents && rbPlayerMerge.Checked)
            {
                if (_action is GameTargetAction gta)
                {
                    _action = new GameMergeAction {Side = SelectedSide, Location = gta.Location, Target = gta.Target};
                }
                else
                {
                    _action = new GameMergeAction {Side = SelectedSide, Location = _selection};
                }

                UpdatePlayerMoveControls();
            }
        }

        private void rbPlayerMove_CheckedChanged(object sender, EventArgs e)
        {
            if (!_suspendEvents && rbPlayerMove.Checked)
            {
                if (_action is GameTargetAction gta)
                {
                    _action = new GameMoveAction {Side = SelectedSide, Location = gta.Location, Target = gta.Target};
                }
                else
                {
                    _action = new GameMoveAction {Side = SelectedSide, Location = _selection};
                }

                UpdatePlayerMoveControls();
            }
        }

        private void rbPlayerSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (!_suspendEvents && rbPlayerSplit.Checked)
            {
                if (_action is GameTargetAction gta)
                {
                    _action = new GameSplitAction {Side = SelectedSide, Location = gta.Location, Target = gta.Target};
                }
                else
                {
                    _action = new GameSplitAction {Side = SelectedSide, Location = _selection};
                }

                UpdatePlayerMoveControls();
            }
        }
    }
}
