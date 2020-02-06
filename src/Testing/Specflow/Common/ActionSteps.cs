using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Context;
using TechTalk.SpecFlow.Assist;

namespace Testing.SpecFlow.Common
{
    [Binding]
    public sealed class ActionSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BoardStateContext _context;

        public ActionSteps(BoardStateContext injectedContext)
        {
            _context = injectedContext;
        }

        private void TryApplyAction(GameAction moveAction, Location location, Location target = Location.Undefined)
        {
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
            {
                Console.WriteLine($"Accepted: {moveAction.ToString()}");
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
                Console.WriteLine(_context.BoardState.ImageMarkdown(location, target));
            }
            else
            {
                Console.WriteLine($"Rejected: {moveAction.ToString()}: {_context.LastMessage}");
            }
        }

        [When(@"the (.*) player moves the (?:piece|stack) (?:at|from) (.*) (?:to|into|onto) (.*)")]
        public void WhenIMove(ActionSide side, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var action = new GameMoveAction {Location = from, Side = side, Target = to};
            TryApplyAction(action, from, to);
        }

        [When(@"the (.*) player merges the (?:piece|stack) (?:at|from) (.*) (?:to|into|onto) (.*)")]
        public void WhenIMerge(ActionSide side, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var action = new GameMergeAction {Location = from, Side = side, Target = to};
            TryApplyAction(action, from, to);
        }

        [When(@"the (.*) player splits (.*) (?:piece|stack|pieces|stacks) (?:at|from) (.*) (?:to|into|onto) (.*)")]
        public void WhenISplit(ActionSide side, int count, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var action = new GameSplitAction {Location = from, Side = side, Target = to, Size = count};
            TryApplyAction(action, from, to);
        }


        [When(@"the (.*) player blocks (.*)")]
        [When(@"the (.*) player blockades (.*)")]
        public void WhenIBlockade(ActionSide side, Location location)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var action = new GameBlockAction {Location = location, Side = side};
            TryApplyAction(action, location);
        }

        
        [When(@"the (.*) player drops a new piece at (.*)")]
        public void WhenIDrop(ActionSide side, Location location)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var action = new GameDropAction {Location = location, Side = side};
            TryApplyAction(action, location);
        }

        [When(@"(.*) does (.*)")]
        [When(@"(.*) tries (.*)")]
        [When(@"(.*) inputs (.*)")]
        [When(@"(.*) inputs move (.*)")]
        public void WhenDoes(ActionSide side, string move)
        {
            Location location, target;
            Assert.IsNotEmpty(move, "Move is required");
            switch (move.Length)
            {
                case 3: //block or drop
                    Assert.IsTrue(Enum.TryParse(move.Substring(1).ToUpper(), out location),
                        $"{move.Substring(1)} was not a valid Location.");
                    if (move[0] == '@')
                    {
                        WhenIDrop(side, location);
                    }
                    else if (move[0] == 'B')
                    {
                        WhenIBlockade(side, location);
                    }
                    else
                        Assert.Fail($"{move.Substring(0, 1)} was unexpected for a three-character move input." +
                                    "  Expected B for block or @ for drop.");

                    break;
                case 4: //move
                    Assert.IsTrue(Enum.TryParse(move.Substring(0, 2).ToUpper(), out location),
                        $"{move.Substring(0, 2)} was not a valid Location.");
                    Assert.IsTrue(Enum.TryParse(move.Substring(2, 2).ToUpper(), out target),
                        $"{move.Substring(2, 2)} was not a valid Location.");
                    WhenIMove(side, location, target);
                    break;
                case 5: //merge
                    Assert.IsTrue(Enum.TryParse(move.Substring(0, 2).ToUpper(), out location),
                        $"{move.Substring(0, 2)} was not a valid Location.");
                    Assert.IsTrue(Enum.TryParse(move.Substring(3, 2).ToUpper(), out target),
                        $"{move.Substring(3, 2)} was not a valid Location.");
                    WhenIMerge(side, location, target);
                    break;
                default: //split
                    Assert.IsTrue(Enum.TryParse(move.Substring(0, 2).ToUpper(), out location),
                        $"{move.Substring(0, 2)} was not a valid Location.");
                    Assert.IsTrue(Enum.TryParse(move.Substring(move.Length - 2, 2).ToUpper(), out target),
                        $"{move.Substring(move.Length - 2, 2)} was not a valid Location.");
                    Assert.IsTrue(int.TryParse(move.Substring(3, move.Length - 6), out var size),
                        $"{move.Substring(3, move.Length - 6)} was not a valid Size.");
                    WhenISplit(side, size, location, target);
                    break;
            }

        }

        [When(@"the following moves are performed:")]
        public void WhenTheFollowingMoves(Table table)
        {
            var moves = table.CreateSet<GameTurnDataRow>();
            var empty = true;
            foreach (var row in moves)
            {
                if (!string.IsNullOrWhiteSpace(row.RedAction1))
                {
                    WhenDoes(ActionSide.Red, row.RedAction1);
                    empty = false;
                }

                if (!string.IsNullOrWhiteSpace(row.RedAction2))
                {
                    WhenDoes(ActionSide.Red, row.RedAction2);
                    empty = false;
                }

                if (!string.IsNullOrWhiteSpace(row.BlueAction1))
                {
                    WhenDoes(ActionSide.Blue, row.BlueAction1);
                    empty = false;
                }

                if (!string.IsNullOrWhiteSpace(row.BlueAction2))
                {
                    WhenDoes(ActionSide.Blue, row.BlueAction2);
                    empty = false;
                }
            }

            Assert.IsFalse(empty, "Missing table argument containing moves to perform.");
        }
    }
}
