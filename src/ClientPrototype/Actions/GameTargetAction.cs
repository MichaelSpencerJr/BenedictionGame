using System;
using System.Collections.Generic;
using System.Linq;
using Benediction.Board;

namespace Benediction.Actions
{
    /// <summary>
    /// Represents a single game action performed by a player which includes both a source and a target
    /// </summary>
    public abstract class GameTargetAction : GameAction
    {
        /// <summary>
        /// Represents the target board location this action is affecting or changing.
        /// </summary>
        public Location Target { get; set; }

        /// <summary>
        /// Common error checks which must performed at the start of all targeted player actions:
        /// Confirms the target exists and is not the same as the initial location
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckErrorTarget(State state)
        {
            if (!Movement.IsValidLocation(Target))
            {
                return "Please Select a Target";
            }

            if (Location == Target)
            {
                return "Please Select a Target";
            }

            return null;
        }

        /// <summary>
        /// Confirms the Location selected for the action contains a piece owned by the current player.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <param name="cannotBeWhat">Text description of what is being done, to improve error message readability</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckLocationIsYours(State state, string cannotBeWhat)
        {
            return CheckSpace(state, Location, false, true, false, "Source", cannotBeWhat);
        }

        /// <summary>
        /// Confirms the Target selected for the action contains a piece owned by the player.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <param name="cannotBeWhat">Text description of what is being done, to improve error message readability</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckTargetIsYours(State state, string cannotBeWhat)
        {
            return CheckSpace(state, Target, false, true, false, "Destination", cannotBeWhat);
        }
        
        /// <summary>
        /// Confirms the Target selected for the action is empty or contains an opposing piece
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <param name="cannotBeWhat">Text description of what is being done, to improve error message readability</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckTargetEmptyOrCapture(State state, string cannotBeWhat)
        {
            return CheckSpace(state, Target, true, false, true, "Destination", cannotBeWhat);
        }

        /// <summary>
        /// Utility function for checking whatever is in the selected board location is something which is allowed.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <param name="space">Cell on the board to examine</param>
        /// <param name="allowEmpty">If true, the examined cell is allowed to be empty.</param>
        /// <param name="allowOwnColor">If true, the examined cell is allowed to be the same color as the current player.</param>
        /// <param name="allowOtherColor">If true, the examined cell is allowed to be the opposite color as the current player.</param>
        /// <param name="spaceDescription">Location or Target</param>
        /// <param name="cannotBeWhat">Text description of what is being done, to improve error message readability</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckSpace(State state, Location space, bool allowEmpty, bool allowOwnColor, bool allowOtherColor, string spaceDescription, string cannotBeWhat)
        {
            if (state[space] == Cell.Block)
                return $"{spaceDescription} {space} Contains a Block, Which Cannot Be {cannotBeWhat}";

            if (state[space] == Cell.Empty)
            {
                return allowEmpty ? null : $"{spaceDescription} {space} is Empty and Cannot Be {cannotBeWhat}";
            }
            
            if ((state[space] & Cell.SizeMask) == 0)
                return $"{spaceDescription} {space} is Non-Empty But Zero Size and Cannot Be {cannotBeWhat}";

            var sameSide = (Side == ActionSide.Red) == ((state[space] & Cell.SideRed) == Cell.SideRed);

            if (sameSide && !allowOwnColor)
                return $"{spaceDescription} {space} Is Your Own Piece and Cannot Be {cannotBeWhat} By {Side}";
            if (!sameSide && !allowOtherColor)
                return $"{spaceDescription} {space} Is Not Your Piece and Cannot Be {cannotBeWhat} By {Side}";

            return null;
        }

        /// <summary>
        /// Checks if a move is allowed, possibly restricting to moves which pass through the enemy's wall.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <param name="requireWrapAround">If true, only returns null if the move is otherwise allowed AND
        /// if it can be done while passing through the opponent's wall.</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckLocationTargetReachable(State state, bool requireWrapAround)
        {
            // First decode the difference between the board coordinates of source and destination.
            // Least significant four bits are the column number, mapping directly to 0=A and 8=I.
            // Most significant five bits are the number of half-rows from the top / blue side of the board.
            var (horizontalDiff, verticalDiff) = MovementVector(Location, Target);

            // Valid moves ALWAYS follow the straight lines on the board, even if they pass through an enemy wall.
            // Vertical moves have no horizontal difference and move an even number of vertical spaces.
            // Diagonal moves always have the same magnitude of horizontal difference and vertical difference.
            if ((horizontalDiff != 0 || Math.Abs(verticalDiff) % 2 == 1) &&
                Math.Abs(horizontalDiff) != Math.Abs(verticalDiff))
                return $"Movement Follows Board Lines, and No Line Connects {Location} With {Target}";

            var blueWallWrapAround = Side == ActionSide.Red;
            var redWallWrapAround = Side == ActionSide.Blue;

            var stackSize = (int) (state[Location] & Cell.SizeMask);

            // Set of board locations which can be reached (for reporting to the user in case of illegal move)
            var reachable = new HashSet<Location>();

            // Holds the two possible directions the user might be moving -- to be filled in immediately below
            Func<Location, bool, bool, Location>[] movers;

            if (horizontalDiff == 0)
            {
                //This must be a vertical move, so only consider spaces reachable going north or south.
                movers = new Func<Location, bool, bool, Location>[] {Movement.North, Movement.South};
            }
            else if (Math.Sign(horizontalDiff) == Math.Sign(verticalDiff))
            {
                //This must be a northwest or southeast move, so only consider spaces reachable from those directions.
                movers = new Func<Location, bool, bool, Location>[] {Movement.SouthEast, Movement.NorthWest};
            }
            else
            {
                //This must be a northeast or southwest move, so only consider spaces reachable from those directions.
                movers = new Func<Location, bool, bool, Location>[] {Movement.NorthEast, Movement.SouthWest};
            }

            //We take advantage of a property of direct vs wrap-around moves: direct moves always have a manhattan
            //distance of exactly 2.  North/South moves vertically 2 spaces; Diagonal moves vertically 1 space and horizontally 1 space.
            //So if a single step movement bounds a manhattan distance greater than 2, the step must have wrapped around.

            foreach (var mover in movers)
            {
                var consideredCell = Location;
                var wrapAroundSeen = false;
                // Stack size controls how many spaces we can move, so progressively check straight line moves of each length.
                for (var i = 0; i < stackSize; i++)
                {
                    // test the considered move and find its movement vector
                    var newCell = mover(consideredCell, blueWallWrapAround, redWallWrapAround);
                    if (newCell == Location.Undefined) break;
                    
                    var (horizontal, vertical) = MovementVector(consideredCell, newCell);
                    consideredCell = newCell;

                    // if the last single step move has a manhattan distance over 2, this move passed through an enemy wall.
                    if (Math.Abs(horizontal) + Math.Abs(vertical) > 2)
                        wrapAroundSeen = true;

                    // illegal to move onto or through blockades, so stop considering this movement direction if we find one.
                    if (state[consideredCell] == Cell.Block) break;

                    if (consideredCell == Target && (wrapAroundSeen || !requireWrapAround)) return null;

                    // this cell is reachable but wasn't our target.  Add it to the reachable list and continue checking.
                    reachable.Add(consideredCell);
                }
            }

            // target was other than one of the reachable cells, so return an error.
            var cells = string.Join(", ", reachable.ToArray());
            return $"Stack Size {stackSize} Piece At {Location} Cannot Reach {Target} (but can reach: {cells})";
        }

        /// <summary>
        /// Gets the movement vector in board coordinates between start and end locations.
        /// </summary>
        /// <param name="start">Location of movement start</param>
        /// <param name="end">Location of movement end</param>
        /// <returns>Tuple of integer position offsets, horizontal and vertical</returns>
        public static (int horizontal, int vertical) MovementVector(Location start, Location end)
        {
            return (((int) end & 0x00F) - ((int) start & 0x00F), (((int) end & 0x1F0) - ((int) start & 0x1F0)) / 16);
        }

        /// <summary>
        /// Confirms two pieces which intend to merge are allowed to merge.
        /// </summary>
        /// <param name="state">Game state to check</param>
        /// <returns>Null if the move is allowed, or a brief text explanation of why it cannot be performed</returns>
        public string CheckMergeRules(State state)
        {
            if ((state[Location] & state[Target] & Cell.King) == Cell.King)
                return "Kings Cannot Merge With Kings";

            var hasCurse = ((state[Location] | state[Target]) & Cell.Cursed) == Cell.Cursed;
            var hasBless = ((state[Location] | state[Target]) & Cell.Blessed) == Cell.Blessed;

            if (hasCurse && !hasBless)
                return "Cursed Pieces Can Only Merge With Blessed Pieces";

            var fromSize = (int) (state[Location] & Cell.SizeMask);
            var toSize = (int) (state[Target] & Cell.SizeMask);

            if (fromSize + toSize > 15)
                return $"Merging Stacks Size {fromSize} and {toSize} Exceeds 15 Max";

            if (fromSize + toSize == 2 || hasBless) return null;

            return "Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two";
        }

        /// <summary>
        /// Applies a known-legal movement, moving a piece onto an empty (or opponent-owned) cell
        /// </summary>
        /// <param name="initialState">State before the move</param>
        /// <param name="finalState">State after the move</param>
        public void ApplyMove(State initialState, State finalState)
        {
            //This function is not used for merges, so if the target piece is a king then this is a game-ending king capture!
            if ((initialState[Target] & Cell.King) == Cell.King)
            {
                //Set the appropriate KingTaken flag
                finalState.Flags |= (initialState[Target] & Cell.SideRed) == Cell.SideRed
                    ? StateFlags.RedKingTaken
                    : StateFlags.BlueKingTaken;
            }

            //Copy the Location piece to the Target location, overwriting what may have been there.  Also lock that piece against moving again this turn.
            finalState[Target] = finalState[Location] | Cell.Locked;

            //Clear the location where the moved piece came from.
            finalState[Location] = Cell.Empty;

            //If the moved piece went through the opponent's wall, apply a blessing.
            ApplyWallWrapAroundBlessing(initialState, finalState);
        }

        /// <summary>
        /// Applies a known-legal merge, adding pieces onto an existing piece or stack owned by the same player.
        /// </summary>
        /// <param name="initialState">State before the merge</param>
        /// <param name="finalState">State after the merge</param>
        public void ApplyMerge(State initialState, State finalState)
        {
            //if either merged piece is a king then the resulting piece is also a king.
            //also, preserve the side of the original pieces
            var kingAndSideFlags = (initialState[Location] | initialState[Target]) & (Cell.King | Cell.SideRed);

            //sum the sizes of the two merging pieces
            var newSize = (int) (initialState[Location] & Cell.SizeMask) + (int) (initialState[Target] & Cell.SizeMask);
            
            //remove the pieces from the source location
            finalState[Location] = Cell.Empty;

            //create a new merged piece from the new size and any king or side flags from the original pieces.
            finalState[Target] = (Cell) newSize | kingAndSideFlags;

            //if the merge target was through an enemy wall, bless the new merged piece
            ApplyWallWrapAroundBlessing(initialState, finalState);
        }

        /// <summary>
        /// If the moved piece isn't cursed, check if the proposed move could be done by passing through the enemy wall.
        /// If it isn't cursed and it could be done that way (even if it could also be done without passing through) then bless the piece.
        /// </summary>
        /// <param name="initialState">State before the move</param>
        /// <param name="finalState">State after the move</param>
        public void ApplyWallWrapAroundBlessing(State initialState, State finalState)
        {
            if ((finalState[Target] | Cell.Cursed) == Cell.Cursed) return;

            if (CheckLocationTargetReachable(initialState, true) == null)
            {
                finalState[Target] |= Cell.Blessed;
            }
        }
    }
}