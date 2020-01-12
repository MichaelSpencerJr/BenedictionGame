using Benediction.Board;

namespace Benediction.Actions
{
    public abstract class GameTargetAction : GameAction
    {
        public Location Target { get; }
    }
}