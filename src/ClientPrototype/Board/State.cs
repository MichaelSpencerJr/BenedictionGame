using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace Benediction.Board
{
    /// <summary>
    /// Represents a snapshot of a game board, with all of its pieces.
    /// </summary>
    public class State : Dictionary<Location, Cell>
    {
        public static readonly Location[] AllBoardLocations =
        {
            Location.A1, Location.A2, Location.A3, Location.A4, Location.A5, Location.B1,
            Location.B2, Location.B3, Location.B4, Location.B5, Location.B6, Location.C1,
            Location.C2, Location.C3, Location.C4, Location.C5, Location.C6, Location.C7,
            Location.D1, Location.D2, Location.D3, Location.D4, Location.D5, Location.D6,
            Location.D7, Location.D8, Location.E1, Location.E2, Location.E3, Location.E4,
            Location.E5, Location.E6, Location.E7, Location.E8, Location.E9, Location.F1,
            Location.F2, Location.F3, Location.F4, Location.F5, Location.F6, Location.F7,
            Location.F8, Location.G1, Location.G2, Location.G3, Location.G4, Location.G5,
            Location.G6, Location.G7, Location.H1, Location.H2, Location.H3, Location.H4,
            Location.H5, Location.H6, Location.I1, Location.I2, Location.I3, Location.I4,
            Location.I5,
        };

        public static readonly Location[] RedWallAdjacentLocations =
        {
            Location.A1, Location.B1, Location.C1, Location.D1, Location.E1, Location.F1, Location.G1, Location.H1,
            Location.I1
        };

        public static readonly Location[] BlueWallAdjacentLocations =
        {
            Location.A5, Location.B6, Location.C7, Location.D8, Location.E9, Location.F8, Location.G7, Location.H6,
            Location.I5
        };

        /// <summary>
        /// Board state checksum, for indexing specific boards and for computing a checksum on decoded boards to confirm validity.
        /// </summary>
        public Guid BoardId
        {
            get
            {
                var hash = _hasher.ComputeHash(GetBuffer());
                return new Guid(new[]
                {
                    (byte) (hash[0] ^ hash[16]),
                    (byte) (hash[1] ^ hash[17]),
                    (byte) (hash[2] ^ hash[18]),
                    (byte) (hash[3] ^ hash[19]),
                    (byte) (hash[4] ^ hash[20]),
                    (byte) (hash[5] ^ hash[21]),
                    (byte) (hash[6] ^ hash[22]),
                    (byte) (hash[7] ^ hash[23]),
                    (byte) (hash[8] ^ hash[24]),
                    (byte) (hash[9] ^ hash[25]),
                    (byte) (hash[10] ^ hash[26]),
                    (byte) (hash[11] ^ hash[27]),
                    (byte) (hash[12] ^ hash[28]),
                    (byte) (hash[13] ^ hash[29]),
                    (byte) (hash[14] ^ hash[30]),
                    (byte) (hash[15] ^ hash[31]),
                });
            }
        }

        /// <summary>
        /// Location of red home space, if set
        /// </summary>
        public Location RedHome { get; set; }

        /// <summary>
        /// Location of blue home space, if set
        /// </summary>
        public Location BlueHome { get; set; }

        /// <summary>
        /// Game state flags indicating win/lose conditions and what move happens next
        /// </summary>
        public StateFlags Flags { get; set; }

        private static SHA256 _hasher = SHA256.Create();

        /// <summary>
        /// Creates an empty BoardState with no homes or pieces
        /// </summary>
        public State() : base(AllBoardLocations.Length)
        {
            foreach (var key in AllBoardLocations)
            {
                this[key] = Cell.Empty;
            }
        }

        /// <summary>
        /// Decodes a BoardState from provided input bytes
        /// </summary>
        /// <param name="boardBuffer">127-byte buffer containing board data</param>
        public State(byte[] boardBuffer) : base(AllBoardLocations.Length)
        {
            if (boardBuffer == null)
            {
                throw new ArgumentNullException(nameof(boardBuffer), "Board state byte array must not be null.");
            }

            if (boardBuffer.Length != AllBoardLocations.Length * 2 + 5)
            {
                throw new ArgumentOutOfRangeException(nameof(boardBuffer), boardBuffer.Length,
                    $"Expected {AllBoardLocations.Length * 2 + 5} byte array for board info, got {boardBuffer.Length} bytes.");
            }

            for (var i = 0; i < AllBoardLocations.Length * 2; i += 2)
            {
                this[AllBoardLocations[i / 2]] = (Cell) BitConverter.ToUInt16(boardBuffer, i);
            }

            RedHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length * 2);
            BlueHome = (Location) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length * 2 + 2);
            Flags = (StateFlags) boardBuffer[AllBoardLocations.Length * 2 + 4];
        }

        /// <summary>
        /// Decodes a board from provided base-64-encoded gzipped text, like from a forum post.  Also checks an included checksum and throws an exception if the data doesn't match the checksum.
        /// </summary>
        /// <param name="base64Gz">Base 64 encoded board data</param>
        /// <returns>Decoded board</returns>
        public static State FromBase64Gz(string base64Gz)
        {
            byte[] decompressedBytes;
            using (var output = new MemoryStream())
            {
                using (var gzBytes = new MemoryStream(Convert.FromBase64String(base64Gz)))
                using (var decompressor = new GZipStream(gzBytes, CompressionMode.Decompress))
                {
                    decompressor.CopyTo(output);
                }

                decompressedBytes = output.ToArray();
            }

            if (decompressedBytes.Length != AllBoardLocations.Length * 2 + 21)
            {
                throw new ArgumentException("Decoded bytes were not of correct length", nameof(base64Gz));
            }

            var boardBytes = new byte[AllBoardLocations.Length * 2 + 5];
            var checksumBytes = new byte[16];
            Array.ConstrainedCopy(decompressedBytes, 0, boardBytes, 0, boardBytes.Length);
            Array.ConstrainedCopy(decompressedBytes, AllBoardLocations.Length * 2 + 5, checksumBytes, 0, 16);
            var encodedChecksum = new Guid(checksumBytes);
            var decodedBoard = new State(boardBytes);

            if (encodedChecksum != decodedBoard.BoardId)
            {
                throw new ArgumentException("Checksum failure in decoded bytes -- not a Benediction board?",
                    nameof(base64Gz));
            }

            return decodedBoard;
        }

        /// <summary>
        /// Encodes the current board information as bytes
        /// </summary>
        /// <returns>127-byte buffer describing the game board</returns>
        public byte[] GetBuffer()
        {
            var retval = new byte[AllBoardLocations.Length * 2 + 5];

            for (var i = 0; i < AllBoardLocations.Length * 2; i += 2)
            {
                var bytes = BitConverter.GetBytes(Convert.ToUInt16(this[AllBoardLocations[i / 2]]));
                Array.ConstrainedCopy(bytes, 0, retval, i, 2);
            }

            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) RedHome), 0, retval, AllBoardLocations.Length * 2, 2);
            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) BlueHome), 0, retval, AllBoardLocations.Length * 2 + 2,
                2);
            retval[AllBoardLocations.Length * 2 + 4] = (byte) Flags;

            return retval;
        }

        /// <summary>
        /// Encodes the current board information as base64-encoded gzipped text.
        /// </summary>
        /// <returns>Base64-encoded gzipped text</returns>
        public string GetBase64()
        {
            using (var output = new MemoryStream())
            {
                var inputBytes = new byte[AllBoardLocations.Length * 2 + 21];
                Array.ConstrainedCopy(GetBuffer(), 0, inputBytes, 0, AllBoardLocations.Length * 2 + 5);
                Array.ConstrainedCopy(BoardId.ToByteArray(), 0, inputBytes, AllBoardLocations.Length * 2 + 5, 16);
                using (var input = new MemoryStream(inputBytes))
                using (var compressor = new GZipStream(output, CompressionLevel.Optimal, true))
                {
                    input.CopyTo(compressor);
                }

                return Convert.ToBase64String(output.ToArray());
            }
        }

        /// <summary>
        /// Returns a deep copy (duplicated object with different address, which can be edited without accidentally modifying the original)
        /// of the current game board.
        /// </summary>
        /// <returns>Deep copy of current game board</returns>
        public State DeepCopy()
        {
            return new State(GetBuffer());
        }
    }
}