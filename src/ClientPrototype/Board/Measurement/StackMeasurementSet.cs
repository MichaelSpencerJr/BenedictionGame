using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public struct StackMeasurementSet
    {
        public BitMeasurement OneStack;
        public BitMeasurement TwoStack;
        public BitMeasurement ThreeStack;
        public BitMeasurement FourStack;
        public BitMeasurement FiveStack;

        public bool AnyPiece(Location location) => OneStack[location] || TwoStack[location] || ThreeStack[location] ||
                                                   FourStack[location] || FiveStack[location];
    }
}
