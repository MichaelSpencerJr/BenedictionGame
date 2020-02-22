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

        public override State Apply(State state)
        {
            var error = CheckError(state);

            if (string.IsNullOrEmpty(error))
            {
                var retval = state;

                return ApplyMerge(state, state[Location].GetSize());

            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}