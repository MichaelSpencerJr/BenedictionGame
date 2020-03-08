using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// A complete sequence of setup, edit, or move actions which make up a single game session
    /// </summary>
    public class GameState : List<StateInfo>
    {
        /// <summary>
        /// Describes the current game in formatted text
        /// </summary>
        /// <returns>List of strings with a move number and lines of detail</returns>
        public IEnumerable<string> TextLog()
        {
            if (Count > 0) yield return this[0]?.ToString() ?? string.Empty;
            for (var i = 1; i < Count; i++)
            {
                yield return $"{i,-4}: {this[i]}";
            }
        }

        /// <summary>
        /// Describes the current game in rows and columns, formatted for a data grid or spreadsheet
        /// </summary>
        /// <param name="idx">Zero-based row index to retrieve contents for</param>
        /// <param name="column">Zero-based column index to retrieve contents for</param>
        /// <returns>Description of that part of that move number</returns>
        public string GridLog(int idx, int column)
        {
            if (idx >= Count) return null;
            if (this[idx] is GameTurn gt) return gt[column]?.ToString() ?? string.Empty;
            return column == 0 ? this[idx]?.ToString() ?? string.Empty : null;
        }

        /// <summary>
        /// Appends a new player move to an existing game state.
        /// </summary>
        /// <param name="playerMove">Player move to append</param>
        /// <returns>Tuple containing an updated game state created by the action (leaving the string null)
        /// OR a null game state and a populated string message explaining why the move cannot be performed.</returns>
        public (State, string) CommitPlayerMove(GameAction playerMove)
        {
            var lastState = this.Any() ? this[Count - 1].NewState : StateManager.Create();
            var moveIdx = (lastState.Flags.IsBlueTurn() ? 2 : 0) + (lastState.Flags.IsSecondTurn() ? 1 : 0);

            var error = playerMove.CheckError(lastState);
            if (error != null) return (new State(), error);

            var postActionState = playerMove.Apply(lastState);
            var newState = GameAction.PrepareNextTurn(postActionState);
            GameTurn nextTurn;
            if (Count != 0 && this[Count - 1] is GameTurn lastTurn && lastTurn.Blue2 is NullAction)
            {
                nextTurn = lastTurn;
            }
            else
            {
                nextTurn = new GameTurn(lastState);
                Add(nextTurn);
            }

            nextTurn[moveIdx] = new PlayerAction
            {
                Action = playerMove, InitialState = lastState, PostActionState = postActionState,
                NewState = newState
            };

            return (newState, null);
        }
    }
}
