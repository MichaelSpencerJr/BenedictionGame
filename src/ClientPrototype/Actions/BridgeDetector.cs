using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;

namespace Benediction.Actions
{
    public static class BridgeDetector
    {
        public static ISet<Location> GetBridgeSpaces(State state, ActionSide side)
        {
            var sideFlag = side == ActionSide.Red ? Cell.SideRed : Cell.Empty;

            var unconnectedSpaces = new HashSet<Location>(state
                .Where(kvp => (kvp.Value & Cell.SizeMask) > 0 && (kvp.Value & Cell.SideRed) == sideFlag)
                .Select(kvp => kvp.Key));

            var bridgeSpaces = new HashSet<Location>();

            foreach (var startingLocation in State.RedWallAdjacentLocations)
            {
                if (!unconnectedSpaces.Contains(startingLocation)) continue;
                bridgeSpaces.Add(startingLocation);
                unconnectedSpaces.Remove(startingLocation);
            }

            var unexpanded = new Stack<Location>(bridgeSpaces);

            while (unexpanded.Count > 0)
            {
                var nextExpand = unexpanded.Pop();
                foreach (var mover in Movement.AllMoves)
                {
                    var adjacent = mover(nextExpand, false, false);
                    if (unconnectedSpaces.Contains(adjacent))
                    {
                        bridgeSpaces.Add(adjacent);
                        unexpanded.Push(adjacent);
                        unconnectedSpaces.Remove(adjacent);
                    }
                }
            }

            foreach (var endingLocation in State.BlueWallAdjacentLocations)
            {
                if (bridgeSpaces.Contains(endingLocation))
                    return bridgeSpaces;
            }

            return new HashSet<Location>();
        }
    }
}
