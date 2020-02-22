using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameSplitAction : GameTargetAction
    {
        public override string Action => "Split";

        public override int Size { get; set; }

        public override string ToString() => $"{Location.ToString().ToLower()}-{Size}-{Target.ToString().ToLower()}";

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ?? CheckSize(initialState) ??
                   CheckLocationIsYours(initialState, "Split From") ??
                   CheckLocationTargetReachable(initialState, false, Size) ??
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
                initialState[Location] = initialState[Location].SetSize(Size);
                return CheckMergeRules(initialState);
            }

            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var remainingSize = initialState[Location].GetSize() - Size;

                //Remove blessings and set size to just what's being moved/merged.  King or curse flags remain.
                initialState[Location] = initialState[Location].Blessed(false).SetSize(Size);
                //eventually remainingSize will be put here, but first we need to use this space as if it's a smaller full-move piece

                if (CheckTargetIsYours(initialState, string.Empty) == null)
                {
                    //Location still has king, curse, and size info
                    var mergeState = ApplyMerge(initialState, Size);
                    //Now that the split-away part has been used for a full move or merge, put the left-behind part where it should be.
                    mergeState[Location] = initialState[Location].Blessed(false).Cursed(false).CursePending(false).Locked(false).SetSize(remainingSize);

                    return mergeState;
                }

                var moveState = ApplyMove(initialState, Size);
                moveState[Target] = moveState[Target].CursePending(true);
                //Now that the split-away part has been used for a full move or merge, put the left-behind part where it should be.
                moveState[Location] = initialState[Location].Blessed(false).Locked(false).CursePending(true).SetSize(remainingSize);
                return moveState;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}