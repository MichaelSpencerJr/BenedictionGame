using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction
{
    /// <summary>Current state of a cell on the game board</summary>
    [Flags]
    public enum BoardCell
    {
        /// <summary>Unset value -- invalid</summary>
        Undefined = 0,

        /// <summary>First ten bits indicate number of pieces in the stack, 1-63</summary>
        SizeMask = 0x3F,

        /// <summary>Red-side piece when set</summary>
        SideRed = 0x40,

        /// <summary>Blue-side piece when set</summary>
        SideBlue = 0x80,

        /// <summary>Blessed piece when set</summary>
        Blessed = 0x100,

        /// <summary>Cursed piece when set</summary>
        Cursed = 0x200,

        /// <summary>King piece when set</summary>
        King = 0x400
    }
}
