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
                blessingRemovedState[Location] &= ~(Cell.Blessed | Cell.SizeMask);
                blessingRemovedState[Location] |= (Cell)Size;
                return CheckMergeRules(blessingRemovedState);
            }

            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var finalState = initialState.DeepCopy();

                //Modify the source piece so it contains only the part that's being moved or merged.
                //Afterward we'll place a new CursePending piece with the remaining size.
                var remainingSize = (int) (initialState[Location] & Cell.SizeMask) - Size;

                finalState[Location] &= ~(Cell.Blessed | Cell.SizeMask);
                finalState[Location] |= (Cell)Size;

                if (CheckTargetIsYours(initialState, string.Empty) == null)
                {
                    ApplyMerge(initialState, finalState);
                }
                else
                {
                    ApplyMove(initialState, finalState);
                }

                finalState[Location] =
                    (initialState[Location] & ~(Cell.SizeMask | Cell.Locked)) | (Cell) remainingSize | Cell.CursePending;

                finalState[Target] |= Cell.CursePending;

                return finalState;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}