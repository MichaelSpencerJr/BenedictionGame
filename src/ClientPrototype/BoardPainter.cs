using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Benediction.Properties.Resources;

namespace Benediction
{
    public class BoardPainter
    {
        public static readonly int BoardWidth = BenedictionBoard.Width;
        public static readonly int BoardHeight = BenedictionBoard.Height;

        //pixel offsets from provided board image
        public const int BoardRow0 = 25;
        public const int BoardRow16 = 518;
        public const int BoardRowHighIndex = 16;
        public const int BoardColumn0 = 133;
        public const int BoardColumn8 = 565;
        public const int BoardColumnHighIndex = 8;

        //computed values for pixel manipulation
        public const int BoardRowRange = BoardRow16 - BoardRow0;
        public const int BoardHalfRowRoundingOffset = BoardRowRange / BoardRowHighIndex / 2;
        public const int BoardColumnRange = BoardColumn8 - BoardColumn0;
        public const int BoardHalfColumnRoundingOffset = BoardColumnRange / BoardColumnHighIndex / 2;

        /// <summary>
        /// Draws the provided game board data and cell selection onto an Image
        /// </summary>
        /// <param name="state">Game board state, indicating what is present in each cell, where the two homes are, and the current game state flags</param>
        /// <param name="selection">Board location currently selected by the user, if any</param>
        /// <returns>Image representing game board data and selection</returns>
        public static Image DrawBoard(BoardState state, BoardLocation selection = BoardLocation.Undefined)
        {
            var retval = new Bitmap(BoardWidth, BoardHeight);

            using (var canvas = Graphics.FromImage(retval))
            {
                canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //First draw board
                canvas.DrawImage(BenedictionBoard, new Rectangle(0, 0, BoardWidth, BoardHeight),
                    new Rectangle(0, 0, BoardWidth, BoardHeight), GraphicsUnit.Pixel);

                //Draw red and blue homes, if defined.  These will be covered up by pieces if present.
                if (Movement.IsValidLocation(state.RedHome))
                {
                    DrawAt(canvas, StartingPoint, GetLocationCoordinate(state.RedHome));
                }

                if (Movement.IsValidLocation(state.BlueHome))
                {
                    DrawAt(canvas, StartingPoint, GetLocationCoordinate(state.BlueHome));
                }

                //Draw stacks of pieces in vertical layers: all bottom pieces first, then all second pieces, etc.
                for (var layer = 0; layer < 4; layer++)
                {
                    //If the current layer didn't have any pieces, higher layers won't either -- so stop rendering.
                    var layerEmpty = true;

                    //Draw any pieces on the board
                    foreach (var location in BoardState.AllBoardLocations)
                    {
                        if (state[location] == BoardCell.Empty) continue; //nothing to draw

                        if (state[location] == BoardCell.Blockade && layer == 0)
                        {
                            //Draw a blockade and continue to next piece
                            DrawAt(canvas, Blockade, GetLocationCoordinate(location));
                            continue;
                        }

                        //Read piece data from flags
                        var piece = state[location];
                        var pieceColor = piece & BoardCell.SideRed;
                        var stackSize = (int) (piece & BoardCell.SizeMask);
                        var king = piece & BoardCell.King;
                        var bless = piece & BoardCell.Blessed;
                        var curse = piece & BoardCell.Cursed;

                        var topPieceCoordinate = GetLocationCoordinate(location, layer);
                        if (stackSize > layer)
                        {
                            DrawAt(canvas, pieceColor == BoardCell.SideRed ? Red_Man : Blue_Man, topPieceCoordinate);
                            layerEmpty = false;
                            if (layer == 3 || stackSize == layer + 1)
                            {
                                if (king > 0)
                                {
                                    DrawAt(canvas, King, topPieceCoordinate);
                                }

                                if (bless > 0)
                                {
                                    DrawAt(canvas, Blessing, topPieceCoordinate);
                                }

                                if (curse > 0)
                                {
                                    DrawAt(canvas, Curse, topPieceCoordinate);
                                }

                                if (stackSize > 4)
                                {
                                    DrawText(canvas, stackSize.ToString(), Color.Black, topPieceCoordinate);
                                }
                            }
                        }

                    }

                    if (layerEmpty) break;
                }

                if (Movement.IsValidLocation(selection))
                {
                    DrawAt(canvas, Select, GetLocationCoordinate(selection));
                }

                canvas.Save();
            }

            return retval;
        }

        private static Font _sansFont = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

        private static void DrawText(Graphics canvas, string text, Color color, Point center)
        {
            var textSize = canvas.MeasureString(text, _sansFont, PointF.Empty, StringFormat.GenericDefault);
            var textWidth = Convert.ToInt32(textSize.Width + 0.9F);
            var textHeight = Convert.ToInt32(textSize.Height + 0.9F);

            var targetRect = new Rectangle(center.X - textWidth / 2,
                center.Y - textHeight / 2,
                textWidth,
                textHeight);

            //draw background rectangle, so text shows up clearly against dark colors
            canvas.FillRectangle(new SolidBrush(Color.White), targetRect);

            //draw text
            canvas.DrawString(text, _sansFont, new SolidBrush(color), targetRect, StringFormat.GenericDefault);
        }

        private static void DrawAt(Graphics canvas, Bitmap image, Point center)
        {
            var targetRect = new Rectangle(center.X - image.Width / 2,
                center.Y - image.Height / 2,
                image.Width,
                image.Height);
            canvas.DrawImage(image, targetRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }

        private static Point GetLocationCoordinate(BoardLocation location, int offsets = 0)
        {
            var column = (ushort) location & 0x0F;
            var row = ((ushort) location & 0x1F0) >> 4;
            var x = column * BoardColumnRange / BoardColumnHighIndex + BoardColumn0 + offsets * 4;
            var y = row * BoardRowRange / BoardRowHighIndex + BoardRow0 - offsets * 4;
            return new Point(x, y);
        }

        public static BoardLocation GetBoardLocation(Point input)
        {
            var boardRow = (input.Y - BoardRow0 + BoardHalfRowRoundingOffset) * BoardRowHighIndex / BoardRowRange;
            var boardColumn = (input.X - BoardColumn0 + BoardHalfColumnRoundingOffset) * BoardColumnHighIndex / BoardColumnRange;

            if (boardRow < 0 || boardRow > 16) return BoardLocation.Undefined;
            if (boardColumn < 0 || boardColumn > 8) return BoardLocation.Undefined;

            //Row and column should be both even (value mod 2 == 0) or be both odd (value mod 2 == 1)
            //Otherwise you've selected the empty space between two areas.
            if (boardColumn % 2 != boardRow % 2) return BoardLocation.Undefined;

            return (BoardLocation)(boardRow * 16 + boardColumn);
        }
    }
}
