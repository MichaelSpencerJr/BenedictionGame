using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board
{
    public static class CellExtensionMethods
    {
        /// <summary>
        /// Checks if the cell contains a piece (non-zero size)
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell contains a piece, false if empty or blocked</returns>
        public static bool IsPiece(this Cell cell) => (cell & Cell.SizeMask) > 0;

        /// <summary>
        /// Checks if the cell contains a stack (size greater than one)
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell contains a stack, false if empty, a single piece, or blocked</returns>
        public static bool IsStack(this Cell cell) =>
            cell.HasFlag(Cell.Size2) || cell.HasFlag(Cell.Size4) || cell.HasFlag(Cell.Size8);

        /// <summary>
        /// Checks if the cell is empty
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell is empty, false if it contains a piece or is blocked</returns>
        public static bool IsEmpty(this Cell cell) => cell == Cell.Empty;

        /// <summary>
        /// Checks if the cell contains a block
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell is blocked, false if it contains a piece or is empty</returns>
        public static bool IsBlock(this Cell cell) => cell == Cell.Block;
        
        /// <summary>
        /// Checks if the cell contains a red piece (non-zero size)
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell contains a piece which is red</returns>
        public static bool RedPiece(this Cell cell) => (cell & Cell.SizeMask) > 0 && cell.HasFlag(Cell.SideRed);
        
        /// <summary>
        /// Checks if the cell contains a blue piece (non-zero size)
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if the cell contains a piece which is blue</returns>
        public static bool BluePiece(this Cell cell) => (cell & Cell.SizeMask) > 0 && !cell.HasFlag(Cell.SideRed);

        /// <summary>
        /// Updates the size value of the cell to the provided size value.
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="size">New size value, 1-15</param>
        public static Cell SetSize(this Cell cell, int size) => (cell & ~Cell.SizeMask) | ((Cell) size & Cell.SizeMask);

        /// <summary>
        /// Gets the size value of the provided cell
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>Integer size value, 0-15</returns>
        public static int GetSize(this Cell cell) => (int)(cell & Cell.SizeMask);
     
        /// <summary>
        /// Adds pieces to the size of the current stack of pieces
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="add">Number of pieces to add</param>
        public static Cell AddSize(this Cell cell, int add) => cell.SetSize(cell.GetSize() + add);
   
        /// <summary>
        /// Adds the pieces found in the provided cell to the size of the current stack of pieces
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="add">Cell containing pieces to add, which remains unchanged after the add</param>
        public static Cell  AddSize(this Cell cell, Cell add) => cell.SetSize(cell.GetSize() + add.GetSize());

        /// <summary>
        /// Subtracts pieces from the size of the current stack of pieces
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="subtract">Number of pieces to remove</param>
        public static Cell SubtractSize(this Cell cell, int subtract) => cell.SetSize(cell.GetSize() - subtract);
     
        /// <summary>
        /// Subtracts the pieces found in the provided cell from the size of the current stack of pieces
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="subtract">Cell containing pieces to remove, which remains unchanged after the removal</param>
        public static Cell SubtractSize(this Cell cell, Cell subtract) => cell.SetSize(cell.GetSize() - subtract.GetSize());

        /// <summary>
        /// Returns a provided object indicating if the provided cell contains a red piece, a blue piece, or no piece
        /// </summary>
        /// <typeparam name="T">Provided object type to return</typeparam>
        /// <param name="cell">Cell to check</param>
        /// <param name="valueIfRed">Value to return if the provided cell contains a red piece</param>
        /// <param name="valueIfBlue">Value to return if the provided cell contains a blue piece</param>
        /// <param name="valueIfNeither">Value to return if the provided cell doesn't contain a piece -- is empty or blocked</param>
        /// <returns>One of the provided values to return</returns>
        public static T GetSide<T>(this Cell cell, T valueIfRed, T valueIfBlue, T valueIfNeither) =>
            cell.RedPiece() ? valueIfRed : cell.BluePiece() ? valueIfBlue : valueIfNeither;

        /// <summary>
        /// Sets updated flag values according to named parameters
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="blessed">True or false to update <seealso cref="Cell.Blessed"/> flag, default or null to leave value alone</param>
        /// <param name="cursed">True or false to update <seealso cref="Cell.Cursed"/> flag, default or null to leave value alone</param>
        /// <param name="cursePending">True or false to update <seealso cref="Cell.CursePending"/> flag, default or null to leave value alone</param>
        /// <param name="king">True or false to update <seealso cref="Cell.King"/> flag, default or null to leave value alone</param>
        /// <param name="locked">True or false to update <seealso cref="Cell.Locked"/> flag, default or null to leave value alone</param>
        /// <param name="size">True or false to update cell size, default or null to leave value alone</param>
        public static Cell SetFlags(this Cell cell, bool? blessed = null, bool? cursed = null, bool? cursePending = null, bool? king = null, bool? locked = null, int? size = null)
        {
            if (blessed.HasValue) cell = cell.SetFlag(Cell.Blessed, blessed.Value);
            if (cursed.HasValue) cell = cell.SetFlag(Cell.Cursed, cursed.Value);
            if (cursePending.HasValue) cell = cell.SetFlag(Cell.CursePending, cursePending.Value);
            if (king.HasValue) cell = cell.SetFlag(Cell.King, king.Value);
            if (locked.HasValue) cell = cell.SetFlag(Cell.Locked, locked.Value);
            if (size.HasValue) cell = cell.SetSize(size.Value);
            return cell;
        }

        /// <summary>
        /// Sets updated flag value according to provided flag and truth value
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="flag">Flag value to set or clear</param>
        /// <param name="value">True to set, false to clear</param>
        public static Cell SetFlag(this Cell cell, Cell flag, bool value) => value ? cell | flag : cell & ~flag;

        /// <summary>
        /// Checks value of <seealso cref="Cell.Blessed"/> flag
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if <seealso cref="Cell.Blessed"/></returns>
        public static bool IsBlessed(this Cell cell) => cell.HasFlag(Cell.Blessed);
    
        /// <summary>
        /// Checks value of <seealso cref="Cell.Cursed"/> flag
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if <seealso cref="Cell.Cursed"/></returns>
        public static bool IsCursed(this Cell cell) => cell.HasFlag(Cell.Cursed);
        
        /// <summary>
        /// Checks value of <seealso cref="Cell.CursePending"/> flag
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if <seealso cref="Cell.CursePending"/></returns>
        public static bool IsCursePending(this Cell cell) => cell.HasFlag(Cell.CursePending);
        
        /// <summary>
        /// Checks value of <seealso cref="Cell.King"/> flag
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if <seealso cref="Cell.King"/></returns>
        public static bool IsKing(this Cell cell) => cell.HasFlag(Cell.King);
        
        /// <summary>
        /// Checks value of <seealso cref="Cell.Locked"/> flag
        /// </summary>
        /// <param name="cell">Cell to check</param>
        /// <returns>True if <seealso cref="Cell.Locked"/></returns>
        public static bool IsLocked(this Cell cell) => cell.HasFlag(Cell.Locked);
        
        /// <summary>
        /// Updates value of <seealso cref="Cell.Blessed"/> flag
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="value">True to set flag, false to clear</param>
        public static Cell Blessed(this Cell cell, bool value) => cell.SetFlag(Cell.Blessed, value);
        
        /// <summary>
        /// Updates value of <seealso cref="Cell.Cursed"/> flag
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="value">True to set flag, false to clear</param>
        public static Cell Cursed(this Cell cell, bool value) => cell.SetFlag(Cell.Cursed, value);
        
        /// <summary>
        /// Updates value of <seealso cref="Cell.CursePending"/> flag
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="value">True to set flag, false to clear</param>
        public static Cell CursePending(this Cell cell, bool value) => cell.SetFlag(Cell.CursePending, value);
        
        /// <summary>
        /// Updates value of <seealso cref="Cell.King"/> flag
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="value">True to set flag, false to clear</param>
        public static Cell King(this Cell cell, bool value) => cell.SetFlag(Cell.King, value);
        
        /// <summary>
        /// Updates value of <seealso cref="Cell.Locked"/> flag
        /// </summary>
        /// <param name="cell">Cell to update</param>
        /// <param name="value">True to set flag, false to clear</param>
        public static Cell Locked(this Cell cell, bool value) => cell.SetFlag(Cell.Locked, value);

        /// <summary>
        /// Clears <seealso cref="Cell.CursePending"/> flag if set, and applies <seealso cref="Cell.Cursed"/>
        /// only if the cell wasn't already <seealso cref="Cell.Blessed"/>.
        /// </summary>
        /// <param name="cell">Cell to update</param>
        public static Cell HandleCursePending(this Cell cell) =>
            cell.SetFlags(cursed: cell.IsCursed() || cell.IsCursePending() && !cell.IsBlessed() && !cell.IsKing(), cursePending: false);
    }
}
