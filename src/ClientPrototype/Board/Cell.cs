using System;

namespace Benediction.Board
{
    /// <summary>Current state of a cell on the game board</summary>
    [Flags]
    public enum Cell : ushort
    {
        /// <summary>0 indicates empty cell</summary>
        Empty = 0,

        Size1 = 0x0001,
        Size2 = 0x0002,
        Size4 = 0x0004,
        Size8 = 0x0008,

        /// <summary>First four bits indicate number of pieces in the stack, 1-15</summary>
        SizeMask = 0x000F,

        /// <summary>Block when SizeMask bits are zero (empty stack) and this bit is set</summary>
        Block = 0x0010,

        /// <summary>Red-side piece when set, Blue-side piece when unset.</summary>
        SideRed = 0x0020,

        /// <summary>Blessed piece when set</summary>
        Blessed = 0x0040,

        /// <summary>Curse possible unless blessed before end of turn</summary>
        CursePending = 0x0080,

        /// <summary>Cursed piece when set</summary>
        Cursed = 0x0100,

        /// <summary>King piece when set</summary>
        King = 0x0200,

        /// <summary>Piece has been moved this turn and cannot be moved again when set</summary>
        Locked = 0x0400,
    }
}
