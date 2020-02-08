using System;
using System.Collections.Generic;
using System.Linq;
using Benediction.Actions;
using Benediction.Board;
using Benediction.Heuristic;

namespace Benediction.Controller
{
    public static class AvailableActionController
    {
        public static Dictionary<Guid, ProposedState> GetAvailableActions(State currentState, HashSet<Guid> history, HeuristicPolarity polarity)
        {
            var retval = new Dictionary<Guid, ProposedState>();

            if (currentState.Flags.GameEnded()) return retval;

            var side = currentState.Flags.IsRedTurn() ? ActionSide.Red : ActionSide.Blue;

            var workingHistory = history == null ? new HashSet<Guid>() : new HashSet<Guid>(history);

            GetActionsInternal(retval, workingHistory, AllBlocks, currentState, side, polarity);
            GetActionsInternal(retval, workingHistory, AllDrops, currentState, side, polarity);
            GetActionsInternal(retval, workingHistory, AllMergeMoveSplit, currentState, side, polarity);
            
            return retval;
        }

        public static HeuristicController Heuristic = new HeuristicController();

        private static void GetActionsInternal(Dictionary<Guid, ProposedState> availableActions, HashSet<Guid> history,
            Func<State, ActionSide, IEnumerable<GameAction>> iteratorFunc, State currentState, ActionSide side, HeuristicPolarity polarity)
        {
            foreach (var action in iteratorFunc(currentState, side))
            {
                if (action.CheckError(currentState) != null) continue;
                var newState = GameAction.PrepareNextTurn(action.Apply(currentState));
                if (history.Add(newState.BoardId))
                {
                    availableActions[newState.BoardId] = new ProposedState
                    {
                        Key = newState.BoardId, Action = action,
                        Heuristic = Heuristic.GetScore(newState, polarity),
                        Result = newState,
                        Polarity = polarity
                    };
                }
            }
        }

        private static IEnumerable<GameAction> AllBlocks(State currentState, ActionSide side)
        {
            foreach (var location in State.AllBoardLocations)
            {
                if (currentState[location].IsEmpty()) yield return new GameBlockAction {Location = location, Side = side};
            }
        }

        private static IEnumerable<GameAction> AllDrops(State currentState, ActionSide side)
        {
            var home = side == ActionSide.Red ? currentState.RedHome : currentState.BlueHome;
            if (currentState[home].IsEmpty()) yield return new GameDropAction {Location = home, Side = side};

            foreach (var direction in Movement.AllMoves)
            {
                var zone = direction(home, false, false);
                if (zone != Location.Undefined && currentState[zone].IsEmpty())
                    yield return new GameDropAction {Location = zone, Side = side};
            }
        }

        private static IEnumerable<GameAction> AllMergeMoveSplit(State currentState, ActionSide side)
        {
            var sideIsRed = side == ActionSide.Red;
            var blueWrap = side == ActionSide.Red;
            var redWrap = side == ActionSide.Blue;
            foreach (var myPieceLocation in State.AllBoardLocations.Where(loc => currentState[loc].RedPiece() == sideIsRed))
            {
                var stackSize = currentState[myPieceLocation].GetSize();
                foreach (var direction in Movement.AllMoves)
                {
                    var location = myPieceLocation;
                    for (var i = 1; i <= stackSize; i++)
                    {
                        location = direction(location, blueWrap, redWrap);
                        if (location == Location.Undefined || currentState[location].IsBlock())
                        {
                            break;
                        }

                        if (currentState[location].GetSide(side == ActionSide.Blue, side == ActionSide.Red, true))
                        {
                            yield return new GameMoveAction
                                {Side = side, Location = myPieceLocation, Target = location};
                        }
                        else
                        {
                            yield return new GameMergeAction
                                {Side = side, Location = myPieceLocation, Target = location};
                        }

                        for (var partialStack = i; partialStack < stackSize; partialStack++)
                        {
                            yield return new GameSplitAction
                                {Side = side, Location = myPieceLocation, Target = location, Size = partialStack};
                        }
                    }
                }
            }
        }

        public static IEnumerable<GameAction> AllActions(State currentState, ActionSide side)
        {
            foreach (var block in AllBlocks(currentState, side))
            {
                if (block.CheckError(currentState) == null) yield return block;
            }

            foreach (var drop in AllDrops(currentState, side))
            {
                if (drop.CheckError(currentState) == null) yield return drop;
            }

            foreach (var move in AllMergeMoveSplit(currentState, side))
            {
                if (move.CheckError(currentState) == null)  yield return move;
            }
        }
    }
}
