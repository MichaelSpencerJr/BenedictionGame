using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameMoveAction : GameTargetAction
    {
        public override string Action => "Move";

        public override string ToString() => $"{Location.ToString().ToLower()}{Target.ToString().ToLower()}";

        public override int Size
        {
            get => 17;
            set { }
        }

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ??
                   CheckLocationIsYours(initialState, "Moved") ?? CheckLocationNotLocked(initialState) ?? 
                   CheckTargetEmptyOrCapture(initialState, "Moved Onto") ??
                   CheckLocationTargetReachable(initialState, false);

        }

        public string CheckLocationNotLocked(State state)
        {
            if (state[Location].IsLocked())
                return $"Piece at {Location} Has Already Moved This Turn";
            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var finalState = initialState.DeepCopy();

                ApplyMove(initialState, finalState);

                return finalState;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}