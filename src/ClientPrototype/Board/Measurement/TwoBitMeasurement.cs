using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public struct TwoBitMeasurement : IMeasurement<byte>
    {
        private long _storageLsb;
        private long _storageMsb;

        public byte this[Location location]
        {
            get
            {
                var mask = GetMask(location);
                return (byte) (((_storageLsb & mask) != 0 ? 0x01 : 0x00) |
                               ((_storageMsb & mask) != 0 ? 0x02 : 0x00));
            }
            set
            {
                var mask = GetMask(location);
                var invMask = ~mask;
                if ((value & 0x02) == 0x02)
                {
                    _storageMsb |= mask;
                }
                else
                {
                    _storageMsb &= invMask;
                }
                if ((value & 0x01) == 0x01)
                {
                    _storageLsb |= mask;
                }
                else
                {
                    _storageLsb &= invMask;
                }
            }
        }

        private long GetMask(Location location)
        {
            switch (location)
            {
                case Location.A1:
                    return 0x1;
                case Location.A2:
                    return 0x2;
                case Location.A3:
                    return 0x4;
                case Location.A4:
                    return 0x8;
                case Location.A5:
                    return 0x10;
                case Location.B1:
                    return 0x20;
                case Location.B2:
                    return 0x40;
                case Location.B3:
                    return 0x80;
                case Location.B4:
                    return 0x100;
                case Location.B5:
                    return 0x200;
                case Location.B6:
                    return 0x400;
                case Location.C1:
                    return 0x800;
                case Location.C2:
                    return 0x1000;
                case Location.C3:
                    return 0x2000;
                case Location.C4:
                    return 0x4000;
                case Location.C5:
                    return 0x8000;
                case Location.C6:
                    return 0x10000;
                case Location.C7:
                    return 0x20000;
                case Location.D1:
                    return 0x40000;
                case Location.D2:
                    return 0x80000;
                case Location.D3:
                    return 0x100000;
                case Location.D4:
                    return 0x200000;
                case Location.D5:
                    return 0x400000;
                case Location.D6:
                    return 0x800000;
                case Location.D7:
                    return 0x1000000;
                case Location.D8:
                    return 0x2000000;
                case Location.E1:
                    return 0x4000000;
                case Location.E2:
                    return 0x8000000;
                case Location.E3:
                    return 0x10000000;
                case Location.E4:
                    return 0x20000000;
                case Location.E5:
                    return 0x40000000;
                case Location.E6:
                    return 0x80000000;
                case Location.E7:
                    return 0x100000000;
                case Location.E8:
                    return 0x200000000;
                case Location.E9:
                    return 0x400000000;
                case Location.F1:
                    return 0x800000000;
                case Location.F2:
                    return 0x1000000000;
                case Location.F3:
                    return 0x2000000000;
                case Location.F4:
                    return 0x4000000000;
                case Location.F5:
                    return 0x8000000000;
                case Location.F6:
                    return 0x10000000000;
                case Location.F7:
                    return 0x20000000000;
                case Location.F8:
                    return 0x40000000000;
                case Location.G1:
                    return 0x80000000000;
                case Location.G2:
                    return 0x100000000000;
                case Location.G3:
                    return 0x200000000000;
                case Location.G4:
                    return 0x400000000000;
                case Location.G5:
                    return 0x800000000000;
                case Location.G6:
                    return 0x1000000000000;
                case Location.G7:
                    return 0x2000000000000;
                case Location.H1:
                    return 0x4000000000000;
                case Location.H2:
                    return 0x8000000000000;
                case Location.H3:
                    return 0x10000000000000;
                case Location.H4:
                    return 0x20000000000000;
                case Location.H5:
                    return 0x40000000000000;
                case Location.H6:
                    return 0x80000000000000;
                case Location.I1:
                    return 0x100000000000000;
                case Location.I2:
                    return 0x200000000000000;
                case Location.I3:
                    return 0x400000000000000;
                case Location.I4:
                    return 0x800000000000000;
                case Location.I5:
                    return 0x1000000000000000;
                default:
                    throw new ArgumentOutOfRangeException(nameof(location), location, null);
            }
        }
    }
}
