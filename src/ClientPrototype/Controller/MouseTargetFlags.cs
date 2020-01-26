using System;

namespace Benediction.Controller
{
    [Flags]
    public enum MouseTargetFlags
    {
        None = 0,
        Target = 0x01,
        Selection = 0x02,
        OwnPiece = 0x04,
        OpponentPiece = 0x08,
        Stack = 0x10,
    }
}