using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public static class Movement
    {
        public static readonly Func<Location, Location>[] AllMoves =
            {North, NorthEast, SouthEast, South, SouthWest, NorthWest};

        public static Location North(Location from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.A5: return Location.A1;
                case Location.B6: return Location.B1;
                case Location.C7: return Location.C1;
                case Location.D8: return Location.D1;
                case Location.E9: return Location.E1;
                case Location.F8: return Location.F1;
                case Location.G7: return Location.G1;
                case Location.H6: return Location.H1;
                case Location.I5: return Location.I1;
                default: 
                    return from - 0x20;
            }
        }

        public static Location South(Location from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.A1: return Location.A5;
                case Location.B1: return Location.B6;
                case Location.C1: return Location.C7;
                case Location.D1: return Location.D8;
                case Location.E1: return Location.E9;
                case Location.F1: return Location.F8;
                case Location.G1: return Location.G7;
                case Location.H1: return Location.H6;
                case Location.I1: return Location.I5;
                default: return from + 0x20;
            }
        }

        public static Location NorthEast(Location from) 
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.E9: return Location.A5;
                case Location.F8: return Location.A4;
                case Location.G7: return Location.A3;
                case Location.G6: return Location.A2;
                case Location.I5: return Location.A1;
                case Location.I4:
                case Location.I3:
                case Location.I2:
                case Location.I1:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at east edge.");
                default: return from - 0xF;
            }
        }

        public static Location SouthEast(Location from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.E1: return Location.A1;
                case Location.F1: return Location.A2;
                case Location.G1: return Location.A3;
                case Location.H1: return Location.A4;
                case Location.I1: return Location.A5;
                case Location.I2:
                case Location.I3:
                case Location.I4:
                case Location.I5:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at east edge.");
                default: return from + 0x11;
            }
        }

        public static Location NorthWest(Location from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.A5: return Location.I1;
                case Location.B6: return Location.I2;
                case Location.C7: return Location.I3;
                case Location.D8: return Location.I4;
                case Location.E9: return Location.I5;
                case Location.A1:
                case Location.A2:
                case Location.A3:
                case Location.A4:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at west edge.");
                default: return from - 0x11;
            }
        }

        public static Location SouthWest(Location from)
        {
            if (!IsValidLocation(from))
                throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                    "Movement requested from invalid cell.");
            switch (from)
            {
                case Location.A1: return Location.I5;
                case Location.B1: return Location.I4;
                case Location.C1: return Location.I3;
                case Location.D1: return Location.I2;
                case Location.E1: return Location.I1;
                case Location.A2:
                case Location.A3:
                case Location.A4:
                case Location.A5:
                    throw new ArgumentOutOfRangeException(nameof(from), ((int) from).ToString("X2"),
                        "Invalid move departs board at west edge.");
                default: return from + 0x0F;
            }
        }

        public static bool IsValidLocation(Location location)
        {
            switch (location)
            {
                case Location.A1:
                case Location.A2:
                case Location.A3:
                case Location.A4:
                case Location.A5:
                case Location.B1:
                case Location.B2:
                case Location.B3:
                case Location.B4:
                case Location.B5:
                case Location.B6:
                case Location.C1:
                case Location.C2:
                case Location.C3:
                case Location.C4:
                case Location.C5:
                case Location.C6:
                case Location.C7:
                case Location.D1:
                case Location.D2:
                case Location.D3:
                case Location.D4:
                case Location.D5:
                case Location.D6:
                case Location.D7:
                case Location.D8:
                case Location.E1:
                case Location.E2:
                case Location.E3:
                case Location.E4:
                case Location.E5:
                case Location.E6:
                case Location.E7:
                case Location.E8:
                case Location.E9:
                case Location.F1:
                case Location.F2:
                case Location.F3:
                case Location.F4:
                case Location.F5:
                case Location.F6:
                case Location.F7:
                case Location.F8:
                case Location.G1:
                case Location.G2:
                case Location.G3:
                case Location.G4:
                case Location.G5:
                case Location.G6:
                case Location.G7:
                case Location.H1:
                case Location.H2:
                case Location.H3:
                case Location.H4:
                case Location.H5:
                case Location.H6:
                case Location.I1:
                case Location.I2:
                case Location.I3:
                case Location.I4:
                case Location.I5:
                    return true;
                default:
                    return false;
            }
        }
    }
}
