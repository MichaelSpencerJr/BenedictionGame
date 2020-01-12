using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO.Compression;

namespace Benediction
{
    /// <summary>
    /// Represents a snapshot of a game board, with all of its pieces.
    /// </summary>
    public class BoardState : Dictionary<BoardLocation, BoardCell>
    {
        public static readonly BoardLocation[] AllBoardLocations =
        {
            BoardLocation.A1, BoardLocation.A2, BoardLocation.A3, BoardLocation.A4, BoardLocation.A5, BoardLocation.B1,
            BoardLocation.B2, BoardLocation.B3, BoardLocation.B4, BoardLocation.B5, BoardLocation.B6, BoardLocation.C1,
            BoardLocation.C2, BoardLocation.C3, BoardLocation.C4, BoardLocation.C5, BoardLocation.C6, BoardLocation.C7,
            BoardLocation.D1, BoardLocation.D2, BoardLocation.D3, BoardLocation.D4, BoardLocation.D5, BoardLocation.D6,
            BoardLocation.D7, BoardLocation.D8, BoardLocation.E1, BoardLocation.E2, BoardLocation.E3, BoardLocation.E4,
            BoardLocation.E5, BoardLocation.E6, BoardLocation.E7, BoardLocation.E8, BoardLocation.E9, BoardLocation.F1,
            BoardLocation.F2, BoardLocation.F3, BoardLocation.F4, BoardLocation.F5, BoardLocation.F6, BoardLocation.F7,
            BoardLocation.F8, BoardLocation.G1, BoardLocation.G2, BoardLocation.G3, BoardLocation.G4, BoardLocation.G5,
            BoardLocation.G6, BoardLocation.G7, BoardLocation.H1, BoardLocation.H2, BoardLocation.H3, BoardLocation.H4,
            BoardLocation.H5, BoardLocation.H6, BoardLocation.I1, BoardLocation.I2, BoardLocation.I3, BoardLocation.I4,
            BoardLocation.I5,
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
        public BoardLocation RedHome { get; set; }

        /// <summary>
        /// Location of blue home space, if set
        /// </summary>
        public BoardLocation BlueHome { get; set; }

        /// <summary>
        /// Game state flags indicating win/lose conditions and what move happens next
        /// </summary>
        public BoardStateFlags Flags { get; set; }

        private static SHA256 _hasher = SHA256.Create();

        /// <summary>
        /// Creates an empty BoardState with no homes or pieces
        /// </summary>
        public BoardState() : base(AllBoardLocations.Length)
        {
            foreach (var key in AllBoardLocations)
            {
                this[key] = BoardCell.Empty;
            }
        }

        /// <summary>
        /// Decodes a BoardState from provided input bytes
        /// </summary>
        /// <param name="boardBuffer">127-byte buffer containing board data</param>
        public BoardState(byte[] boardBuffer) : base(AllBoardLocations.Length)
        {
            if (boardBuffer == null)
            {
                throw new ArgumentNullException(nameof(boardBuffer), "Board state byte array must not be null.");
            }

            if (boardBuffer.Length != AllBoardLocations.Length * 2 + 5)
            {
                throw new ArgumentOutOfRangeException(nameof(boardBuffer), boardBuffer.Length,
                    $"Expected {AllBoardLocations.Length + 5} byte array for board info, got {boardBuffer.Length} bytes.");
            }

            for (var i = 0; i < AllBoardLocations.Length * 2; i += 2)
            {
                this[AllBoardLocations[i / 2]] = (BoardCell) BitConverter.ToUInt16(boardBuffer, i);
            }

            RedHome = (BoardLocation) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length);
            BlueHome = (BoardLocation) BitConverter.ToUInt16(boardBuffer, AllBoardLocations.Length + 2);
            Flags = (BoardStateFlags) boardBuffer[AllBoardLocations.Length + 4];
        }

        /// <summary>
        /// Decodes a board from provided base-64-encoded gzipped text, like from a forum post.  Also checks an included checksum and throws an exception if the data doesn't match the checksum.
        /// </summary>
        /// <param name="base64Gz">Base 64 encoded board data</param>
        /// <returns>Decoded board</returns>
        public static BoardState FromBase64Gz(string base64Gz)
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
            var decodedBoard = new BoardState(boardBytes);

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
            Array.ConstrainedCopy(BitConverter.GetBytes((ushort) BlueHome), 0, retval, AllBoardLocations.Length * 2 + 2, 2);
            retval[AllBoardLocations.Length * 2 + 4] = (byte)Flags;

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
    }
}
