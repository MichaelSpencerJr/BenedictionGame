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
                var potentialBridgeSpaces = new HashSet<Location>();

                if (!unconnectedSpaces.Contains(startingLocation)) continue;
                potentialBridgeSpaces.Add(startingLocation);
                unconnectedSpaces.Remove(startingLocation);

                var unexpanded = new Stack<Location>(potentialBridgeSpaces);

                while (unexpanded.Count > 0)
                {
                    var nextExpand = unexpanded.Pop();
                    foreach (var mover in Movement.AllMoves)
                    {
                        var adjacent = mover(nextExpand, false, false);
                        if (unconnectedSpaces.Contains(adjacent))
                        {
                            potentialBridgeSpaces.Add(adjacent);
                            unexpanded.Push(adjacent);
                            unconnectedSpaces.Remove(adjacent);
                        }
                    }
                }

                foreach (var endingLocation in State.BlueWallAdjacentLocations)
                {
                    if (potentialBridgeSpaces.Contains(endingLocation))
                    {
                        foreach (var potentialBridgeSpace in potentialBridgeSpaces)
                        {
                            bridgeSpaces.Add(potentialBridgeSpace);
                        }
                        break;
                    }
                }
            }

            return bridgeSpaces;
        }
    }
}
