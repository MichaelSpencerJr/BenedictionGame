﻿using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameMergeAction : GameTargetAction
    {
        public override string Action => "Merge";

        public override string ToString() => $"{Location}+{Target}";
 
        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ??
                   CheckLocationIsYours(initialState, "Merged") ?? CheckTargetIsYours(initialState, "Merged") ??
                   CheckLocationTargetReachable(initialState, false) ?? CheckMergeRules(initialState);
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var retval = initialState.DeepCopy();

                ApplyMerge(initialState, retval);

                return retval;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}