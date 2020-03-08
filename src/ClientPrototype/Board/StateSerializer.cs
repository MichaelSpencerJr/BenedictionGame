using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board
{
    public static class StateSerializer
    {
        public const string BenedictionV1Header = "Benediction v1";
        public const string RedV1Header = ": R";
        public const string BlueV1Header = " B";
        public const char SideV1Move1 = '-';
        public const char SideV1Move2 = '=';
        public const char SideV1KingTaken = 'x';
        public const char SideV1Win = 'W';

        public static string ToString(State state)
        {
            var sb = new StringBuilder();

            char redFlag, blueFlag;
            if ((state.Flags & StateFlags.RedAction1) == StateFlags.RedAction1) redFlag = SideV1Move1;
            else if ((state.Flags & StateFlags.RedAction2) == StateFlags.RedAction2) redFlag = SideV1Move2;
            else if ((state.Flags & StateFlags.RedKingTaken) == StateFlags.RedKingTaken) redFlag = SideV1KingTaken;
            else if ((state.Flags & StateFlags.RedWin) == StateFlags.RedWin) redFlag = SideV1Win;
            else redFlag = ' ';
            if ((state.Flags & StateFlags.BlueAction1) == StateFlags.BlueAction1) blueFlag = SideV1Move1;
            else if ((state.Flags & StateFlags.BlueAction2) == StateFlags.BlueAction2) blueFlag = SideV1Move2;
            else if ((state.Flags & StateFlags.BlueKingTaken) == StateFlags.BlueKingTaken) blueFlag = SideV1KingTaken;
            else if ((state.Flags & StateFlags.BlueWin) == StateFlags.BlueWin) blueFlag = SideV1Win;
            else blueFlag = ' ';

            sb.Append("| ").Append(BenedictionV1Header).Append(RedV1Header).Append(redFlag).Append(state.RedHome)
                .Append(BlueV1Header)
                .Append(blueFlag).Append(state.BlueHome).Append(" |").AppendLine();

            sb.Append("| R:");
            foreach (var column in "ABCDEFGHI")
            {
                AddRow(state, Cell.SideRed, column, sb);
            }

            sb.Append(" |").AppendLine();
            sb.Append("| B:");
            foreach (var column in "ABCDEFGHI")
            {
                AddRow(state, Cell.Empty, column, sb);
            }

            sb.Append(" |");
            if (state.Any(kvp => kvp.Value == Cell.Block))
            {

                sb.AppendLine();
                sb.Append("| X:");
                foreach (var column in "ABCDEFGHI")
                {
                    AddRow(state, Cell.Block, column, sb);
                }

                sb.Append(" |");
            }

            return sb.ToString();
        }

        public static void AddRow(State state, Cell side, char column, StringBuilder output)
        {
            var rowPresent = false;
            foreach (var columnPiece in GetColumn(column))
            {
                if (state[columnPiece] != Cell.Empty && (state[columnPiece] & (Cell.SideRed | Cell.Block)) == side)
                {
                    if (!rowPresent)
                    {
                        output.Append(column);
                        rowPresent = true;
                    }

                    output.Append(columnPiece.ToString().Substring(1));
                    if ((state[columnPiece] & Cell.King) == Cell.King) output.Append('k');
                    if ((state[columnPiece] & Cell.Blessed) == Cell.Blessed) output.Append('b');
                    if ((state[columnPiece] & Cell.Cursed) == Cell.Cursed) output.Append('c');
                    for (var i = Cell.Size2; i <= Cell.SizeMask; i += 1)
                    {
                        if ((state[columnPiece] & Cell.SizeMask) >= i)
                        {
                            output.Append('+');
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private static IEnumerable<Location> GetColumn(char column)
        {
            switch (column)
            {
                case 'A':
                    yield return Location.A1;
                    yield return Location.A2;
                    yield return Location.A3;
                    yield return Location.A4;
                    yield return Location.A5;
                    yield break;
                case 'B':
                    yield return Location.B1;
                    yield return Location.B2;
                    yield return Location.B3;
                    yield return Location.B4;
                    yield return Location.B5;
                    yield return Location.B6;
                    yield break;
                case 'C':
                    yield return Location.C1;
                    yield return Location.C2;
                    yield return Location.C3;
                    yield return Location.C4;
                    yield return Location.C5;
                    yield return Location.C6;
                    yield return Location.C7;
                    yield break;

                case 'D':
                    yield return Location.D1;
                    yield return Location.D2;
                    yield return Location.D3;
                    yield return Location.D4;
                    yield return Location.D5;
                    yield return Location.D6;
                    yield return Location.D7;
                    yield return Location.D8;
                    yield break;

                case 'E':
                    yield return Location.E1;
                    yield return Location.E2;
                    yield return Location.E3;
                    yield return Location.E4;
                    yield return Location.E5;
                    yield return Location.E6;
                    yield return Location.E7;
                    yield return Location.E8;
                    yield return Location.E9;
                    yield break;

                case 'F':
                    yield return Location.F1;
                    yield return Location.F2;
                    yield return Location.F3;
                    yield return Location.F4;
                    yield return Location.F5;
                    yield return Location.F6;
                    yield return Location.F7;
                    yield return Location.F8;
                    yield break;

                case 'G':
                    yield return Location.G1;
                    yield return Location.G2;
                    yield return Location.G3;
                    yield return Location.G4;
                    yield return Location.G5;
                    yield return Location.G6;
                    yield return Location.G7;
                    yield break;

                case 'H':
                    yield return Location.H1;
                    yield return Location.H2;
                    yield return Location.H3;
                    yield return Location.H4;
                    yield return Location.H5;
                    yield return Location.H6;
                    yield break;
                case 'I':
                    yield return Location.I1;
                    yield return Location.I2;
                    yield return Location.I3;
                    yield return Location.I4;
                    yield return Location.I5;
                    yield break;
            }
        }

        public static State ParseHeaderV1(State state, string line)
        {
            var offset = 0;
            if (!TryConsume(line, ref offset, BenedictionV1Header)) return state;
            if (!TryConsume(line, ref offset, RedV1Header)) return state;

            switch (line[offset++])
            {
                case SideV1Move1:
                    state.Flags |= StateFlags.RedAction1;
                    break;
                case SideV1Move2: 
                    state.Flags |= StateFlags.RedAction2;
                    break;
                case SideV1KingTaken: 
                    state.Flags |= StateFlags.RedKingTaken;
                    break;
                case SideV1Win:
                    state.Flags |= StateFlags.RedWin;
                    break;
            }

            state.RedHome = (Location) Enum.Parse(typeof(Location), line.Substring(offset, 2));
            offset += 2;

            if (!TryConsume(line, ref offset, BlueV1Header)) return state;

            switch (line[offset++])
            {
                case SideV1Move1:
                    state.Flags |= StateFlags.BlueAction1;
                    break;
                case SideV1Move2: 
                    state.Flags |= StateFlags.BlueAction2;
                    break;
                case SideV1KingTaken: 
                    state.Flags |= StateFlags.BlueKingTaken;
                    break;
                case SideV1Win:
                    state.Flags |= StateFlags.BlueWin;
                    break;
            }


            state.BlueHome = (Location) Enum.Parse(typeof(Location), line.Substring(offset, 2));

            return state;
        }

        public static bool TryConsume(string input, ref int offset, string expected)
        {
            if (input == null || expected == null || input.Length < offset) return false;
            if (input.Substring(offset).StartsWith(expected))
            {
                offset += expected.Length;
                return true;
            }

            return false;
        }

        public static State FromString(string description)
        {
            var retval = ApplyString(new State(), description);

            return retval;
        }

        public static State ApplyString(State state, string description)
        {
            var lines = description.Split(new[] {"\r\n", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
            state = ParseHeaderV1(state, LineFilter(lines[0]));
            for (var i = 1; i < lines.Length; i++)
            {
                state = ParseSideV1(state, LineFilter(lines[i]));
            }

            return state;
        }
 
        public static State ParseSideV1(State state, string line)
        {
            Cell side;
            var location = Location.Undefined;
            var column = Location.Undefined;
            if (line.StartsWith("R:"))
            {
                side = Cell.SideRed | Cell.Size1;
            }
            else if (line.StartsWith("B:"))
            {
                side = Cell.Size1;
            }
            else if (line.StartsWith("X:"))
            {
                side = Cell.Block;
            }
            else return state;

            foreach (var c in line.Substring(2))
            {
                switch (c)
                {
                    case 'A':
                        column = Location.A1;
                        break;
                    case 'B':
                        column = Location.B1;
                        break;
                    case 'C':
                        column = Location.C1;
                        break;
                    case 'D':
                        column = Location.D1;
                        break;
                    case 'E':
                        column = Location.E1;
                        break;
                    case 'F':
                        column = Location.F1;
                        break;
                    case 'G':
                        column = Location.G1;
                        break;
                    case 'H':
                        column = Location.H1;
                        break;
                    case 'I':
                        column = Location.I1;
                        break;
                    case '1':
                        location = column;
                        state[location] = side;
                        break;
                    case '2':
                        location = column - 0x20;
                        state[location] = side;
                        break;

                    case '3':
                        location = column - 0x40;
                        state[location] = side;
                        break;

                    case '4':
                        location = column - 0x60;
                        state[location] = side;
                        break;

                    case '5':
                        location = column - 0x80;
                        state[location] = side;
                        break;

                    case '6':
                        location = column - 0xA0;
                        state[location] = side;
                        break;

                    case '7':
                        location = column - 0xC0;
                        state[location] = side;
                        break;

                    case '8':
                        location = column - 0xE0;
                        state[location] = side;
                        break;

                    case '9':
                        location = column - 0x100;
                        state[location] = side;
                        break;
                    case 'k':
                        state[location] |= Cell.King;
                        break;
                    case 'b':
                        state[location] |= Cell.Blessed;
                        break;
                    case 'c':
                        state[location] |= Cell.Cursed;
                        break;
                    case '+':
                        state[location]++;
                        break;

                }
            }

            return state;
        }

        public static string LineFilter(string input)
        {
            return input.Trim(' ', '|', '\t');
        }

        private const int AllBoardLocationsLength = 61;
        public static byte[] GetBytes(State state)
        {
            var retval = new byte[AllBoardLocationsLength * 2 + 5];

            var i = 0;
            foreach (var location in State.AllBoardLocations)
            {
                var bytes = BitConverter.GetBytes(Convert.ToUInt16(state[location]));
                Array.ConstrainedCopy(bytes, 0, retval, i, 2);
                i += 2;
            }

            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) state.RedHome), 0, retval, AllBoardLocationsLength * 2, 2);
            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) state.BlueHome), 0, retval, AllBoardLocationsLength * 2 + 2,
                2);
            retval[AllBoardLocationsLength * 2 + 4] = (byte) state.Flags;

            return retval;
        }

        public static State FromBytes(byte[] boardBuffer)
        {
            if (boardBuffer == null)
            {
                throw new ArgumentNullException(nameof(boardBuffer), "Board state byte array must not be null.");
            }

            if (boardBuffer.Length != AllBoardLocationsLength * 2 + 5)
            {
                throw new ArgumentOutOfRangeException(nameof(boardBuffer), boardBuffer.Length,
                    $"Expected {AllBoardLocationsLength * 2 + 5} byte array for board info, got {boardBuffer.Length} bytes.");
            }

            var retval = StateManager.Create();
            var i = 0;
            foreach (var location in State.AllBoardLocations)
            {
                retval[location] = (Cell) BitConverter.ToUInt16(boardBuffer, i);
                i += 2;
            }

            retval.RedHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocationsLength * 2);
            retval.BlueHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocationsLength * 2 + 2);
            retval.Flags = (StateFlags) boardBuffer[AllBoardLocationsLength * 2 + 4];
            return retval;
        }
   }
}