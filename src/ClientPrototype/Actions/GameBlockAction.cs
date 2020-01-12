namespace Benediction.Actions
{
    public class GameBlockAction : GameAction
    {
        public override string Action => "Block";

        public override string ToString() => $"B{Location}";
    }
}