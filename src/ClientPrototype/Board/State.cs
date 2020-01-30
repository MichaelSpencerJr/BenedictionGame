using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Benediction.Board
{
    /// <summary>
    /// Represents a snapshot of a game board, with all of its pieces.
    /// </summary>
    public class State : Dictionary<Location, Cell>, IEquatable<State>
    {
        public static readonly Guid InvalidBoard = new Guid(new byte[]
            {0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF});

        public static readonly Location[] AllBoardLocations =
        {
            Location.A1, Location.A2, Location.A3, Location.A4, Location.A5, Location.B1,
            Location.B2, Location.B3, Location.B4, Location.B5, Location.B6, Location.C1,
            Location.C2, Location.C3, Location.C4, Location.C5, Location.C6, Location.C7,
            Location.D1, Location.D2, Location.D3, Location.D4, Location.D5, Location.D6,
            Location.D7, Location.D8, Location.E1, Location.E2, Location.E3, Location.E4,
            Location.E5, Location.E6, Location.E7, Location.E8, Location.E9, Location.F1,
            Location.F2, Location.F3, Location.F4, Location.F5, Location.F6, Location.F7,
            Location.F8, Location.G1, Location.G2, Location.G3, Location.G4, Location.G5,
            Location.G6, Location.G7, Location.H1, Location.H2, Location.H3, Location.H4,
            Location.H5, Location.H6, Location.I1, Location.I2, Location.I3, Location.I4,
            Location.I5,
        };

        public static readonly Location[] RedWallAdjacentLocations =
        {
            Location.A1, Location.B1, Location.C1, Location.D1, Location.E1, Location.F1, Location.G1, Location.H1,
            Location.I1
        };

        public static readonly Location[] BlueWallAdjacentLocations =
        {
            Location.A5, Location.B6, Location.C7, Location.D8, Location.E9, Location.F8, Location.G7, Location.H6,
            Location.I5
        };

        /// <summary>
        /// Board state checksum, for indexing specific boards and for computing a checksum on decoded boards to confirm validity.
        /// </summary>
        public Guid BoardId
        {
            get
            {
                var hash = _hasher.ComputeHash(GetBuffer());
                return new Guid(new[]
                {
                    (byte) (hash[0] ^ hash[16]),
                    (byte) (hash[1] ^ hash[17]),
                    (byte) (hash[2] ^ hash[18]),
                    (byte) (hash[3] ^ hash[19]),
                    (byte) (hash[4] ^ hash[20]),
                    (byte) (hash[5] ^ hash[21]),
                    (byte) (hash[6] ^ hash[22]),
                    (byte) (hash[7] ^ hash[23]),
                    (byte) (hash[8] ^ hash[24]),
                    (byte) (hash[9] ^ hash[25]),
                    (byte) (hash[10] ^ hash[26]),
                    (byte) (hash[11] ^ hash[27]),
                    (byte) (hash[12] ^ hash[28]),
                    (byte) (hash[13] ^ hash[29]),
                    (byte) (hash[14] ^ hash[30]),
                    (byte) (hash[15] ^ hash[31]),
                });
            }
        }

        /// <summary>
        /// Location of red home space, if set
        /// </summary>
        public Location RedHome { get; set; }

        /// <summary>
        /// Location of blue home space, if set
        /// </summary>
        public Location BlueHome { get; set; }

        /// <summary>
        /// Game state flags indicating win/lose conditions and what move happens next
        /// </summary>
        public StateFlags Flags { get; set; }

        private static SHA256 _hasher = SHA256.Create();

        /// <summary>
        /// Creates an empty <see cref="State"/> with no homes or pieces
        /// </summary>
        public State() : base(AllBoardLocations.Length)
        {
            foreach (var key in AllBoardLocations)
            {
                this[key] = Cell.Empty;
            }
        }

        /// <summary>
        /// Decodes a <see cref="State"/> from provided input string
        /// </summary>
        /// <param name="description">Text description of input board</param>
        public State(string description) : this()
        {
            var lines = description.Split(new[] {"\r\n", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
            ParseHeaderV1(LineFilter(lines[0]));
            for (var i = 1; i < lines.Length; i++)
            {
                ParseSideV1(LineFilter(lines[i]));
            }
        }

        public static string LineFilter(string input)
        {
            return input.Trim(' ', '|', '\t');
        }

        /// <summary>
        /// Decodes a BoardState from provided input bytes
        /// </summary>
        /// <param name="boardBuffer">127-byte buffer containing board data</param>
        public State(byte[] boardBuffer) : base(AllBoardLocations.Length)
        {
            if (boardBuffer == null)
            {
                throw new ArgumentNullException(nameof(boardBuffer), "Board state byte array must not be null.");
            }

            if (boardBuffer.Length != AllBoardLocations.Length * 2 + 5)
            {
                throw new ArgumentOutOfRangeException(nameof(boardBuffer), boardBuffer.Length,
                    $"Expected {AllBoardLocations.Length * 2 + 5} byte array for board info, got {boardBuffer.Length} bytes.");
            }

            for (var i = 0; i < AllBoardLocations.Length * 2; i += 2)
            {
                this[AllBoardLocations[i / 2]] = (Cell) BitConverter.ToUInt16(boardBuffer, i);
            }

            RedHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length * 2);
            BlueHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length * 2 + 2);
            Flags = (StateFlags) boardBuffer[AllBoardLocations.Length * 2 + 4];
        }

        /// <summary>
        /// Encodes the current board information as bytes
        /// </summary>
        /// <returns>127-byte buffer describing the game board</returns>
        public byte[] GetBuffer()
        {
            var retval = new byte[AllBoardLocations.Length * 2 + 5];

            for (var i = 0; i < AllBoardLocations.Length * 2; i += 2)
            {
                var bytes = BitConverter.GetBytes(Convert.ToUInt16(this[AllBoardLocations[i / 2]]));
                Array.ConstrainedCopy(bytes, 0, retval, i, 2);
            }

            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) RedHome), 0, retval, AllBoardLocations.Length * 2, 2);
            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) BlueHome), 0, retval, AllBoardLocations.Length * 2 + 2,
                2);
            retval[AllBoardLocations.Length * 2 + 4] = (byte) Flags;

            return retval;
        }

        public const string BenedictionV1Header = "Benediction v1";
        public const string RedV1Header = ": R";
        public const string BlueV1Header = " B";
        public const char SideV1Move1 = '-';
        public const char SideV1Move2 = '=';
        public const char SideV1KingTaken = 'x';
        public const char SideV1Win = 'W';

        public bool Equals(State other)
        {
            return other != null && BoardId == other.BoardId;
        }

        /// <summary>
        /// Current game board represented as a human-readable string
        /// </summary>
        /// <returns>Game board description</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            char redFlag, blueFlag;
            if ((Flags & StateFlags.RedAction1) == StateFlags.RedAction1) redFlag = SideV1Move1;
            else if ((Flags & StateFlags.RedAction2) == StateFlags.RedAction2) redFlag = SideV1Move2;
            else if ((Flags & StateFlags.RedKingTaken) == StateFlags.RedKingTaken) redFlag = SideV1KingTaken;
            else if ((Flags & StateFlags.RedWin) == StateFlags.RedWin) redFlag = SideV1Win;
            else redFlag = ' ';
            if ((Flags & StateFlags.BlueAction1) == StateFlags.BlueAction1) blueFlag = SideV1Move1;
            else if ((Flags & StateFlags.BlueAction2) == StateFlags.BlueAction2) blueFlag = SideV1Move2;
            else if ((Flags & StateFlags.BlueKingTaken) == StateFlags.BlueKingTaken) blueFlag = SideV1KingTaken;
            else if ((Flags & StateFlags.BlueWin) == StateFlags.BlueWin) blueFlag = SideV1Win;
            else blueFlag = ' ';

            sb.Append(BenedictionV1Header).Append(RedV1Header).Append(redFlag).Append(RedHome).Append(BlueV1Header)
                .Append(blueFlag).Append(BlueHome).AppendLine();

            sb.Append("R:");
            foreach (var column in "ABCDEFGHI")
            {
                AddRow(Cell.SideRed, column, sb);
            }

            sb.AppendLine();
            sb.Append("B:");
            foreach (var column in "ABCDEFGHI")
            {
                AddRow(Cell.Empty, column, sb);
            }

            if (Values.Contains(Cell.Block))
            {

                sb.AppendLine();
                sb.Append("X:");
                foreach (var column in "ABCDEFGHI")
                {
                    AddRow(Cell.Block, column, sb);
                }
            }

            return sb.ToString();
        }

        public void AddRow(Cell side, char column, StringBuilder output)
        {
            var rowPresent = false;
            foreach (var columnPiece in GetColumn(column))
            {
                if (this[columnPiece] != Cell.Empty && (this[columnPiece] & (Cell.SideRed | Cell.Block)) == side)
                {
                    if (!rowPresent)
                    {
                        output.Append(column);
                        rowPresent = true;
                    }

                    output.Append(columnPiece.ToString().Substring(1));
                    if ((this[columnPiece] & Cell.King) == Cell.King) output.Append('k');
                    if ((this[columnPiece] & Cell.Blessed) == Cell.Blessed) output.Append('b');
                    if ((this[columnPiece] & Cell.Cursed) == Cell.Cursed) output.Append('c');
                    for (var i = Cell.Size2; i <= Cell.SizeMask; i += 1)
                    {
                        if ((this[columnPiece] & Cell.SizeMask) >= i)
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

        public void ParseHeaderV1(string line)
        {
            var offset = 0;
            if (!TryConsume(line, ref offset, BenedictionV1Header)) return;
            if (!TryConsume(line, ref offset, RedV1Header)) return;

            switch (line[offset++])
            {
                case SideV1Move1:
                    Flags |= StateFlags.RedAction1;
                    break;
                case SideV1Move2: 
                    Flags |= StateFlags.RedAction2;
                    break;
                case SideV1KingTaken: 
                    Flags |= StateFlags.RedKingTaken;
                    break;
                case SideV1Win:
                    Flags |= StateFlags.RedWin;
                    break;
            }

            RedHome = (Location) Enum.Parse(typeof(Location), line.Substring(offset, 2));
            offset += 2;

            if (!TryConsume(line, ref offset, BlueV1Header)) return;

            switch (line[offset++])
            {
                case SideV1Move1:
                    Flags |= StateFlags.BlueAction1;
                    break;
                case SideV1Move2: 
                    Flags |= StateFlags.BlueAction2;
                    break;
                case SideV1KingTaken: 
                    Flags |= StateFlags.BlueKingTaken;
                    break;
                case SideV1Win:
                    Flags |= StateFlags.BlueWin;
                    break;
            }


            BlueHome = (Location) Enum.Parse(typeof(Location), line.Substring(offset, 2));
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

        public void ParseSideV1(string line)
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
            else return;

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
                        this[location] = side;
                        break;
                    case '2':
                        location = column - 0x20;
                        this[location] = side;
                        break;

                    case '3':
                        location = column - 0x40;
                        this[location] = side;
                        break;

                    case '4':
                        location = column - 0x60;
                        this[location] = side;
                        break;

                    case '5':
                        location = column - 0x80;
                        this[location] = side;
                        break;

                    case '6':
                        location = column - 0xA0;
                        this[location] = side;
                        break;

                    case '7':
                        location = column - 0xC0;
                        this[location] = side;
                        break;

                    case '8':
                        location = column - 0xE0;
                        this[location] = side;
                        break;

                    case '9':
                        location = column - 0x100;
                        this[location] = side;
                        break;
                    case 'k':
                        this[location] |= Cell.King;
                        break;
                    case 'b':
                        this[location] |= Cell.Blessed;
                        break;
                    case 'c':
                        this[location] |= Cell.Cursed;
                        break;
                    case '+':
                        this[location]++;
                        break;

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

        /// <summary>
        /// Returns a deep copy (duplicated object with different address, which can be edited without accidentally modifying the original)
        /// of the current game board.
        /// </summary>
        /// <returns>Deep copy of current game board</returns>
        public State DeepCopy()
        {
            return new State(GetBuffer());
        }
    }
}