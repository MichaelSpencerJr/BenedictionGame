using System;
using System.Collections.Generic;
using System.Linq;
using Benediction.Actions;
using Benediction.Board;

namespace Benediction.Controller
{
    public static class AvailableActionController
    {
        public static Dictionary<Guid, ProposedState> GetAvailableActions(State currentState, HashSet<Guid> history)
        {
            var retval = new Dictionary<Guid, ProposedState>();

            if ((currentState.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2 | StateFlags.BlueAction1 |
                                       StateFlags.BlueAction2)) == 0) return retval;

            var side = (currentState.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2)) > 0
                ? ActionSide.Red
                : ActionSide.Blue;

            var workingHistory = history == null ? new HashSet<Guid>() : new HashSet<Guid>(history);

            GetActionsInternal(retval, workingHistory, AllBlocks, currentState, side);
            GetActionsInternal(retval, workingHistory, AllDrops, currentState, side);
            GetActionsInternal(retval, workingHistory, AllMergeMoveSplit, currentState, side);
            
            return retval;
        }

        private static void GetActionsInternal(Dictionary<Guid, ProposedState> availableActions, HashSet<Guid> history,
            Func<State, ActionSide, IEnumerable<GameAction>> iteratorFunc, State currentState, ActionSide side)
        {
            foreach (var action in iteratorFunc(currentState, side))
            {
                if (action.CheckError(currentState) != null) continue;
                var newState = action.Apply(currentState);
                if (history.Add(newState.BoardId))
                {
                    availableActions[newState.BoardId] = new ProposedState
                    {
                        Key = newState.BoardId, Action = action, Heuristic = double.NaN, Result = newState,
                        Polarity = HeuristicPolarity.RedPositive
                    };
                }
            }
        }

        private static IEnumerable<GameAction> AllBlocks(State currentState, ActionSide side)
        {
            return from location in State.AllBoardLocations
                where currentState[location] == Cell.Empty
                select new GameBlockAction {Location = location, Side = side};
        }

        private static IEnumerable<GameAction> AllDrops(State currentState, ActionSide side)
        {
            var home = side == ActionSide.Red ? currentState.RedHome : currentState.BlueHome;
            if (currentState[home] == Cell.Empty) yield return new GameDropAction {Location = home, Side = side};

            foreach (var direction in Movement.AllMoves)
            {
                var zone = direction(home, false, false);
                if (zone != Location.Undefined && currentState[zone] == Cell.Empty)
                    yield return new GameDropAction {Location = zone, Side = side};
            }
        }

        private static IEnumerable<GameAction> AllMergeMoveSplit(State currentState, ActionSide side)
        {
            var sideFlag = side == ActionSide.Red ? Cell.SideRed : Cell.Empty;
            var blueWrap = side == ActionSide.Red;
            var redWrap = side == ActionSide.Blue;
            foreach (var myPieceLocation in State.AllBoardLocations.Where(loc => (currentState[loc] & Cell.SideRed) == sideFlag))
            {
                var stackSize = (int) (currentState[myPieceLocation] & Cell.SizeMask);
                foreach (var direction in Movement.AllMoves)
                {
                    var location = myPieceLocation;
                    for (var i = 1; i <= stackSize; i++)
                    {
                        location = direction(location, blueWrap, redWrap);
                        if (location == Location.Undefined || currentState[location] == Cell.Blockade)
                        {
                            break;
                        }

                        if (currentState[location] == Cell.Empty || (currentState[location] & Cell.SideRed) != sideFlag)
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
    }
}
