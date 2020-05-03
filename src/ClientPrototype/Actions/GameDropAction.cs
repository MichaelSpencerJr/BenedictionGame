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
            get => -1;
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
                if (move(Location, Movement.Blue.CannotWrap, Movement.Red.CannotWrap, Movement.UnmarkedEdges.CannotWrap) == targetHome)
                {
                    return null;
                }
            }

            return $"Drop Must Be Adjacent Your Home At {targetHome}";
        }

        public override State Apply(State state)
        {
            var error = CheckError(state);

            if (string.IsNullOrEmpty(error))
            {
                state[Location] = Cell.Size1.Locked(true).SetFlag(Cell.SideRed, Side == ActionSide.Red);
                
                return state;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}