using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board.Measurement;

namespace Benediction.Board
{
    public struct MeasuredState
    {
        public State State;
        public BitMeasurement Blocks;
        public StackTypeMeasurementSet RedProject1;
        public StackTypeMeasurementSet RedProject2;
        public StackTypeMeasurementSet RedProject3;
        public StackTypeMeasurementSet BlueProject1;
        public StackTypeMeasurementSet BlueProject2;
        public StackTypeMeasurementSet BlueProject3;
        public NibbleMeasurement RedConnectedRegions;
        public NibbleMeasurement BlueConnectedRegions;
        public StackMeasurementSet RedConnectGaps;
        public StackMeasurementSet BlueConnectGaps;
    }
}
