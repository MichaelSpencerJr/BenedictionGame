namespace Benediction.Actions
{
    public class GameDropAction : GameAction
    {
        public override string Action => "Drop";

        public override string ToString() => $"@{Location}";
    }
}