using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using Benediction.Actions;
using Benediction.Board;
using Benediction.Properties;

namespace Benediction.View
{
    public static class BoardPainter
    {
        public static readonly int BoardWidth = Resources.BenedictionBoard.Width;
        public static readonly int BoardHeight = Resources.BenedictionBoard.Height;

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
        /// Draws the provided game board data and cell location onto an Image
        /// </summary>
        /// <param name="state">Game board state, indicating what is present in each cell, where the two homes are, and the current game state flags</param>
        /// <param name="location">Board location selected by the user for the current move (or move start point)</param>
        /// <param name="target">Board location selected by the user as the destination for the current move</param>
        /// <param name="sideRed"></param>
        /// <param name="cursorLocation">Board-image-space coordinates of the mouse cursor, for indicating dragged pieces</param>
        /// <param name="cursorContents">Flags for drawing piece carried by the mouse cursor, if any</param>
        /// <param name="highlights"></param>
        /// <returns>Image representing game board data and location</returns>
        public static Image DrawBoard(State state, Location location, Location target, IEnumerable<Location> highlights, bool sideRed, Point cursorLocation, Cell cursorContents = Cell.Empty)
        {
            var retval = new Bitmap(BoardWidth, BoardHeight);

            using (var canvas = Graphics.FromImage(retval))
            {
                canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //First draw board
                canvas.DrawImage(Resources.BenedictionBoard, new Rectangle(0, 0, BoardWidth, BoardHeight),
                    new Rectangle(0, 0, BoardWidth, BoardHeight), GraphicsUnit.Pixel);

                DrawGameFlags(state, canvas);

                DrawPlayerHomes(state, canvas);

                //Draw stacks of pieces in vertical layers: all bottom pieces first, then all second pieces, etc.
                for (var layer = 0; layer < 4; layer++)
                {
                    //If the current layer didn't have any pieces, higher layers won't either -- so stop rendering.
                    var layerEmpty = true;

                    //Draw any pieces on the board
                    foreach (var boardLocation in state.AllBoardLocations)
                    {
                        if (state[boardLocation].IsEmpty()) continue; //nothing to draw

                        if (state[boardLocation].IsBlock() && layer == 0)
                        {
                            //Draw a blockade and continue to next piece
                            DrawAt(canvas, Resources.Blockade, GetLocationCoordinate(boardLocation));
                            continue;
                        }

                        var stillEmpty = DrawPieceLayer(state, boardLocation, layer, canvas);
                        if (!stillEmpty)
                        {
                            if (boardLocation == location || boardLocation == target)
                            {
                                DrawAt(canvas, Resources.Select, GetLocationCoordinate(boardLocation, layer));
                            }
                        }
                        layerEmpty &= stillEmpty;
                    }

                    if (!cursorContents.IsEmpty())
                    {
                        layerEmpty &= DrawPieceLayerAtPoint(cursorContents, layer, cursorLocation, canvas);
                    }

                    if (layerEmpty) break;
                }

                if (Movement.IsValidLocation(location) && !state[location].IsPiece())
                {
                    DrawAt(canvas, Resources.Select, GetLocationCoordinate(location));
                }

                if (Movement.IsValidLocation(target) && !state[target].IsPiece())
                {
                    DrawAt(canvas, Resources.Select, GetLocationCoordinate(target));
                }

                if (highlights != null)
                {
                    foreach (var highlightLocation in highlights)
                    {
                        if (Movement.IsValidLocation(highlightLocation))
                        {
                            DrawAt(canvas, sideRed ? Resources.Red_Possible : Resources.Blue_Possible,
                                GetLocationCoordinate(highlightLocation));
                        }
                    }
                }

                canvas.Save();
            }

            return retval;
        }

        private static void DrawGameFlags(State state, Graphics canvas)
        {
//Draw game flags in text at the corners
            if (state.Flags.HasFlag(StateFlags.RedAction1))
            {
                DrawBannerText(canvas, "Ready For Red Move #1", Color.OrangeRed, true, true);
            }
            else if (state.Flags.HasFlag(StateFlags.RedAction2))
            {
                DrawBannerText(canvas, "Ready For Red Move #2", Color.OrangeRed, true, true);
            }

            if (state.Flags.HasFlag(StateFlags.BlueAction1))
            {
                DrawBannerText(canvas, "Ready For Blue Move #1", Color.DodgerBlue, true, false);
            }
            else if (state.Flags.HasFlag(StateFlags.BlueAction2))
            {
                DrawBannerText(canvas, "Ready For Blue Move #2", Color.DodgerBlue, true, false);
            }

            if (state.Flags.HasFlag(StateFlags.RedKingTaken))
            {
                DrawBannerText(canvas, "Red King Has Been Taken", Color.OrangeRed, false, true);
            }
            else if (state.Flags.HasFlag(StateFlags.RedWin))
            {
                DrawBannerText(canvas, "Red Wins", Color.OrangeRed, false, true);
            }

            if (state.Flags.HasFlag(StateFlags.BlueKingTaken))
            {
                DrawBannerText(canvas, "Blue King Has Been Taken", Color.DodgerBlue, false, false);
            }
            else if (state.Flags.HasFlag(StateFlags.BlueWin))
            {
                DrawBannerText(canvas, "Blue Wins", Color.DodgerBlue, false, false);
            }
        }

        private static void DrawPlayerHomes(State state, Graphics canvas)
        {
//Draw red and blue homes, if defined.  These will be covered up by pieces if present.
            if (Movement.IsValidLocation(state.RedHome))
            {
                DrawAt(canvas, Resources.StartingPoint, GetLocationCoordinate(state.RedHome));
            }

            if (Movement.IsValidLocation(state.BlueHome))
            {
                DrawAt(canvas, Resources.StartingPoint, GetLocationCoordinate(state.BlueHome));
            }
        }

        private static bool DrawPieceLayer(State state, Location location, int layer, Graphics canvas)
        {
            return DrawPieceLayerAtPoint(state[location], layer, GetLocationCoordinate(location, layer), canvas);
        }

        private static bool DrawPieceLayerAtPoint(Cell piece, int layer, Point point, Graphics canvas)
        {
            var layerEmpty = true;
            if (piece.GetSize() > layer)
            {
                var drawPiece = piece.GetSide(Resources.Red_Man, Resources.Blue_Man, null);
                if (drawPiece != null) DrawAt(canvas, drawPiece, point);
                layerEmpty = false;
                if (layer == 3 || piece.GetSize() == layer + 1)
                {
                    DrawTopPieceLayer(piece, canvas, point);
                }
            }

            return layerEmpty;
        }

        private static void DrawTopPieceLayer(Cell piece, Graphics canvas, Point topPieceCoordinate)
        {
            if (piece.IsKing())
            {
                DrawAt(canvas, Resources.King, topPieceCoordinate);
            }

            if (piece.IsBlessed())
            {
                DrawAt(canvas, Resources.Blessing, topPieceCoordinate);
            }

            if (piece.IsCursed())
            {
                DrawAt(canvas, Resources.Curse, topPieceCoordinate);
            }

            if (piece.GetSize() > 4)
            {
                DrawText(canvas, piece.GetSize().ToString(), Color.Black, topPieceCoordinate);
            }
        }

        private static Font _sansFont = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

        private static Font _bannerFont = new Font(FontFamily.GenericSerif, 20.0F, FontStyle.Bold);

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

        private static void DrawBannerText(Graphics canvas, string text, Color color, bool isTop, bool isLeft)
        {
            //left: 10-245 horizontal, right: 475-710
            //top: 10-50 vertical, bottom 490-530

            var targetRect = new Rectangle(isLeft ? 10 : 475, isTop ? 10 : 470, 235, 60);

            //draw text
            canvas.DrawString(text, _bannerFont, new SolidBrush(color), targetRect,
                new StringFormat
                {
                    Alignment = isLeft ? StringAlignment.Near : StringAlignment.Far, 
                    LineAlignment = isTop ? StringAlignment.Near : StringAlignment.Far,
                    Trimming = StringTrimming.EllipsisWord
                });
        }

        private static void DrawAt(Graphics canvas, Bitmap image, Point center)
        {
            var targetRect = new Rectangle(center.X - image.Width / 2,
                center.Y - image.Height / 2,
                image.Width,
                image.Height);
            canvas.DrawImage(image, targetRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }

        private static Point GetLocationCoordinate(Location location, int offsets = 0)
        {
            var column = (ushort) location & 0x0F;
            var row = ((ushort) location & 0x1F0) >> 4;
            var x = column * BoardColumnRange / BoardColumnHighIndex + BoardColumn0 + offsets * 4;
            var y = row * BoardRowRange / BoardRowHighIndex + BoardRow0 - offsets * 4;
            return new Point(x, y);
        }

        public static Location GetBoardLocation(Point input)
        {
            var boardRow = (input.Y - BoardRow0 + BoardHalfRowRoundingOffset) * BoardRowHighIndex / BoardRowRange;
            var boardColumn = (input.X - BoardColumn0 + BoardHalfColumnRoundingOffset) * BoardColumnHighIndex / BoardColumnRange;

            if (boardRow < 0 || boardRow > 16) return Location.Undefined;
            if (boardColumn < 0 || boardColumn > 8) return Location.Undefined;

            //Row and column should be both even (value mod 2 == 0) or be both odd (value mod 2 == 1)
            //Otherwise you've selected the empty space between two areas.
            if (boardColumn % 2 != boardRow % 2) return Location.Undefined;

            return (Location)(boardRow * 16 + boardColumn);
        }
    }
}
