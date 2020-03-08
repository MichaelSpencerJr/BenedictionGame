using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public class ProjectedMove
    {
        public Location From { get; set; }
        public Location To { get; set; }
        public int Size { get; set; }
        public bool Wrap { get; set; }
    }
}
