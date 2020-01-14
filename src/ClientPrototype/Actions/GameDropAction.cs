using System;
using System.Linq;
using Benediction.Board;
using Microsoft.Win32;

namespace Benediction.Actions
{
    public class GameDropAction : GameAction
    {
        public override string Action => "Drop";

        public override string ToString() => $"@{Location}";
   
        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ??
                   CheckLocationEmpty(initialState) ?? CheckOnOrAdjacentHome(initialState);
        }

        public string CheckOnOrAdjacentHome(State initialState)
        {
            var targetHome = Side == ActionSide.Red ? initialState.RedHome : initialState.BlueHome;

            if (Location == targetHome) return null;

            if (Movement.AllMoves.Any(move => move(Location, false, false) == targetHome))
            {
                return null;
            }

            return $"Drop Must Be Adjacent Your Home At {targetHome}";
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var retval = initialState.DeepCopy();

                retval[Location] = Cell.Size1 | Cell.Locked;
                if (Side == ActionSide.Red) retval[Location] |= Cell.SideRed;
                if (Location == (Side == ActionSide.Red ? initialState.RedHome : initialState.BlueHome))
                    retval[Location] |= Cell.King;
                
                return retval;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}