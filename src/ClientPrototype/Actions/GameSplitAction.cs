using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameSplitAction : GameTargetAction
    {
        public override string Action => "Split";

        public int Size { get; set; }

        public override string ToString() => $"{Location}-{Size}-{Target}";

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ?? CheckSize(initialState) ??
                   CheckLocationIsYours(initialState, "Split From") ??
                   CheckLocationTargetReachable(initialState, false) ??
                   CheckMergeRulesIfMerge(initialState);
        }

        public string CheckSize(State initialState)
        {
            if (Size < 1) return "Must Split At Least One Piece";

            var sourceSize = (int) (initialState[Location] & Cell.SizeMask);
            if (Size >= sourceSize) return "Must Leave At Least One Piece Behind When Splitting";
            
            return null;
        }

        public string CheckMergeRulesIfMerge(State initialState)
        {
            if (CheckTargetIsYours(initialState, string.Empty) == null)
            {
                var blessingRemovedState = initialState.DeepCopy();
                blessingRemovedState[Location] &= ~Cell.Blessed;
                return CheckMergeRules(blessingRemovedState);
            }

            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var retval = initialState.DeepCopy();
/*
 this needs to be some combination of the move logic:
                
                var kingFlag = (initialState[Location] | initialState[Target]) & Cell.King;

                var newSize = (int) (initialState[Location] & Cell.SizeMask) + (int) (initialState[Target] & Cell.SizeMask);
                retval[Location] = Cell.Empty;
                retval[Target] = (initialState[Target] & ~(Cell.Blessed | Cell.Cursed | Cell.CursePending | Cell.SizeMask)) |
                                 (Cell) newSize | kingFlag;

  and the merge logic:
                if ((initialState[Target] & Cell.King) == Cell.King)
                {
                    retval.Flags |= (initialState[Target] & Cell.SideRed) == Cell.SideRed
                        ? StateFlags.RedKingTaken
                        : StateFlags.BlueKingTaken;
                }

                retval[Target] = initialState[Location] | Cell.Locked;
                retval[Location] = Cell.Empty;
                if (CheckLocationTargetReachable(initialState, true) == null)
                {
                    //If it's possible to do the indicated move in a way that passes enemy walls, un-curse and bless the moved piece.
                    retval[Target] = (retval[Target] & ~Cell.Cursed) | Cell.Blessed;
                }
*/


                
                return retval;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}