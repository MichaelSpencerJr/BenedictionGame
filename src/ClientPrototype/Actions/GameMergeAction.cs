using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameMergeAction : GameTargetAction
    {
        public override string Action => "Merge";

        public override string ToString() => $"{Location.ToString().ToLower()}+{Target.ToString().ToLower()}";
 
        public override int Size
        {
            get => 16;
            set { }
        }

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ??
                   CheckLocationIsYours(initialState, "Merged") ?? CheckTargetIsYours(initialState, "Merged") ??
                   CheckLocationTargetReachable(initialState, false, initialState[Location].GetSize()) ??
                   CheckMergeRules(initialState);
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var retval = initialState.DeepCopy();

                ApplyMerge(initialState, retval, initialState[Location].GetSize());

                return retval;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}