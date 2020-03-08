using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public struct StackTypeMeasurementSet
    {
        public StackMeasurementSet Normal;
        public StackMeasurementSet Blessed;
        public StackMeasurementSet Cursed;
        public StackMeasurementSet King;

        public bool AnyPiece(Location location) => Normal.AnyPiece(location) || Blessed.AnyPiece(location) ||
                                                   Cursed.AnyPiece(location) || King.AnyPiece(location);

        public bool AnyOneStack(Location location) => Normal.OneStack[location] || Blessed.OneStack[location] ||
                                                      Cursed.OneStack[location] || King.OneStack[location];

        public bool AnyTwoStack(Location location) => Normal.TwoStack[location] || Blessed.TwoStack[location] ||
                                                      Cursed.TwoStack[location] || King.TwoStack[location];

        public bool AnyThreeStack(Location location) => Normal.ThreeStack[location] || Blessed.ThreeStack[location] ||
                                                      Cursed.ThreeStack[location] || King.ThreeStack[location];

        public bool AnyFourStack(Location location) => Normal.FourStack[location] || Blessed.FourStack[location] ||
                                                      Cursed.FourStack[location] || King.FourStack[location];

        public bool AnyFiveStack(Location location) => Normal.FiveStack[location] || Blessed.FiveStack[location] ||
                                                      Cursed.FiveStack[location] || King.FiveStack[location];
    }
}
