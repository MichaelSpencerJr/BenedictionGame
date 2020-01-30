using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Context;

namespace Testing.Specflow.Common
{
    [Binding]
    public class CommonBindings
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BoardStateContext _context;

        public CommonBindings(BoardStateContext injectedContext)
        {
            _context = injectedContext;
        }

        [Given(@"I have an empty (.*) (.*) board")]
        public void GivenIHaveAnEmptyBoard(Location redHome, Location blueHome)
        {
            _context.BoardState = new State {RedHome = redHome, BlueHome = blueHome};
        }

        [Given(@"I have board (.*)")]
        public void GivenIHaveNamedBoard(string boardName)
        {
            Assert.IsNotEmpty(_context.StateLibrary, "Named boards should be defined in Background first.");
            Assert.IsTrue(_context.StateLibrary.ContainsKey(boardName), $"No board was defined in Background with the name {boardName}");
            _context.BoardState = _context.StateLibrary[boardName].DeepCopy();
        }

        [Given(@"I define board (.*) as:")]
        public void GivenIDefine(string boardName, Table table)
        {
            var boardText = string.Join("\r\n", table.Rows.Select(tr => tr[0]));
            _context.StateLibrary[boardName] = new State(boardText);
        }

        [Given(@"the current turn is (.*)")]
        public void GivenTheCurrentTurnIsRed(StateFlags flags)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            _context.BoardState.Flags &= (StateFlags.BlueKingTaken | StateFlags.BlueWin | StateFlags.RedKingTaken |
                                          StateFlags.RedWin);
            _context.BoardState.Flags |= flags;
        }

        [Then(@"the current turn is (.*)")]
        public void ThenTheCurrentTurnIsRed(StateFlags flags)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");

            Assert.AreEqual(
                flags &
                (StateFlags.RedAction1 | StateFlags.RedAction2 | StateFlags.BlueAction1 | StateFlags.BlueAction2),
                _context.BoardState.Flags & (StateFlags.RedAction1 | StateFlags.RedAction2 | StateFlags.BlueAction1 |
                                             StateFlags.BlueAction2));
        }


        [Given(@"I add this (.*) piece: (.*)")]
        [Given(@"I add these (.*) pieces: (.*)")]
        public void GivenIHaveOneRedPieceAt(ActionSide side, string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            _context.BoardState.ParseSideV1($"{(side == ActionSide.Red ? "R" : "B")}:{definition}");
        }

        [When(@"the (.*) player moves the (?:piece|stack) at (.*) to (.*)")]
        public void WhenIMove(ActionSide side, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var moveAction = new GameMoveAction {Location = from, Side = side, Target = to};
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
        }

        [When(@"the (.*) player merges the (?:piece|stack) at (.*) into (.*)")]
        public void WhenIMerge(ActionSide side, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var moveAction = new GameMergeAction {Location = from, Side = side, Target = to};
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
        }

        [When(@"the (.*) player splits (.*) (?:pieces|stacks) from (.*) onto (.*)")]
        [When(@"the (.*) player splits (.*) (?:piece|stack) from (.*) onto (.*)")]
        public void WhenISplit(ActionSide side, int count, Location from, Location to)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var moveAction = new GameSplitAction {Location = from, Side = side, Target = to, Size = count};
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
        }


        [When(@"the (.*) player blocks (.*)")]
        [When(@"the (.*) player blockades (.*)")]
        public void WhenIBlockade(ActionSide side, Location location)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var moveAction = new GameBlockAction {Location = location, Side = side};
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
        }

        
        [When(@"the (.*) player drops a new piece at (.*)")]
        public void WhenIDrop(ActionSide side, Location location)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            var moveAction = new GameDropAction {Location = location, Side = side};
            _context.LastMessage = moveAction.CheckError(_context.BoardState);
            if (_context.LastMessage == null)
                _context.BoardState = GameAction.PrepareNextTurn(moveAction.Apply(_context.BoardState));
        }

        
        [Then(@"the action succeeds")]
        public void ThenTheActionSucceeds()
        {
            Assert.IsNull(_context.LastMessage);
        }
        
        [Then(@"the action fails with: (.*)")]
        public void ThenTheActionFailsWith(string error)
        {
            Assert.AreEqual(error, _context.LastMessage);
        }

        [Then(@"the board has (.*) pieces matching: (.*)")]
        public void ThenTheBoardHasPiecesMatching(ActionSide side, string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");

            var sideRed = side == ActionSide.Red;
            var testBoard = new State();

            testBoard.ParseSideV1($"{(sideRed ? "R" : "B")}:{definition}");

            var sb = new StringBuilder();

            foreach (var location in State.AllBoardLocations)
            {
                if (sideRed)
                {
                    if (!_context.BoardState[location].RedPiece() && !testBoard[location].RedPiece()) continue;
                }
                else 
                {
                    if (!_context.BoardState[location].BluePiece() && !testBoard[location].BluePiece()) continue;
                }

                if ((_context.BoardState[location] & ~(Cell.Locked | Cell.CursePending)) !=
                    (testBoard[location] &= ~(Cell.Locked | Cell.CursePending)))
                {
                    sb.AppendLine(
                        $"At {location}: Expected {testBoard[location] & ~(Cell.Locked | Cell.CursePending)}, " +
                        $"Got {_context.BoardState[location] & ~(Cell.Locked | Cell.CursePending)}");
                }
            }

            if (sb.Length > 0)
            {
                Assert.Fail($"The following board locations had different contents than expected:\r\n{sb}");
            }
        }

        [Then(@"the board has blocks matching: (.*)")]
        [Then(@"the board has blockades matching: (.*)")]
        public void ThenTheBoardHasBlocksMatching(string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");

            var testBoard = new State();

            testBoard.ParseSideV1($"X:{definition}");

            var sb = new StringBuilder();

            foreach (var location in State.AllBoardLocations)
            {
                if (!_context.BoardState[location].IsBlock() && !testBoard[location].IsBlock()) continue;

                if ((_context.BoardState[location] & ~(Cell.Locked | Cell.CursePending)) !=
                    (testBoard[location] &= ~(Cell.Locked | Cell.CursePending)))
                {
                    sb.AppendLine(
                        $"At {location}: Expected {testBoard[location] & ~(Cell.Locked | Cell.CursePending)}, " +
                        $"Got {_context.BoardState[location] & ~(Cell.Locked | Cell.CursePending)}");
                }
            }

            if (sb.Length > 0)
            {
                Assert.Fail($"The following board locations had different contents than expected:\r\n{sb}");
            }
        }
    }
}
