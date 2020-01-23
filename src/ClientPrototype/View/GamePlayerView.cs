using System;
using System.Drawing;
using System.Windows.Forms;
using Benediction.Actions;
using Benediction.Board;
using Benediction.Controller;
using Benediction.Game;
using Benediction.Model;
using Exception = System.Exception;

namespace Benediction.View
{
    public partial class GamePlayerView : Form, IGamePlayerView
    {
        private IGamePlayerModel _model;
        private IGamePlayerController _controller;
        private Point _lastMouse;
        private Point _keyDownMouse;
        private Location _lastEventLocation;
        private bool _lmbDown, _rmbDown, _lmbDrag, _rmbDrag;
        public event EventHandler<BoardLocationEventArgs> InputEvent;
        public event EventHandler<BoardNavigationEventArgs> NavigateEvent;


        public GamePlayerView()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tpHumanPlayer;
            _model = new GamePlayerModel {Game = new GameState {new NewGame()}};
            _controller = new GamePlayerController(_model, this);
            RedrawBoard();
            RedrawMoves();
            UpdateEditor();
        }

        private void pbBoard_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateMouse(e);
            var mouseLocation = BoardPainter.GetBoardLocation(_lastMouse);

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
            UpdateEditor();
        }

        private void pbBoard_MouseMove(object sender, MouseEventArgs e)
        {
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
            UpdateEditor();
        }

        private void UpdateMouse(MouseEventArgs e)
        {
            _lastMouse = GetBoardCoordinates(e.X, e.Y);
        }

        public void RedrawBoard()
        {
            var redSide = (_model.CommittedState.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2)) > 0;
            switch (_model.SelectionState)
            {
                case SelectionState.Unselected:
                    pbBoard.Image = BoardPainter.DrawBoard(_model.CommittedState, Board.Location.Undefined,
                        Board.Location.Undefined, _model.HighlightLocations, redSide,  Point.Empty);
                    break;
                case SelectionState.EmptySelected:
                    pbBoard.Image = BoardPainter.DrawBoard(_model.EditorState, _model.SelectionObject,
                        Board.Location.Undefined, _model.HighlightLocations, redSide, Point.Empty);
                    break;
                case SelectionState.PieceInHand:
                case SelectionState.SplitInHand:
                    pbBoard.Image = BoardPainter.DrawBoard(_model.EditorState, _model.SelectionObject,
                        Board.Location.Undefined, _model.HighlightLocations, redSide, _lastMouse, _model.InHand);
                    break;
                case SelectionState.MoveSelected:
                    pbBoard.Image = BoardPainter.DrawBoard(_model.EditorState, _model.SelectionObject,
                        _model.SelectionTarget, _model.HighlightLocations, redSide, Point.Empty);
                    break;
                //case SelectionState.PartialSplitSelected:
                //    pbBoard.Image = BoardPainter.DrawBoard(_model.EditorState, _model.SelectionObject,
                //        _model.SelectionTarget, _model.HighlightLocations, redSide, _lastMouse, _model.InHand);
                //    break;
                default:
                    return;
            }

            chkRedT1.Checked = (_model.CommittedState.Flags & StateFlags.RedAction1) > 0;
            chkRedT2.Checked = (_model.CommittedState.Flags & StateFlags.RedAction2) > 0;
            chkBlueT1.Checked = (_model.CommittedState.Flags & StateFlags.BlueAction1) > 0;
            chkBlueT2.Checked = (_model.CommittedState.Flags & StateFlags.BlueAction2) > 0;
            chkRedKingTaken.Checked = (_model.CommittedState.Flags & StateFlags.RedKingTaken) > 0;
            chkBlueKingTaken.Checked = (_model.CommittedState.Flags & StateFlags.BlueKingTaken) > 0;
            chkRedWin.Checked = (_model.CommittedState.Flags & StateFlags.RedWin) > 0;
            chkBlueWin.Checked = (_model.CommittedState.Flags & StateFlags.BlueWin) > 0;
        }

        public void RedrawMoves()
        {
            if (dgvGameState.Rows.Count > _model.Game.Count)
                dgvGameState.Rows.Clear();

            for (var i = 0; i < _model.Game.Count; i++)
            {
                if (dgvGameState.Rows.Count <= i)
                    dgvGameState.Rows.Add(i.ToString(), string.Empty, string.Empty, string.Empty, string.Empty);
                for (var j = 0; j < 4; j++)
                {
                    dgvGameState.Rows[i].Cells[j+1].Value = _model.Game.GridLog(i, j);
                }
            }
        }

        private Point GetBoardCoordinates(int x, int y)
        {
            var actualWidth = splitContainer1.Panel1.Width;
            var actualHeight = splitContainer1.Panel1.Height;

            //First identify if we are letter-boxed or pillar-boxed
            var expectedHeight = BoardPainter.BoardHeight * actualWidth / BoardPainter.BoardWidth;
            if (expectedHeight > actualHeight)
            {
                //We are pillar boxed.  Identify how much of the image on the left is blank.
                var expectedWidth = actualHeight * BoardPainter.BoardWidth / BoardPainter.BoardHeight;
                var widthGap = (actualWidth - expectedWidth) / 2;
                return new Point((x - widthGap) * BoardPainter.BoardHeight / actualHeight,
                    y * BoardPainter.BoardHeight / actualHeight);
            }

            //We are letter boxed.  Identify how much of the image on the top is blank.
            expectedHeight = actualWidth * BoardPainter.BoardHeight / BoardPainter.BoardWidth;
            var heightGap = (actualHeight - expectedHeight) / 2;
            return new Point(x * BoardPainter.BoardWidth / actualWidth,
                (y - heightGap) * BoardPainter.BoardWidth / actualWidth);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RedrawBoard();
            RedrawMoves();
            UpdateEditor();
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
            if (!Movement.IsValidLocation(_model.SelectionObject))
            {
                SetEnableState();
                return;
            }

            var isNotRedHome = _model.SelectionObject != _model.CommittedState.RedHome;
            var isNotBlueHome = _model.SelectionObject != _model.CommittedState.BlueHome;

            var selectedPiece = _model.CommittedState[_model.SelectionObject];
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

            var size = (int) (selectedPiece & Cell.SizeMask);
            var isRed = (selectedPiece & Cell.SideRed) > 0;
            var isKing = (selectedPiece & Cell.King) > 0;
            var isBlessed = (selectedPiece & Cell.Blessed) > 0;
            var isCursed = (selectedPiece & Cell.Cursed) > 0;
            SetEnableState(true, true, isNotRedHome, isNotBlueHome, true, !isRed, isRed, true, true, true, true, size,
                isKing, isBlessed, isCursed);
        }

        private void btnClearBoard_Click(object sender, EventArgs e)
        {
            _model.CommittedState = new State();
            RedrawBoard();
            UpdateEditor();
        }

        private void btnExportBoard_Click(object sender, EventArgs e)
        {
            txtBoardData.Text = _model.CommittedState.GetBase64();
        }

        private void btnImportBoard_Click(object sender, EventArgs e)
        {
            try
            {
                _model.CommittedState = State.FromBase64Gz(txtBoardData.Text.Trim());
                RedrawBoard();
                UpdateEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Unable to load board");
            }
        }

        private void btnUnselectCell_Click(object sender, EventArgs e)
        {
            _model.SelectionObject = Board.Location.Undefined;
            RedrawBoard();
            UpdateEditor();
        }

        private void btnClearEmptyCell_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.CommittedState[_model.SelectionObject] = Cell.Empty;
            RedrawBoard();
            UpdateEditor();
        }

        private void btnRedHomeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.CommittedState.RedHome = _model.SelectionObject;

            if (_model.CommittedState.BlueHome == _model.CommittedState.RedHome)
            {
                _model.CommittedState.BlueHome = Board.Location.Undefined;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void btnBlueHomeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.CommittedState.BlueHome = _model.SelectionObject;

            if (_model.CommittedState.BlueHome == _model.CommittedState.RedHome)
            {
                _model.CommittedState.RedHome = Board.Location.Undefined;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void btnBlockadeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;
            _model.CommittedState[_model.SelectionObject] = Cell.Blockade;
            RedrawBoard();
            UpdateEditor();
        }

        private void btnRedPieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if (_model.CommittedState[_model.SelectionObject] == Cell.Empty || _model.CommittedState[_model.SelectionObject] == Cell.Blockade)
            {
                _model.CommittedState[_model.SelectionObject] = Cell.SideRed | Cell.Size1;
            }
            else
            {
                _model.CommittedState[_model.SelectionObject] |= Cell.SideRed;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void btnBluePieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if (_model.CommittedState[_model.SelectionObject] == Cell.Empty || _model.CommittedState[_model.SelectionObject] == Cell.Blockade)
            {
                _model.CommittedState[_model.SelectionObject] = Cell.Size1;
            }
            else
            {
                _model.CommittedState[_model.SelectionObject] &= ~Cell.SideRed;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void nudStackSize_ValueChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if ((_model.CommittedState[_model.SelectionObject] & Cell.SizeMask) == 0) return;
            var newSize = Convert.ToInt32(nudStackSize.Value);
            if (newSize < 1 || newSize > 15) return;
            _model.CommittedState[_model.SelectionObject] = (_model.CommittedState[_model.SelectionObject] & ~Cell.SizeMask) | (Cell) newSize;

            RedrawBoard();
            UpdateEditor();
        }

        private void chkKing_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if ((_model.CommittedState[_model.SelectionObject] & Cell.SizeMask) == 0) return;

            if (chkKing.Checked)
            {
                _model.CommittedState[_model.SelectionObject] |= Cell.King;
            }
            else
            {
                _model.CommittedState[_model.SelectionObject] &= ~Cell.King;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void chkBlessed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if ((_model.CommittedState[_model.SelectionObject] & Cell.SizeMask) == 0) return;

            if (chkBlessed.Checked)
            {
                _model.CommittedState[_model.SelectionObject] |= Cell.Blessed;
            }
            else
            {
                _model.CommittedState[_model.SelectionObject] &= ~Cell.Blessed;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void chkCursed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_model.SelectionObject)) return;

            if ((_model.CommittedState[_model.SelectionObject] & Cell.SizeMask) == 0) return;

            if (chkCursed.Checked)
            {
                _model.CommittedState[_model.SelectionObject] |= Cell.Cursed;
            }
            else
            {
                _model.CommittedState[_model.SelectionObject] &= ~Cell.Cursed;
            }

            RedrawBoard();
            UpdateEditor();
        }

        private void btnBoardImageToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(BoardPainter.DrawBoard(_model.CommittedState, Board.Location.Undefined,
                Board.Location.Undefined, null, false, Point.Empty));
        }

        private void UpdateFlag(bool value, StateFlags flagMask)
        {
            if (value)
            {
                _model.CommittedState.Flags |= flagMask;
            }
            else
            {
                _model.CommittedState.Flags &= ~flagMask;
            }

            RedrawBoard();
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

        private void dgvGameState_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearMove_Click(object sender, EventArgs e)
        {
            _controller.ClearMove();
        }

        private void btnCommitMove_Click(object sender, EventArgs e)
        {
            _controller.CommitMove();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs{EventType = NavigationEventType.NewGame, Selected = new State()});
            btnCommitMove.Select();
        }
    }
}