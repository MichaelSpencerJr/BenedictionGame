using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction
{
    /// <summary>
    /// Encodes a board location as a nine bit X-Y coordinate on a hex board.
    /// Least significant four bits are the column number, mapping directly to 0=A and 8=I.
    /// Most significant five bits are the number of half-rows from the top / blue side of the board.
    /// The top-most position, E9, is row 0.  Row 1 has spaces in columns D and F but not E.
    /// Row 2 has spaces in columns C, E, and G, but not in D or F.
    /// The bottom-most position, E1, is row 16.
    /// </summary>
    public enum BoardLocation : ushort
    {
        Undefined = 0,
        A1 = 0xC0,
        A2 = 0xA0,
        A3 = 0x80,
        A4 = 0x60,
        A5 = 0x40,
        B1 = 0xD1,
        B2 = 0xB1,
        B3 = 0x91,
        B4 = 0x71,
        B5 = 0x51,
        B6 = 0x31,
        C1 = 0xE2,
        C2 = 0xC2,
        C3 = 0xA2,
        C4 = 0x82,
        C5 = 0x62,
        C6 = 0x42,
        C7 = 0x22,
        D1 = 0xF3,
        D2 = 0xD3,
        D3 = 0xB3,
        D4 = 0x93,
        D5 = 0x73,
        D6 = 0x53,
        D7 = 0x33,
        D8 = 0x13,
        E1 = 0x104,
        E2 = 0xE4,
        E3 = 0xC4,
        E4 = 0xA4,
        E5 = 0x84,
        E6 = 0x64,
        E7 = 0x44,
        E8 = 0x24,
        E9 = 0x04,
        F1 = 0xF5,
        F2 = 0xD5,
        F3 = 0xB5,
        F4 = 0x95,
        F5 = 0x75,
        F6 = 0x55,
        F7 = 0x35,
        F8 = 0x15,
        G1 = 0xE6,
        G2 = 0xC6,
        G3 = 0xA6,
        G4 = 0x86,
        G5 = 0x66,
        G6 = 0x46,
        G7 = 0x26,
        H1 = 0xD7,
        H2 = 0xB7,
        H3 = 0x97,
        H4 = 0x77,
        H5 = 0x57,
        H6 = 0x37,
        I1 = 0xC8,
        I2 = 0xA8,
        I3 = 0x88,
        I4 = 0x68,
        I5 = 0x48
    }
}
