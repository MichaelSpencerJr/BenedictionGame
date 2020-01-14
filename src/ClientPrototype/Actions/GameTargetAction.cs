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
        public Location Target { get; }

        public string CheckErrorTarget(State initialState)
        {
            if (!Movement.IsValidLocation(Target))
            {
                return "Not a Valid Move Target";
            }

            if (Location == Target)
            {
                return "Target Cannot Be Same As Initial Location";
            }

            return null;
        }

        public string CheckLocationIsYours(State initialState, string cannotBeWhat)
        {
            return CheckSpace(initialState, Location, false, true, false, "Merge Source", cannotBeWhat);
        }

        public string CheckTargetIsYours(State initialState, string cannotBeWhat)
        {
            return CheckSpace(initialState, Target, false, true, false, "Merge Target", cannotBeWhat);
        }

        public string CheckSpace(State state, Location space, bool allowEmpty, bool allowOwnColor, bool allowOtherColor, string spaceDescription, string cannotBeWhat)
        {
            if (state[space] == Cell.Blockade)
                return $"{spaceDescription} {space} Contains a Blockade, Which Cannot Be {cannotBeWhat}";

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

        public string CheckTargetEmptyOrCapture(State state, string cannotBeWhat)
        {
            return CheckSpace(state, Target, true, false, true, "Destination", cannotBeWhat);
        }

        public string CheckLocationTargetReachable(State state, bool requireWrapAround)
        {
            // Least significant four bits are the column number, mapping directly to 0=A and 8=I.
            // Most significant five bits are the number of half-rows from the top / blue side of the board.
            var (horizontalDiff, verticalDiff) = MovementVector(Location, Target);

            if ((horizontalDiff != 0 || Math.Abs(verticalDiff) % 2 == 1) &&
                Math.Abs(horizontalDiff) != Math.Abs(verticalDiff))
                return $"Movement Follows Board Lines, and No Line Connects {Location} With {Target}";

            var blueWallWrapAround = Side == ActionSide.Red;
            var redWallWrapAround = Side == ActionSide.Blue;

            var stackSize = (int) (state[Location] & Cell.SizeMask);
            var reachable = new HashSet<Location>();

            Func<Location, bool, bool, Location>[] movers;

            if (horizontalDiff == 0)
            {
                movers = new Func<Location, bool, bool, Location>[] {Movement.North, Movement.South};
            }
            else if (Math.Sign(horizontalDiff) == Math.Sign(verticalDiff))
            {
                movers = new Func<Location, bool, bool, Location>[] {Movement.SouthEast, Movement.NorthWest};
            }
            else
            {
                movers = new Func<Location, bool, bool, Location>[] {Movement.NorthEast, Movement.SouthWest};
            }

            foreach (var mover in movers)
            {
                var moveCell = Location;
                var wrapAroundSeen = false;
                for (var i = 0; i < stackSize; i++)
                {
                    try
                    {
                        var newCell = mover(moveCell, blueWallWrapAround, redWallWrapAround);
                        var vector = MovementVector(moveCell, newCell);
                        if (Math.Abs(vector.horizontal) + Math.Abs(vector.vertical) > 2)
                            wrapAroundSeen = true;
                        if (state[moveCell] == Cell.Blockade) break;
                        if (moveCell == Target && (wrapAroundSeen || !requireWrapAround)) return null;
                        reachable.Add(moveCell);
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            var cells = string.Join(", ", reachable.ToArray());
            return $"Stack Size {stackSize} Piece At {Location} Cannot Reach {Target} (but can reach: {cells})";
        }

        public static (int horizontal, int vertical) MovementVector(Location start, Location end)
        {
            return (((int) end & 0x00F) - ((int) start & 0x00F), (((int) end & 0x1F0) - ((int) start & 0x1F0)) / 16);
        }

        public string CheckMergeRules(State state)
        {
            if ((state[Location] & state[Target] & Cell.King) == Cell.King)
                return "Kings Cannot Merge With Kings";

            var hasCurse = ((state[Location] | state[Target]) & Cell.Cursed) == Cell.Cursed;
            var hasBless = ((state[Location] | state[Target]) & Cell.Blessed) == Cell.Blessed;
            var hasKing = ((state[Location] | state[Target]) & Cell.King) == Cell.King;

            if (hasCurse && !hasBless && !hasKing)
                return "Cursed Pieces Can Only Merge With Kings or Blessed Pieces";

            var fromSize = (int) (state[Location] & Cell.SizeMask);
            var toSize = (int) (state[Target] & Cell.SizeMask);

            if (fromSize + toSize > 15)
                return $"Merging Stacks Size {fromSize} and {toSize} Exceeds 15 Max";

            if (fromSize + toSize == 2 || hasKing || hasBless) return null;

            return "Blessed Piece (From Passing Opponent Wall) or King Required On Either Piece to Merge Above Stack Size Two";
        }
    }
}