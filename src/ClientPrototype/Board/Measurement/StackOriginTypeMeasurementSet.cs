using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board.Measurement
{
    public class StackOriginTypeMeasurementSet
    {

    }

    public enum StackOriginKind : byte
    {
        /// <summary>Piece ID is a 'root' piece which currently exists on the board in the current form.</summary>
        CurrentPiece,

        /// <summary>Piece ID is the 'left behind' part of a split operation.</summary>
        SplitRemnantOf,
        
        /// <summary>Piece ID is the 'moved away' part of a split operation.</summary>
        SplitProductOf,
        
        /// <summary>Piece ID is the combination of two previous whole pieces</summary>
        MergeOf,

        /// <summary>Piece ID is the combination of the 'moved away' part of a split operation plus another piece to merge with</summary>
        SplitMergeOf,
    }
}
