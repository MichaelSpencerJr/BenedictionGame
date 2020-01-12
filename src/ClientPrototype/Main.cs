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
using Exception = System.Exception;

namespace Benediction
{
    public partial class Main : Form
    {
        private BoardState _board = new BoardState();
        private BoardLocation _selection = BoardLocation.Undefined;

        public Main()
        {
            InitializeComponent();
        }

        private void pbBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(sender is PictureBox pbClicked)) return;
            if (pbClicked != pbBoard) return;

            var boardCoordinates = GetBoardCoordinates(e.X, e.Y);
            var location = BoardPainter.GetBoardLocation(boardCoordinates);

            if (Movement.IsValidLocation(location))
            {
                _selection = location;
            }
            else
            {
                _selection = BoardLocation.Undefined;
            }

            DrawBoard();
            UpdateEditor();
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
            DrawBoard();
            UpdateEditor();
        }

        private void DrawBoard()
        {
            pbBoard.Image = BoardPainter.DrawBoard(_board, _selection);
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
            if (selectedPiece == BoardCell.Empty)
            {
                SetEnableState(true, false, isNotRedHome, isNotBlueHome, true, true, true);
                return;
            }

            if (selectedPiece == BoardCell.Blockade)
            {
                SetEnableState(true, true, isNotRedHome, isNotBlueHome, true, true, true);
                return;
            }

            var size = (int)(selectedPiece & BoardCell.SizeMask);
            var isRed = (selectedPiece & BoardCell.SideRed) > 0;
            var isKing = (selectedPiece & BoardCell.King) > 0;
            var isBlessed = (selectedPiece & BoardCell.Blessed) > 0;
            var isCursed = (selectedPiece & BoardCell.Cursed) > 0;
            SetEnableState(true, true, isNotRedHome, isNotBlueHome, true, !isRed, isRed, true, true, true, true, size,
                isKing, isBlessed, isCursed);
        }

        private void btnClearBoard_Click(object sender, EventArgs e)
        {
            _board = new BoardState();
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
                _board = BoardState.FromBase64Gz(txtBoardData.Text);
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
            _selection = BoardLocation.Undefined;
            DrawBoard();
            UpdateEditor();
        }

        private void btnClearEmptyCell_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board[_selection] = BoardCell.Empty;
            DrawBoard();
            UpdateEditor();
        }

        private void btnRedHomeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board.RedHome = _selection;

            if (_board.BlueHome == _board.RedHome)
            {
                _board.BlueHome = BoardLocation.Undefined;
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
                _board.RedHome = BoardLocation.Undefined;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBlockadeHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;
            _board[_selection] = BoardCell.Blockade;
            DrawBoard();
            UpdateEditor();
        }

        private void btnRedPieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if (_board[_selection] == BoardCell.Empty || _board[_selection] == BoardCell.Blockade)
            {
                _board[_selection] = BoardCell.SideRed | BoardCell.Size1;
            }
            else
            {
                _board[_selection] |= BoardCell.SideRed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void btnBluePieceHere_Click(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if (_board[_selection] == BoardCell.Empty || _board[_selection] == BoardCell.Blockade)
            {
                _board[_selection] = BoardCell.Size1;
            }
            else
            {
                _board[_selection] &= ~BoardCell.SideRed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void nudStackSize_ValueChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & BoardCell.SizeMask) == 0) return;
            var newSize = Convert.ToInt32(nudStackSize.Value);
            if (newSize < 1 || newSize > 15) return;
            _board[_selection] = (_board[_selection] & ~BoardCell.SizeMask) | (BoardCell) newSize;

            DrawBoard();
            UpdateEditor();
        }

        private void chkKing_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & BoardCell.SizeMask) == 0) return;

            if (chkKing.Checked)
            {
                _board[_selection] |= BoardCell.King;
            }
            else
            {
                _board[_selection] &= ~BoardCell.King;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void chkBlessed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & BoardCell.SizeMask) == 0) return;

            if (chkBlessed.Checked)
            {
                _board[_selection] |= BoardCell.Blessed;
            }
            else
            {
                _board[_selection] &= ~BoardCell.Blessed;
            }

            DrawBoard();
            UpdateEditor();
        }

        private void chkCursed_CheckedChanged(object sender, EventArgs e)
        {
            if (!Movement.IsValidLocation(_selection)) return;

            if ((_board[_selection] & BoardCell.SizeMask) == 0) return;

            if (chkCursed.Checked)
            {
                _board[_selection] |= BoardCell.Cursed;
            }
            else
            {
                _board[_selection] &= ~BoardCell.Cursed;
            }

            DrawBoard();
            UpdateEditor();
        }
    }
}
