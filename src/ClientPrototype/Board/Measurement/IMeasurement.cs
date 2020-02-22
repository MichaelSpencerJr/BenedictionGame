using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    interface IMeasurement<T> where T: struct
    {
        T this[Location location] { get; set; }
    }
}
