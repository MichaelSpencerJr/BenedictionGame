namespace Benediction.Game
{
    /// <summary>
    /// Game state transitions involving use of the board editor
    /// </summary>
    public class BoardEditor : StateTransition
    {
        public override string ToString() => "(edited)";
        public override int EmptyColumn => -1;
    }
}