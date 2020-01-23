using System;
using System.Linq;
using Benediction.Board;
using Microsoft.Win32;

namespace Benediction.Actions
{
    public class GameDropAction : GameAction
    {
        public override string Action => "Drop";

        public override string ToString() => $"@{Location.ToString().ToLower()}";
   
        public override int Size
        {
            get => int.MaxValue;
            set { }
        }

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ??
                   CheckLocationEmpty(initialState) ?? CheckOnOrAdjacentHome(initialState);
        }

        public string CheckOnOrAdjacentHome(State initialState)
        {
            var targetHome = Side == ActionSide.Red ? initialState.RedHome : initialState.BlueHome;

            if (Location == targetHome) return null;

            foreach (var move in Movement.AllMoves)
            {
                if (move(Location, false, false) == targetHome)
                {
                    return null;
                }
            }

            return $"Drop Must Be Adjacent Your Home At {targetHome}";
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var finalState = initialState.DeepCopy();

                finalState[Location] = Cell.Size1 | Cell.Locked;
                if (Side == ActionSide.Red) finalState[Location] |= Cell.SideRed;
                
                return finalState;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}