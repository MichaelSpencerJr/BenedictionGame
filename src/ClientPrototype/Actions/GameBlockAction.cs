using System;
using Benediction.Board;

namespace Benediction.Actions
{
    /// <summary>
    /// Places a blockade on the provided location
    /// </summary>
    public class GameBlockAction : GameAction
    {
        public override string Action => "Block";

        public override string ToString() => $"B{Location}";

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckLocationEmpty(initialState) ??
                   CheckLocationNotPlayerHome(initialState) ?? CheckAdjacentBlockades(initialState);
        }

        private string CheckLocationNotPlayerHome(State initialState)
        {
            if (initialState.RedHome == Location)
            {
                return $"Cannot Blockade Red Home at Location {Location}";
            }

            if (initialState.BlueHome == Location)
            {
                return $"Cannot Blockade Blue Home at Location {Location}";
            }

            return null;
        }

        private string CheckAdjacentBlockades(State initialState)
        {
            foreach (var direction in Movement.AllMoves)
            {
                var adjacentCell = direction(Location, false, false);
                if (adjacentCell == Location.Undefined) continue;
                if (initialState[adjacentCell] == Cell.Blockade)
                {
                    return $"Cannot Blockade Adjacent Existing Blockade {adjacentCell}";
                }
            }

            return null;
        }

        public override State Apply(State initialState)
        {
            var error = CheckError(initialState);

            if (string.IsNullOrEmpty(error))
            {
                var finalState = initialState.DeepCopy();
                
                finalState[Location] = Cell.Blockade;
                
                return finalState;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}