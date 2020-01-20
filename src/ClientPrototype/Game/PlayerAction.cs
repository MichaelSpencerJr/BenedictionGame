using Benediction.Actions;
using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Game state transition caused by a legal player action in the game, followed by
    /// normal inter-turn logic which prepares for the next player turn or sets a terminal state.
    /// </summary>
    public class PlayerAction : StateTransition
    {
        public GameAction Action { get; set; }
        public override int EmptyColumn => -1;

        public State PostActionState { get; set; }

        public override string ToString() => Action.ToString();
    }
}