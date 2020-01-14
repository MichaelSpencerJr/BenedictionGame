using System;
using Benediction.Board;

namespace Benediction.Actions
{
    public class GameMoveAction : GameTargetAction
    {
        public override string Action => "Move";

        public override string ToString() => $"{Location}{Target}";

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckErrorTarget(initialState) ??
                   CheckLocationIsYours(initialState, "Moved") ?? CheckLocationNotLocked(initialState) ?? 
                   CheckTargetEmptyOrCapture(initialState, "Moved Onto") ??
                   CheckLocationTargetReachable(initialState, false);

        }

        public string CheckLocationNotLocked(State state)
        {
            if ((state[Location] & Cell.Locked) == Cell.Locked)
                return $"Piece at {Location} Has Already Moved This Turn";
            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var retval = initialState.DeepCopy();

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
                
                return retval;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}