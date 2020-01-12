using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction
{
    [Flags]
    public enum BoardStateFlags : byte
    {
        /// <summary>Unset - invalid</summary>
        Undefined = 0,

        /// <summary>Game is ready for Red to take their first action</summary>
        RedAction1 = 0x01,

        /// <summary>Game is ready for Red to take their second action</summary>
        RedAction2 = 0x02,

        /// <summary>Game is ready for Blue to take their first action</summary>
        BlueAction1 = 0x04,

        /// <summary>Game is ready for Blue to take their second action</summary>
        BlueAction2 = 0x08,

        /// <summary>A red king has been taken and removed from the board</summary>
        RedKingTaken = 0x10,

        /// <summary>A blue king has been taken and removed from the board</summary>
        BlueKingTaken = 0x20,

        /// <summary>The game is over and Red has won</summary>
        RedWin = 0x40,

        /// <summary>The game is over and Blue has won</summary>
        BlueWin = 0x80
    }
}
