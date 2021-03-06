﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public struct AbstractMeasurementAutoAligned<T> : IMeasurement<T> where T : struct
    {
        private T _a1;
        private T _a2;
        private T _a3;
        private T _a4;
        private T _a5;
        private T _b1;
        private T _b2;
        private T _b3;
        private T _b4;
        private T _b5;
        private T _b6;
        private T _c1;
        private T _c2;
        private T _c3;
        private T _c4;
        private T _c5;
        private T _c6;
        private T _c7;
        private T _d1;
        private T _d2;
        private T _d3;
        private T _d4;
        private T _d5;
        private T _d6;
        private T _d7;
        private T _d8;
        private T _e1;
        private T _e2;
        private T _e3;
        private T _e4;
        private T _e5;
        private T _e6;
        private T _e7;
        private T _e8;
        private T _e9;
        private T _f1;
        private T _f2;
        private T _f3;
        private T _f4;
        private T _f5;
        private T _f6;
        private T _f7;
        private T _f8;
        private T _g1;
        private T _g2;
        private T _g3;
        private T _g4;
        private T _g5;
        private T _g6;
        private T _g7;
        private T _h1;
        private T _h2;
        private T _h3;
        private T _h4;
        private T _h5;
        private T _h6;
        private T _i1;
        private T _i2;
        private T _i3;
        private T _i4;
        private T _i5;


        public T this[Location location]
        {
            get
            {
                switch (location)
                {
                    case Location.A1:
                        return _a1;
                    case Location.A2:
                        return _a2;
                    case Location.A3:
                        return _a3;
                    case Location.A4:
                        return _a4;
                    case Location.A5:
                        return _a5;
                    case Location.B1:
                        return _b1;
                    case Location.B2:
                        return _b2;
                    case Location.B3:
                        return _b3;
                    case Location.B4:
                        return _b4;
                    case Location.B5:
                        return _b5;
                    case Location.B6:
                        return _b6;
                    case Location.C1:
                        return _c1;
                    case Location.C2:
                        return _c2;
                    case Location.C3:
                        return _c3;
                    case Location.C4:
                        return _c4;
                    case Location.C5:
                        return _c5;
                    case Location.C6:
                        return _c6;
                    case Location.C7:
                        return _c7;
                    case Location.D1:
                        return _d1;
                    case Location.D2:
                        return _d2;
                    case Location.D3:
                        return _d3;
                    case Location.D4:
                        return _d4;
                    case Location.D5:
                        return _d5;
                    case Location.D6:
                        return _d6;
                    case Location.D7:
                        return _d7;
                    case Location.D8:
                        return _d8;
                    case Location.E1:
                        return _e1;
                    case Location.E2:
                        return _e2;
                    case Location.E3:
                        return _e3;
                    case Location.E4:
                        return _e4;
                    case Location.E5:
                        return _e5;
                    case Location.E6:
                        return _e6;
                    case Location.E7:
                        return _e7;
                    case Location.E8:
                        return _e8;
                    case Location.E9:
                        return _e9;
                    case Location.F1:
                        return _f1;
                    case Location.F2:
                        return _f2;
                    case Location.F3:
                        return _f3;
                    case Location.F4:
                        return _f4;
                    case Location.F5:
                        return _f5;
                    case Location.F6:
                        return _f6;
                    case Location.F7:
                        return _f7;
                    case Location.F8:
                        return _f8;
                    case Location.G1:
                        return _g1;
                    case Location.G2:
                        return _g2;
                    case Location.G3:
                        return _g3;
                    case Location.G4:
                        return _g4;
                    case Location.G5:
                        return _g5;
                    case Location.G6:
                        return _g6;
                    case Location.G7:
                        return _g7;
                    case Location.H1:
                        return _h1;
                    case Location.H2:
                        return _h2;
                    case Location.H3:
                        return _h3;
                    case Location.H4:
                        return _h4;
                    case Location.H5:
                        return _h5;
                    case Location.H6:
                        return _h6;
                    case Location.I1:
                        return _i1;
                    case Location.I2:
                        return _i2;
                    case Location.I3:
                        return _i3;
                    case Location.I4:
                        return _i4;
                    case Location.I5:
                        return _i5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(location), location, null);
                }
            }
            set
            {
                switch (location)
                {
                    case Location.A1:
                        _a1 = value;
                        break;
                    case Location.A2:
                        _a2 = value;
                        break;
                    case Location.A3:
                        _a3 = value;
                        break;
                    case Location.A4:
                        _a4 = value;
                        break;
                    case Location.A5:
                        _a5 = value;
                        break;
                    case Location.B1:
                        _b1 = value;
                        break;
                    case Location.B2:
                        _b2 = value;
                        break;
                    case Location.B3:
                        _b3 = value;
                        break;
                    case Location.B4:
                        _b4 = value;
                        break;
                    case Location.B5:
                        _b5 = value;
                        break;
                    case Location.B6:
                        _b6 = value;
                        break;
                    case Location.C1:
                        _c1 = value;
                        break;
                    case Location.C2:
                        _c2 = value;
                        break;
                    case Location.C3:
                        _c3 = value;
                        break;
                    case Location.C4:
                        _c4 = value;
                        break;
                    case Location.C5:
                        _c5 = value;
                        break;
                    case Location.C6:
                        _c6 = value;
                        break;
                    case Location.C7:
                        _c7 = value;
                        break;
                    case Location.D1:
                        _d1 = value;
                        break;
                    case Location.D2:
                        _d2 = value;
                        break;
                    case Location.D3:
                        _d3 = value;
                        break;
                    case Location.D4:
                        _d4 = value;
                        break;
                    case Location.D5:
                        _d5 = value;
                        break;
                    case Location.D6:
                        _d6 = value;
                        break;
                    case Location.D7:
                        _d7 = value;
                        break;
                    case Location.D8:
                        _d8 = value;
                        break;
                    case Location.E1:
                        _e1 = value;
                        break;
                    case Location.E2:
                        _e2 = value;
                        break;
                    case Location.E3:
                        _e3 = value;
                        break;
                    case Location.E4:
                        _e4 = value;
                        break;
                    case Location.E5:
                        _e5 = value;
                        break;
                    case Location.E6:
                        _e6 = value;
                        break;
                    case Location.E7:
                        _e7 = value;
                        break;
                    case Location.E8:
                        _e8 = value;
                        break;
                    case Location.E9:
                        _e9 = value;
                        break;
                    case Location.F1:
                        _f1 = value;
                        break;
                    case Location.F2:
                        _f2 = value;
                        break;
                    case Location.F3:
                        _f3 = value;
                        break;
                    case Location.F4:
                        _f4 = value;
                        break;
                    case Location.F5:
                        _f5 = value;
                        break;
                    case Location.F6:
                        _f6 = value;
                        break;
                    case Location.F7:
                        _f7 = value;
                        break;
                    case Location.F8:
                        _f8 = value;
                        break;
                    case Location.G1:
                        _g1 = value;
                        break;
                    case Location.G2:
                        _g2 = value;
                        break;
                    case Location.G3:
                        _g3 = value;
                        break;
                    case Location.G4:
                        _g4 = value;
                        break;
                    case Location.G5:
                        _g5 = value;
                        break;
                    case Location.G6:
                        _g6 = value;
                        break;
                    case Location.G7:
                        _g7 = value;
                        break;
                    case Location.H1:
                        _h1 = value;
                        break;
                    case Location.H2:
                        _h2 = value;
                        break;
                    case Location.H3:
                        _h3 = value;
                        break;
                    case Location.H4:
                        _h4 = value;
                        break;
                    case Location.H5:
                        _h5 = value;
                        break;
                    case Location.H6:
                        _h6 = value;
                        break;
                    case Location.I1:
                        _i1 = value;
                        break;
                    case Location.I2:
                        _i2 = value;
                        break;
                    case Location.I3:
                        _i3 = value;
                        break;
                    case Location.I4:
                        _i4 = value;
                        break;
                    case Location.I5:
                        _i5 = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(location), location, null);
                }
            }
        }
    }
}