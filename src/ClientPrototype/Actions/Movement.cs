using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public static class Movement
    {
        public static readonly Func<Location, bool, bool, Location>[] AllMoves =
            {North, NorthEast, SouthEast, South, SouthWest, NorthWest};

        public static Location North(Location from, bool blueWallWrapAround, bool _)
        {
            if (!IsValidLocation(from)) return Location.Undefined;
            switch (from)
            {
                case Location.A5: if (blueWallWrapAround) return Location.A1; break;
                case Location.B6: if (blueWallWrapAround) return Location.B1; break;
                case Location.C7: if (blueWallWrapAround) return Location.C1; break;
                case Location.D8: if (blueWallWrapAround) return Location.D1; break;
                case Location.E9: if (blueWallWrapAround) return Location.E1; break;
                case Location.F8: if (blueWallWrapAround) return Location.F1; break;
                case Location.G7: if (blueWallWrapAround) return Location.G1; break;
                case Location.H6: if (blueWallWrapAround) return Location.H1; break;
                case Location.I5: if (blueWallWrapAround) return Location.I1; break;
                default: 
                    return from - 0x20;
            }

            return Location.Undefined;
        }

        public static Location South(Location from, bool _, bool redWallWrapAround)
        {
            if (!IsValidLocation(from)) return Location.Undefined;
            switch (from)
            {
                case Location.A1: if (redWallWrapAround) return Location.A5; break;
                case Location.B1: if (redWallWrapAround) return Location.B6; break;
                case Location.C1: if (redWallWrapAround) return Location.C7; break;
                case Location.D1: if (redWallWrapAround) return Location.D8; break;
                case Location.E1: if (redWallWrapAround) return Location.E9; break;
                case Location.F1: if (redWallWrapAround) return Location.F8; break;
                case Location.G1: if (redWallWrapAround) return Location.G7; break;
                case Location.H1: if (redWallWrapAround) return Location.H6; break;
                case Location.I1: if (redWallWrapAround) return Location.I5; break;
                default: return from + 0x20;
            }
  
            return Location.Undefined;
        }

        public static Location NorthEast(Location from, bool blueWallWrapAround, bool _) 
        {
            if (!IsValidLocation(from)) return Location.Undefined;
            switch (from)
            {
                case Location.E9: if (blueWallWrapAround) return Location.A5; break;
                case Location.F8: if (blueWallWrapAround) return Location.A4; break;
                case Location.G7: if (blueWallWrapAround) return Location.A3; break;
                case Location.G6: if (blueWallWrapAround) return Location.A2; break;
                case Location.I5: if (blueWallWrapAround) return Location.A1; break;
                case Location.I4:
                case Location.I3:
                case Location.I2:
                case Location.I1:
                    return Location.Undefined;
                default: return from - 0xF;
            }
 
            return Location.Undefined;
        }

        public static Location SouthEast(Location from, bool blueWallWrapAround, bool redWallWrapAround)
        {
            if (!IsValidLocation(from))
                return Location.Undefined;
            switch (from)
            {
                case Location.E1: if (redWallWrapAround) return Location.A1; break;
                case Location.F1: if (redWallWrapAround) return Location.A2; break;
                case Location.G1: if (redWallWrapAround) return Location.A3; break;
                case Location.H1: if (redWallWrapAround) return Location.A4; break;
                case Location.I1: if (redWallWrapAround) return Location.A5; break;
                case Location.I2:
                case Location.I3:
                case Location.I4:
                case Location.I5:
                    return Location.Undefined;
                default: return from + 0x11;
            }
   
            return Location.Undefined;
        }

        public static Location NorthWest(Location from, bool blueWallWrapAround, bool redWallWrapAround)
        {
            if (!IsValidLocation(from))return Location.Undefined;
            switch (from)
            {
                case Location.A5: if (blueWallWrapAround) return Location.I1; break;
                case Location.B6: if (blueWallWrapAround) return Location.I2; break;
                case Location.C7: if (blueWallWrapAround) return Location.I3; break;
                case Location.D8: if (blueWallWrapAround) return Location.I4; break;
                case Location.E9: if (blueWallWrapAround) return Location.I5; break;
                case Location.A1:
                case Location.A2:
                case Location.A3:
                case Location.A4:
                    return Location.Undefined;
                default: return from - 0x11;
            }
 
            return Location.Undefined;
        }

        public static Location SouthWest(Location from, bool blueWallWrapAround, bool redWallWrapAround)
        {
            if (!IsValidLocation(from))return Location.Undefined;
            switch (from)
            {
                case Location.A1: if (redWallWrapAround) return Location.I5; break;
                case Location.B1: if (redWallWrapAround) return Location.I4; break;
                case Location.C1: if (redWallWrapAround) return Location.I3; break;
                case Location.D1: if (redWallWrapAround) return Location.I2; break;
                case Location.E1: if (redWallWrapAround) return Location.I1; break;
                case Location.A2:
                case Location.A3:
                case Location.A4:
                case Location.A5:
                    return Location.Undefined;
                default: return from + 0x0F;
            }
  
            return Location.Undefined;
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
