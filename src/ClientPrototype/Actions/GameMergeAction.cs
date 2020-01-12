namespace Benediction.Actions
{
    public class GameMergeAction : GameTargetAction
    {
        public override string Action => "Merge";

        public override string ToString() => $"{Location}+{Target}";
    }
}