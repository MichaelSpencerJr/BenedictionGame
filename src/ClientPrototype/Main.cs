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
            }
            else
            {
                _selection = Board.Location.Undefined;
            }

            DrawBoard();
            UpdateEditor();
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
    }
}
