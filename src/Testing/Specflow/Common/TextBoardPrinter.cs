using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
using Benediction.Board;
using Benediction.View;
using Testing.Specflow.Properties;

namespace Testing.Specflow.Common
{
    public static class TextBoardPrinter
    {
        public static string PrintDifferencesFrom(this State finalState, State initialState)
        {
            int minRow = 16, maxRow = 0, minColumn = 8, maxColumn = 0; //reversed
            foreach (var loc in State.AllBoardLocations)
            {
                if (finalState[loc] != initialState[loc])
                {
                    var col = (int) loc & 0x0F;
                    var row = ((int) loc & 0x1F0) >> 4;
                    minRow = Math.Min(minRow, row);
                    maxRow = Math.Max(maxRow, row);
                    minColumn = Math.Min(minColumn, col);
                    maxColumn = Math.Max(maxColumn, col);
                }
            }

            return finalState.Print(minRow, maxRow, minColumn, maxColumn);
        }

        public static string Print(this State state) => Print(state, 0, 16, 0, 8);
        public static string Print(this State state, int minRow, int maxRow, int minColumn, int maxColumn)
        {
            var maxLen = State.AllBoardLocations.Max(loc =>
                Math.Max(PrintPiece(state[loc]).Length, PrintFlags(state[loc]).Length));
            maxLen += (maxLen % 2); //round up to next even number

            var sb = new StringBuilder();
            var id = state.BoardId;
            WriteBoardImage(id, state);
            sb.AppendLine(
                $"![Board ID {id}](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/{id}.png?raw=true)");

            for (var row = minRow; row <= maxRow; row++)
            {
                for (var col = minColumn; col <= maxColumn; col++)
                {
                    var loc = (Location) (row * 16 + col);
                    if (Movement.IsValidLocation(loc))
                    {
                        sb.Append(loc.ToString().ToLower()[0]);
                        sb.Append("[");
                        sb.Append(PrintPiece(state[loc]).Center(maxLen));
                        sb.Append("] ");
                    }
                    else
                    {
                        sb.Append(new string(' ', maxLen + 3));
                    }
                }

                sb.AppendLine();
                for (var col = minColumn; col <= maxColumn; col++)
                {
                    var loc = (Location) (row * 16 + col);
                    if (Movement.IsValidLocation(loc))
                    {
                        sb.Append(loc.ToString()[1]);
                        sb.Append("[");
                        sb.Append(PrintFlags(state[loc]).Center(maxLen));
                        sb.Append("] ");
                    }
                    else
                    {
                        sb.Append(new string(' ', maxLen + 3));
                    }
                }

                sb.AppendLine();

            }

            return sb.ToString();
        }
        private static void WriteBoardImage(Guid id, State state)
        {
            var targetFile = Path.Combine(Resources.ImagePath, $"{id}.png");
            if (File.Exists(targetFile)) return;

            var boardImage =
                BoardPainter.DrawBoard(state, Location.Undefined, Location.Undefined, null, false, Point.Empty);
            boardImage.Save(targetFile, ImageFormat.Png);
        }

        public static string PrintPiece(Cell cell)
        {
            if (cell.IsEmpty()) return string.Empty;
            if (cell.IsBlock()) return "XX";
            if (cell.RedPiece())
            {
                if (cell.IsStack()) return $"R{cell.GetSize()}";
                return "R";
            }
            if (cell.BluePiece())
            {
                if (cell.IsStack()) return $"B{cell.GetSize()}";
                return "B";
            }
            return "?";
        }

        public static string PrintFlags(Cell cell)
        {
            if (cell.IsEmpty()) return string.Empty;
            if (cell.IsBlock()) return "XX";
            if (cell.IsKing())
            {
                if (cell.IsBlessed()) return "BK";
                return "K";
            }

            if (cell.IsBlessed()) return "B";
            if (cell.IsCursed()) return "C";
            if (cell.IsCursePending()) return "c";
            return string.Empty;
        }

        public static string Center(this string str, int len)
        {
            if (string.IsNullOrWhiteSpace(str)) return new string(' ', len);
            if (str.Length > len) return str;
            var gap = len - str.Length;
            return str.PadRight(str.Length + gap / 2).PadLeft(str.Length + gap);
        }
    }
}
