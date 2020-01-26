using System;
using System.Collections.Generic;
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
        }

        private void GamePlayerView_Load(object sender, EventArgs e)
        {
            RedrawBoard();
            UpdateGameMoveGrid();
            BoardEditorUpdate();
        }

        private void UpdateMouse(MouseEventArgs e)
        {
            _lastMouse = GetBoardCoordinates(e.X, e.Y);
        }

        public void RedrawBoard()
        {
            if (_model.EditMode)
            {
                pbBoard.Image = BoardPainter.DrawBoard(_model.EditorState, _model.SelectionObject,
                    Board.Location.Undefined, _model.HighlightLocations, true, Point.Empty);
            }
            else
            {
                var redSide = _model.CommittedState.Flags.IsRedTurn();
                switch (_model.SelectionState)
                {
                    case SelectionState.Unselected:
                        pbBoard.Image = BoardPainter.DrawBoard(_model.CommittedState, Board.Location.Undefined,
                            Board.Location.Undefined, _model.HighlightLocations, redSide, Point.Empty);
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
            }

            foreach (var enableBox in new[]
                {chkRedT1, chkRedT2, chkBlueT1, chkBlueT2, chkRedKingTaken, chkBlueKingTaken, chkRedWin, chkBlueWin})
                enableBox.Enabled = _model.EditMode;

            chkRedT1.Checked = _model.EditorState.Flags.HasFlag(StateFlags.RedAction1);
            chkRedT2.Checked = _model.EditorState.Flags.HasFlag(StateFlags.RedAction2);
            chkBlueT1.Checked = _model.EditorState.Flags.HasFlag(StateFlags.BlueAction1);
            chkBlueT2.Checked = _model.EditorState.Flags.HasFlag(StateFlags.BlueAction2);
            chkRedKingTaken.Checked = _model.EditorState.Flags.HasFlag(StateFlags.RedKingTaken);
            chkBlueKingTaken.Checked = _model.EditorState.Flags.HasFlag(StateFlags.BlueKingTaken);
            chkRedWin.Checked = _model.EditorState.Flags.HasFlag(StateFlags.RedWin);
            chkBlueWin.Checked = _model.EditorState.Flags.HasFlag(StateFlags.BlueWin);
        }

        public void UpdateGameMoveGrid()
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

                    var selectedRowState = _model.Game[i];
                    if (selectedRowState is GameTurn gt)
                    {
                        if (gt[j] is PlayerAction pa)
                        {
                            dgvGameState.Rows[i].Cells[j + 1].Tag = pa.PostActionState;
                        }
                        else
                        {
                            dgvGameState.Rows[i].Cells[j + 1].Tag = null;
                        }
                    }
                    else
                    {
                        dgvGameState.Rows[i].Cells[j + 1].Tag = selectedRowState?.NewState;
                    }
                }
            }
            CpuGridUpdate();
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

        private static Random rng = new Random();
        private void btnCpuRandomMove_Click(object sender, EventArgs e)
        {
            if (lstAvailableMoves.Items.Count == 0) return;
            lstAvailableMoves.SelectedIndex = rng.Next(lstAvailableMoves.Items.Count);
        }

        private void lstAvailableMoves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstAvailableMoves.SelectedItem is ProposedState ps)) return;
            if (!(ps.Action is GameAction ga)) return;
            NavigateEvent?.Invoke(sender, new BoardNavigationEventArgs{EventType = NavigationEventType.ClearMove});
            if (ga is GameTargetAction gta)
            {
                InputEvent?.Invoke(sender, new BoardLocationEventArgs{Location = ga.Location, MouseEvent = BoardMouseEventType.LeftDragStart});
                InputEvent?.Invoke(sender, new BoardLocationEventArgs{Location = gta.Target, MouseEvent = BoardMouseEventType.LeftDragEnd});
            }
            else
            {
                InputEvent?.Invoke(sender, new BoardLocationEventArgs{Location = ga.Location, MouseEvent = BoardMouseEventType.LeftClick});
            }

            _model.SelectedVariation = ga.Size;
            RedrawBoard();
            UpdateGameMoveGrid();
            BoardEditorUpdate();
        }

        private void SetBoardEditorControlEnableState(bool unselect = false, bool clearEmpty = false, bool redHome = false,
            bool blueHome = false, bool blockade = false, bool redPiece = false, bool bluePiece = false,
            bool? king = null, bool? blessed = null, bool? cursed = null, int? stackSize = null,
            bool? locked = null, bool? cursePending = null)
        {
            btnUnselectCell.Enabled = unselect;
            btnClearEmptyCell.Enabled = clearEmpty;
            btnRedHomeHere.Enabled = redHome;
            btnBlueHomeHere.Enabled = blueHome;
            btnBlockadeHere.Enabled = blockade;
            btnRedPieceHere.Enabled = redPiece;
            btnBluePieceHere.Enabled = bluePiece;
            nudStackSize.Enabled = stackSize.HasValue;
            nudStackSize.Value = stackSize ?? 1;
            chkKing.Enabled = king.HasValue;
            chkKing.Checked = king ?? false;
            chkBlessed.Enabled = blessed.HasValue;
            chkBlessed.Checked = blessed ?? false;
            chkCursed.Enabled = cursed.HasValue;
            chkCursed.Checked = cursed ?? false;
            chkLocked.Enabled = locked.HasValue;
            chkLocked.Checked = locked ?? false;
            chkCursePending.Enabled = cursePending.HasValue;
            chkCursePending.Checked = cursePending ?? false;
        }

        public void BoardEditorUpdate()
        {
            btnClearBoard.Enabled = _model.EditMode;
            btnImportBoard.Enabled = _model.EditMode;
            btnSaveEdits.Enabled = _model.EditMode;

            if (!Movement.IsValidLocation(_model.SelectionObject) || !_model.EditMode)
            {
                SetBoardEditorControlEnableState();
                return;
            }

            var isNotRedHome = _model.SelectionObject != _model.EditorState.RedHome;
            var isNotBlueHome = _model.SelectionObject != _model.EditorState.BlueHome;

            var cell = _model.EditorState[_model.SelectionObject];
            if (!cell.IsPiece())
            {
                SetBoardEditorControlEnableState(true, cell.IsBlock(), isNotRedHome, isNotBlueHome, true, true, true);
            }
            else
            {
                SetBoardEditorControlEnableState(true, true, isNotRedHome, isNotBlueHome, true, cell.BluePiece(),
                    cell.RedPiece(), cell.IsKing(), cell.IsBlessed(), cell.IsCursed(), cell.GetSize(), cell.IsLocked(),
                    cell.IsCursePending());
            }
        }

        public void CpuGridUpdate()
        {
            lstAvailableMoves.Items.Clear();
            if (_model.AvailableActions == null) return;

            foreach (var move in _model.AvailableActions)
            {
                lstAvailableMoves.Items.Add(move.Value);
            }
        }
    }
}