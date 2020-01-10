using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction
{
    public static class Movement
    {
        public static readonly Func<BoardLocation, BoardLocation>[] AllMoves =
            {North, NorthEast, SouthEast, South, SouthWest, NorthWest};

        public static BoardLocation North(BoardLocation from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.A5: return BoardLocation.A1;
                case BoardLocation.B6: return BoardLocation.B1;
                case BoardLocation.C7: return BoardLocation.C1;
                case BoardLocation.D8: return BoardLocation.D1;
                case BoardLocation.E9: return BoardLocation.E1;
                case BoardLocation.F8: return BoardLocation.F1;
                case BoardLocation.G7: return BoardLocation.G1;
                case BoardLocation.H6: return BoardLocation.H1;
                case BoardLocation.I5: return BoardLocation.I1;
                default: 
                    return from - 0x20;
            }
        }

        public static BoardLocation South(BoardLocation from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.A1: return BoardLocation.A5;
                case BoardLocation.B1: return BoardLocation.B6;
                case BoardLocation.C1: return BoardLocation.C7;
                case BoardLocation.D1: return BoardLocation.D8;
                case BoardLocation.E1: return BoardLocation.E9;
                case BoardLocation.F1: return BoardLocation.F8;
                case BoardLocation.G1: return BoardLocation.G7;
                case BoardLocation.H1: return BoardLocation.H6;
                case BoardLocation.I1: return BoardLocation.I5;
                default: return from + 0x20;
            }
        }

        public static BoardLocation NorthEast(BoardLocation from) 
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.E9: return BoardLocation.A5;
                case BoardLocation.F8: return BoardLocation.A4;
                case BoardLocation.G7: return BoardLocation.A3;
                case BoardLocation.G6: return BoardLocation.A2;
                case BoardLocation.I5: return BoardLocation.A1;
                case BoardLocation.I4:
                case BoardLocation.I3:
                case BoardLocation.I2:
                case BoardLocation.I1:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at east edge.");
                default: return from - 0xF;
            }
        }

        public static BoardLocation SouthEast(BoardLocation from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.E1: return BoardLocation.A1;
                case BoardLocation.F1: return BoardLocation.A2;
                case BoardLocation.G1: return BoardLocation.A3;
                case BoardLocation.H1: return BoardLocation.A4;
                case BoardLocation.I1: return BoardLocation.A5;
                case BoardLocation.I2:
                case BoardLocation.I3:
                case BoardLocation.I4:
                case BoardLocation.I5:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at east edge.");
                default: return from + 0x11;
            }
        }

        public static BoardLocation NorthWest(BoardLocation from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.A5: return BoardLocation.I1;
                case BoardLocation.B6: return BoardLocation.I2;
                case BoardLocation.C7: return BoardLocation.I3;
                case BoardLocation.D8: return BoardLocation.I4;
                case BoardLocation.E9: return BoardLocation.I5;
                case BoardLocation.A1:
                case BoardLocation.A2:
                case BoardLocation.A3:
                case BoardLocation.A4:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at west edge.");
                default: return from - 0x11;
            }
        }

        public static BoardLocation SouthWest(BoardLocation from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case BoardLocation.A1: return BoardLocation.I5;
                case BoardLocation.B1: return BoardLocation.I4;
                case BoardLocation.C1: return BoardLocation.I3;
                case BoardLocation.D1: return BoardLocation.I2;
                case BoardLocation.E1: return BoardLocation.I1;
                case BoardLocation.A2:
                case BoardLocation.A3:
                case BoardLocation.A4:
                case BoardLocation.A5:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at west edge.");
                default: return from + 0x0F;
            }
        }

        public static bool IsValidLocation(BoardLocation location)
        {
            switch (location)
            {
                case BoardLocation.A1:
                case BoardLocation.A2:
                case BoardLocation.A3:
                case BoardLocation.A4:
                case BoardLocation.A5:
                case BoardLocation.B1:
                case BoardLocation.B2:
                case BoardLocation.B3:
                case BoardLocation.B4:
                case BoardLocation.B5:
                case BoardLocation.B6:
                case BoardLocation.C1:
                case BoardLocation.C2:
                case BoardLocation.C3:
                case BoardLocation.C4:
                case BoardLocation.C5:
                case BoardLocation.C6:
                case BoardLocation.C7:
                case BoardLocation.D1:
                case BoardLocation.D2:
                case BoardLocation.D3:
                case BoardLocation.D4:
                case BoardLocation.D5:
                case BoardLocation.D6:
                case BoardLocation.D7:
                case BoardLocation.D8:
                case BoardLocation.E1:
                case BoardLocation.E2:
                case BoardLocation.E3:
                case BoardLocation.E4:
                case BoardLocation.E5:
                case BoardLocation.E6:
                case BoardLocation.E7:
                case BoardLocation.E8:
                case BoardLocation.E9:
                case BoardLocation.F1:
                case BoardLocation.F2:
                case BoardLocation.F3:
                case BoardLocation.F4:
                case BoardLocation.F5:
                case BoardLocation.F6:
                case BoardLocation.F7:
                case BoardLocation.F8:
                case BoardLocation.G1:
                case BoardLocation.G2:
                case BoardLocation.G3:
                case BoardLocation.G4:
                case BoardLocation.G5:
                case BoardLocation.G6:
                case BoardLocation.G7:
                case BoardLocation.H1:
                case BoardLocation.H2:
                case BoardLocation.H3:
                case BoardLocation.H4:
                case BoardLocation.H5:
                case BoardLocation.H6:
                case BoardLocation.I1:
                case BoardLocation.I2:
                case BoardLocation.I3:
                case BoardLocation.I4:
                case BoardLocation.I5:
                    return true;
                default:
                    return false;
            }
        }
    }
}
