namespace Benediction.Actions
{
    public class GameMoveAction : GameTargetAction
    {
        public override string Action => "Move";

        public override string ToString() => $"{Location}{Target}";
    }
}