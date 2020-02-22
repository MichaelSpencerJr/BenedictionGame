using System;
using Benediction.Actions;
using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Game state modification which clears the entire board and resets it with given home positions and pieces
    /// </summary>
    public class NewGame : StateInfo
    {
        public override string ToString() => $"N({RedHome.ToString().ToLower()},{BlueHome.ToString().ToLower()})";
        public sealed override State NewState { get; set; }
        public override int EmptyColumn => -1;

        /// <summary>
        /// Location of Red Home at start of game
        /// </summary>
        public Location RedHome { get; }

        /// <summary>
        /// Location of Blue Home at start of game
        /// </summary>
        public Location BlueHome { get; }

        /// <summary>
        /// Starts a new game with Red and Blue homes at default locations (bottom center, E2, and top center, E8)
        /// </summary>
        public NewGame() : this(Location.E2, Location.E8)
        {
        }

        /// <summary>
        /// Starts a new game with Red and Blue homes at provided locations
        /// </summary>
        /// <param name="redHome">Location of red home</param>
        /// <param name="blueHome">Location of blue home</param>
        public NewGame(Location redHome, Location blueHome)
        {
            if (redHome != Location.C2 && redHome != Location.D2 && redHome != Location.E2 && redHome != Location.F2 &&
                redHome != Location.G2)
            {
                throw new ArgumentOutOfRangeException(nameof(redHome),
                    "Valid Red Home Locations Are C2, D2, E2, F2, or G2");
            }

            if (blueHome != Location.C6 && blueHome != Location.D7 && blueHome != Location.E8 &&
                blueHome != Location.F7 && blueHome != Location.G6)
            {
                throw new ArgumentOutOfRangeException(nameof(redHome),
                    "Valid Blue Home Locations Are C6, D7, E8, F7, or G6");
            }

            RedHome = redHome;
            BlueHome = blueHome;
            var newState = StateManager.Create(redHome, blueHome);
            newState[redHome] = Cell.King | Cell.SideRed | Cell.Size1;
            newState[blueHome] = Cell.King | Cell.Size1;
            foreach (var direction in Movement.AllMoves)
            {
                var redMan = direction(redHome, false, false);
                if (redMan != Location.Undefined) newState[redMan] = Cell.SideRed | Cell.Size1;
                var blueMan = direction(blueHome, false, false);
                if (blueMan != Location.Undefined) newState[blueMan] = Cell.Size1;
            }

            newState.Flags = StateFlags.RedAction1;
            NewState = newState;
        }
    }
}