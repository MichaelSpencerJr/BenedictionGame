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

        public override string ToString() => $"B{Location.ToString().ToLower()}";

        public override int Size
        {
            get => -2;
            set { }
        }

        public override string CheckError(State initialState)
        {
            return CheckErrorBase(initialState) ?? CheckLocationEmpty(initialState) ??
                   CheckLocationNotPlayerHome(initialState) ?? CheckAdjacentBlockades(initialState);
        }

        private string CheckLocationNotPlayerHome(State initialState)
        {
            if (initialState.RedHome == Location)
            {
                return $"Cannot Block Red Home at Location {Location}";
            }

            if (initialState.BlueHome == Location)
            {
                return $"Cannot Block Blue Home at Location {Location}";
            }

            return null;
        }

        private string CheckAdjacentBlockades(State initialState)
        {
            foreach (var direction in Movement.AllMoves)
            {
                var adjacentCell = direction(Location, false, false);
                if (!Movement.IsValidLocation(adjacentCell)) continue;
                if (initialState[adjacentCell].IsBlock())
                {
                    return $"Cannot Block Adjacent Existing Block {adjacentCell}";
                }
            }

            return null;
        }

        public override State Apply(State state)
        {
            var error = CheckError(state);

            if (string.IsNullOrEmpty(error))
            {
                state[Location] = Cell.Block;
                return state;
            }

            throw new InvalidOperationException($"Did not check invalid move before applying: {error}");
        }
    }
}