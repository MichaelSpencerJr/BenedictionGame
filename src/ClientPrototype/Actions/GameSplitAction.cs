namespace Benediction.Actions
{
    public class GameSplitAction : GameTargetAction
    {
        public override string Action => "Split";

        public override string ToString() => $"{Location}-{Target}";
    }
}