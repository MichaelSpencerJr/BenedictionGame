using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Benediction.Actions;

namespace Benediction.Board
{
    [StructLayout(LayoutKind.Explicit, Size=117)]
    public struct State : IEnumerable<KeyValuePair<Location, Cell>>
    {
        [FieldOffset(0)] private Cell a1;
        [FieldOffset(2)] private Cell a2;
        [FieldOffset(4)] private Cell a3;
        [FieldOffset(6)] private Cell a4;
        [FieldOffset(8)] private Cell a5;
        [FieldOffset(10)] private Cell b1;
        [FieldOffset(12)] private Cell b2;
        [FieldOffset(14)] private Cell b3;
        [FieldOffset(16)] private Cell b4;
        [FieldOffset(18)] private Cell b5;
        [FieldOffset(20)] private Cell b6;
        [FieldOffset(22)] private Cell c1;
        [FieldOffset(24)] private Cell c2;
        [FieldOffset(26)] private Cell c3;
        [FieldOffset(28)] private Cell c4;
        [FieldOffset(30)] private Cell c5;
        [FieldOffset(32)] private Cell c6;
        [FieldOffset(34)] private Cell c7;
        [FieldOffset(36)] private Cell d1;
        [FieldOffset(38)] private Cell d2;
        [FieldOffset(40)] private Cell d3;
        [FieldOffset(42)] private Cell d4;
        [FieldOffset(44)] private Cell d5;
        [FieldOffset(46)] private Cell d6;
        [FieldOffset(48)] private Cell d7;
        [FieldOffset(50)] private Cell d8;
        [FieldOffset(52)] private Cell e1;
        [FieldOffset(54)] private Cell e2;
        [FieldOffset(56)] private Cell e3;
        [FieldOffset(58)] private Cell e4;
        [FieldOffset(60)] private Cell e5;
        [FieldOffset(62)] private Cell e6;
        [FieldOffset(64)] private Cell e7;
        [FieldOffset(66)] private Cell e8;
        [FieldOffset(68)] private Cell e9;
        [FieldOffset(70)] private Cell f1;
        [FieldOffset(72)] private Cell f2;
        [FieldOffset(74)] private Cell f3;
        [FieldOffset(76)] private Cell f4;
        [FieldOffset(78)] private Cell f5;
        [FieldOffset(80)] private Cell f6;
        [FieldOffset(82)] private Cell f7;
        [FieldOffset(84)] private Cell f8;
        [FieldOffset(86)] private Cell g1;
        [FieldOffset(88)] private Cell g2;
        [FieldOffset(90)] private Cell g3;
        [FieldOffset(92)] private Cell g4;
        [FieldOffset(94)] private Cell g5;
        [FieldOffset(96)] private Cell g6;
        [FieldOffset(98)] private Cell g7;
        [FieldOffset(100)] private Cell h1;
        [FieldOffset(102)] private Cell h2;
        [FieldOffset(104)] private Cell h3;
        [FieldOffset(106)] private Cell h4;
        [FieldOffset(108)] private Cell h5;
        [FieldOffset(110)] private Cell h6;
        [FieldOffset(112)] private Cell i1;
        [FieldOffset(114)] private Cell i2;
        [FieldOffset(116)] private Cell i3;
        [FieldOffset(118)] private Cell i4;
        [FieldOffset(120)] private Cell i5;
        [FieldOffset(122)] private Location redHome;
        [FieldOffset(124)] private Location blueHome;
        [FieldOffset(126)] private StateFlags flags;

        public bool Equals(State other)
        {
            return BoardId == other.BoardId;
        }

        public IEnumerator<KeyValuePair<Location, Cell>> GetEnumerator()
        {
            return new StateEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Location RedHome
        {
            get => redHome;
            set
            {
                if (!Movement.IsValidLocation(value)) throw new InvalidOperationException();
                redHome = value;
            }
        }

        public Location BlueHome
        {
            get => blueHome;
            set
            {
                if (!Movement.IsValidLocation(value)) throw new InvalidOperationException();
                blueHome = value;
            }
        }

        public StateFlags Flags
        {
            get => flags;
            set => flags = value;
        }

        public bool Unset
        {
            get { return flags == 0; }
        }

        public Cell this[Location location]
        {
            get {
                switch (location)
                {
                    case Location.A1:
                        return a1;
                    case Location.A2:
                        return a2;
                    case Location.A3:
                        return a3;
                    case Location.A4:
                        return a4;
                    case Location.A5:
                        return a5;
                    case Location.B1:
                        return b1;
                    case Location.B2:
                        return b2;
                    case Location.B3:
                        return b3;
                    case Location.B4:
                        return b4;
                    case Location.B5:
                        return b5;
                    case Location.B6:
                        return b6;
                    case Location.C1:
                        return c1;
                    case Location.C2:
                        return c2;
                    case Location.C3:
                        return c3;
                    case Location.C4:
                        return c4;
                    case Location.C5:
                        return c5;
                    case Location.C6:
                        return c6;
                    case Location.C7:
                        return c7;
                    case Location.D1:
                        return d1;
                    case Location.D2:
                        return d2;
                    case Location.D3:
                        return d3;
                    case Location.D4:
                        return d4;
                    case Location.D5:
                        return d5;
                    case Location.D6:
                        return d6;
                    case Location.D7:
                        return d7;
                    case Location.D8:
                        return d8;
                    case Location.E1:
                        return e1;
                    case Location.E2:
                        return e2;
                    case Location.E3:
                        return e3;
                    case Location.E4:
                        return e4;
                    case Location.E5:
                        return e5;
                    case Location.E6:
                        return e6;
                    case Location.E7:
                        return e7;
                    case Location.E8:
                        return e8;
                    case Location.E9:
                        return e9;
                    case Location.F1:
                        return f1;
                    case Location.F2:
                        return f2;
                    case Location.F3:
                        return f3;
                    case Location.F4:
                        return f4;
                    case Location.F5:
                        return f5;
                    case Location.F6:
                        return f6;
                    case Location.F7:
                        return f7;
                    case Location.F8:
                        return f8;
                    case Location.G1:
                        return g1;
                    case Location.G2:
                        return g2;
                    case Location.G3:
                        return g3;
                    case Location.G4:
                        return g4;
                    case Location.G5:
                        return g5;
                    case Location.G6:
                        return g6;
                    case Location.G7:
                        return g7;
                    case Location.H1:
                        return h1;
                    case Location.H2:
                        return h2;
                    case Location.H3:
                        return h3;
                    case Location.H4:
                        return h4;
                    case Location.H5:
                        return h5;
                    case Location.H6:
                        return h6;
                    case Location.I1:
                        return i1;
                    case Location.I2:
                        return i2;
                    case Location.I3:
                        return i3;
                    case Location.I4:
                        return i4;
                    case Location.I5:
                        return i5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(location), location, null);
                } }
            set
            {
                switch (location)
                {
                    case Location.A1:
                        a1 = value;
                        break;
                    case Location.A2:
                        a2 = value;
                        break;
                    case Location.A3:
                        a3 = value;
                        break;
                    case Location.A4:
                        a4 = value;
                        break;
                    case Location.A5:
                        a5 = value;
                        break;
                    case Location.B1:
                        b1 = value;
                        break;
                    case Location.B2:
                        b2 = value;
                        break;
                    case Location.B3:
                        b3 = value;
                        break;
                    case Location.B4:
                        b4 = value;
                        break;
                    case Location.B5:
                        b5 = value;
                        break;
                    case Location.B6:
                        b6 = value;
                        break;
                    case Location.C1:
                        c1 = value;
                        break;
                    case Location.C2:
                        c2 = value;
                        break;
                    case Location.C3:
                        c3 = value;
                        break;
                    case Location.C4:
                        c4 = value;
                        break;
                    case Location.C5:
                        c5 = value;
                        break;
                    case Location.C6:
                        c6 = value;
                        break;
                    case Location.C7:
                        c7 = value;
                        break;
                    case Location.D1:
                        d1 = value;
                        break;
                    case Location.D2:
                        d2 = value;
                        break;
                    case Location.D3:
                        d3 = value;
                        break;
                    case Location.D4:
                        d4 = value;
                        break;
                    case Location.D5:
                        d5 = value;
                        break;
                    case Location.D6:
                        d6 = value;
                        break;
                    case Location.D7:
                        d7 = value;
                        break;
                    case Location.D8:
                        d8 = value;
                        break;
                    case Location.E1:
                        e1 = value;
                        break;
                    case Location.E2:
                        e2 = value;
                        break;
                    case Location.E3:
                        e3 = value;
                        break;
                    case Location.E4:
                        e4 = value;
                        break;
                    case Location.E5:
                        e5 = value;
                        break;
                    case Location.E6:
                        e6 = value;
                        break;
                    case Location.E7:
                        e7 = value;
                        break;
                    case Location.E8:
                        e8 = value;
                        break;
                    case Location.E9:
                        e9 = value;
                        break;
                    case Location.F1:
                        f1 = value;
                        break;
                    case Location.F2:
                        f2 = value;
                        break;
                    case Location.F3:
                        f3 = value;
                        break;
                    case Location.F4:
                        f4 = value;
                        break;
                    case Location.F5:
                        f5 = value;
                        break;
                    case Location.F6:
                        f6 = value;
                        break;
                    case Location.F7:
                        f7 = value;
                        break;
                    case Location.F8:
                        f8 = value;
                        break;
                    case Location.G1:
                        g1 = value;
                        break;
                    case Location.G2:
                        g2 = value;
                        break;
                    case Location.G3:
                        g3 = value;
                        break;
                    case Location.G4:
                        g4 = value;
                        break;
                    case Location.G5:
                        g5 = value;
                        break;
                    case Location.G6:
                        g6 = value;
                        break;
                    case Location.G7:
                        g7 = value;
                        break;
                    case Location.H1:
                        h1 = value;
                        break;
                    case Location.H2:
                        h2 = value;
                        break;
                    case Location.H3:
                        h3 = value;
                        break;
                    case Location.H4:
                        h4 = value;
                        break;
                    case Location.H5:
                        h5 = value;
                        break;
                    case Location.H6:
                        h6 = value;
                        break;
                    case Location.I1:
                        i1 = value;
                        break;
                    case Location.I2:
                        i2 = value;
                        break;
                    case Location.I3:
                        i3 = value;
                        break;
                    case Location.I4:
                        i4 = value;
                        break;
                    case Location.I5:
                        i5 = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(location), location, null);
                }
            }
        }

        public Guid BoardId
        {
            get
            {
                var lowPart = ((((((((((((((((((((((((((((((((3074457345618258791ul
                                                              + (ushort) a1) * 3074457345618258791ul
                                                             + (ushort) a2) * 3074457345618258791ul
                                                            + (ushort) a3) * 3074457345618258791ul
                                                           + (ushort) a4) * 3074457345618258791ul
                                                          + (ushort) a5) * 3074457345618258791ul
                                                         + (ushort) b1) * 3074457345618258791ul
                                                        + (ushort) b2) * 3074457345618258791ul
                                                       + (ushort) b3) * 3074457345618258791ul
                                                      + (ushort) b4) * 3074457345618258791ul
                                                     + (ushort) b5) * 3074457345618258791ul
                                                    + (ushort) b6) * 3074457345618258791ul
                                                   + (ushort) c1) * 3074457345618258791ul
                                                  + (ushort) c2) * 3074457345618258791ul
                                                 + (ushort) c3) * 3074457345618258791ul
                                                + (ushort) c4) * 3074457345618258791ul
                                               + (ushort) c5) * 3074457345618258791ul
                                              + (ushort) c6) * 3074457345618258791ul
                                             + (ushort) c7) * 3074457345618258791ul
                                            + (ushort) d1) * 3074457345618258791ul
                                           + (ushort) d2) * 3074457345618258791ul
                                          + (ushort) d3) * 3074457345618258791ul
                                         + (ushort) d4) * 3074457345618258791ul
                                        + (ushort) d5) * 3074457345618258791ul
                                       + (ushort) d6) * 3074457345618258791ul
                                      + (ushort) d7) * 3074457345618258791ul
                                     + (ushort) d8) * 3074457345618258791ul
                                    + (ushort) e1) * 3074457345618258791ul
                                   + (ushort) e2) * 3074457345618258791ul
                                  + (ushort) e3) * 3074457345618258791ul
                                 + (ushort) e4) * 3074457345618258791ul
                                + (ushort) e5) * 3074457345618258791ul
                               + (ushort) redHome) * 3074457345618258791ul;
                var highPart = ((((((((((((((((((((((((((((((((3074457345618258791ul
                                                               + (ushort) i1) * 3074457345618258791ul
                                                              + (ushort) i2) * 3074457345618258791ul
                                                             + (ushort) i3) * 3074457345618258791ul
                                                            + (ushort) i4) * 3074457345618258791ul
                                                           + (ushort) i5) * 3074457345618258791ul
                                                          + (ushort) h1) * 3074457345618258791ul
                                                         + (ushort) h2) * 3074457345618258791ul
                                                        + (ushort) h3) * 3074457345618258791ul
                                                       + (ushort) h4) * 3074457345618258791ul
                                                      + (ushort) h5) * 3074457345618258791ul
                                                     + (ushort) h6) * 3074457345618258791ul
                                                    + (ushort) g1) * 3074457345618258791ul
                                                   + (ushort) g2) * 3074457345618258791ul
                                                  + (ushort) g3) * 3074457345618258791ul
                                                 + (ushort) g4) * 3074457345618258791ul
                                                + (ushort) g5) * 3074457345618258791ul
                                               + (ushort) g6) * 3074457345618258791ul
                                              + (ushort) g7) * 3074457345618258791ul
                                             + (ushort) f1) * 3074457345618258791ul
                                            + (ushort) f2) * 3074457345618258791ul
                                           + (ushort) f3) * 3074457345618258791ul
                                          + (ushort) f4) * 3074457345618258791ul
                                         + (ushort) f5) * 3074457345618258791ul
                                        + (ushort) f6) * 3074457345618258791ul
                                       + (ushort) f7) * 3074457345618258791ul
                                      + (ushort) f8) * 3074457345618258791ul
                                     + (ushort) e6) * 3074457345618258791ul
                                    + (ushort) e7) * 3074457345618258791ul
                                   + (ushort) e8) * 3074457345618258791ul
                                  + (ushort) e9) * 3074457345618258791ul
                                 + (ushort) blueHome) * 3074457345618258791ul
                                + (byte) flags) * 3074457345618258791ul;
                var lowBytes = BitConverter.GetBytes(lowPart);
                var highBytes = BitConverter.GetBytes(highPart);
                return new Guid(new[]
                {
                    lowBytes[0], lowBytes[1], lowBytes[2], lowBytes[3], lowBytes[4], lowBytes[5], lowBytes[6],
                    lowBytes[7], highBytes[0], highBytes[1], highBytes[2], highBytes[3], highBytes[4], highBytes[5],
                    highBytes[6], highBytes[7]
                });
            }
        }

        public IEnumerable<Location> RedWallAdjacentLocations
        {
            get
            {
                yield return Location.A1;
                yield return Location.B1;
                yield return Location.C1;
                yield return Location.D1;
                yield return Location.E1;
                yield return Location.F1;
                yield return Location.G1;
                yield return Location.H1;
                yield return Location.I1;
            }
        }

        public IEnumerable<Location> BlueWallAdjacentLocations
        {
            get
            {
                yield return Location.A5;
                yield return Location.B6;
                yield return Location.C7;
                yield return Location.D8;
                yield return Location.E9;
                yield return Location.F8;
                yield return Location.G7;
                yield return Location.H6;
                yield return Location.I5;
            }
        }

        public IEnumerable<Location> AllBoardLocations
        {
            get
            {
                yield return Location.A1;
                yield return Location.A2;
                yield return Location.A3;
                yield return Location.A4;
                yield return Location.A5;
                yield return Location.B1;
                yield return Location.B2;
                yield return Location.B3;
                yield return Location.B4;
                yield return Location.B5;
                yield return Location.B6;
                yield return Location.C1;
                yield return Location.C2;
                yield return Location.C3;
                yield return Location.C4;
                yield return Location.C5;
                yield return Location.C6;
                yield return Location.C7;
                yield return Location.D1;
                yield return Location.D2;
                yield return Location.D3;
                yield return Location.D4;
                yield return Location.D5;
                yield return Location.D6;
                yield return Location.D7;
                yield return Location.D8;
                yield return Location.E1;
                yield return Location.E2;
                yield return Location.E3;
                yield return Location.E4;
                yield return Location.E5;
                yield return Location.E6;
                yield return Location.E7;
                yield return Location.E8;
                yield return Location.E9;
                yield return Location.F1;
                yield return Location.F2;
                yield return Location.F3;
                yield return Location.F4;
                yield return Location.F5;
                yield return Location.F6;
                yield return Location.F7;
                yield return Location.F8;
                yield return Location.G1;
                yield return Location.G2;
                yield return Location.G3;
                yield return Location.G4;
                yield return Location.G5;
                yield return Location.G6;
                yield return Location.G7;
                yield return Location.H1;
                yield return Location.H2;
                yield return Location.H3;
                yield return Location.H4;
                yield return Location.H5;
                yield return Location.H6;
                yield return Location.I1;
                yield return Location.I2;
                yield return Location.I3;
                yield return Location.I4;
                yield return Location.I5;
            }
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(State left, State right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(State left, State right)
        {
            return !(left == right);
        }
    }
}