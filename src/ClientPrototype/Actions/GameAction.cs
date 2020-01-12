using Benediction.Board;

namespace Benediction.Actions
{
    public abstract class GameAction
    {
        public ActionSide Side { get; }

        public Location Location { get; }

        public abstract string Action { get; }

        public new abstract string ToString();

        public static string DescribeGameTurn(GameAction red1, GameAction red2, GameAction blue1, GameAction blue2)
        {
            return $"{red1} {red2} / {blue1} {blue2}";
        }
    }
}
