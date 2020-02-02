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
    public class CommonSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BoardStateContext _context;

        public CommonSteps(BoardStateContext injectedContext)
        {
            _context = injectedContext;
        }

        [Given(@"the current turn is (.*)")]
        public void GivenTheCurrentTurnIsRed(StateFlags flags)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            _context.BoardState.Flags &= (StateFlags.BlueKingTaken | StateFlags.BlueWin | StateFlags.RedKingTaken |
                                          StateFlags.RedWin);
            _context.BoardState.Flags |= flags;
            Console.WriteLine($"Board flags set to: {_context.BoardState.Flags}");
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
            Console.WriteLine($"Board flags set to: {_context.BoardState.Flags}");
        }


        
        [Then(@"the action succeeds")]
        public void ThenTheActionSucceeds()
        {
            Assert.IsNull(_context.LastMessage);
        }

        [Then(@"the action fails")]
        public void ThenTheActionFails()
        {
            Assert.IsNotNull(_context.LastMessage);
            Console.WriteLine($"Failed with: {_context.LastMessage}");
        }

        [Then(@"the board has (.*) pieces matching: (.*)")]
        public void ThenTheBoardHasPiecesMatching(ActionSide side, string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");

            var sideRed = side == ActionSide.Red;
            var testBoard = new State();

            testBoard.ParseSideV1($"{(sideRed ? "R" : "B")}:{definition}");

            var sb = new StringBuilder();

            var successful = 0;
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
                else
                {
                    successful++;
                }
            }

            Console.WriteLine($"Successfully validated {successful} {side} piece{(successful == 1 ? "" : "s")}.");

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

            var successful = 0;

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
                else
                {
                    successful++;
                }
            }

            Console.WriteLine($"Successfully validated {successful} block{(successful == 1 ? "" : "s")}.");

            if (sb.Length > 0)
            {
                Assert.Fail($"The following board locations had different contents than expected:\r\n{sb}");
            }
        }

        [Given(@"this test isn't written yet")]
        public void GivenThisTestIsntWrittenYet()
        {
            Assert.Inconclusive("This test isn't written yet.");
        }

        [Then(@"the game is over and (.*) has won")]
        public void GameOver(ActionSide side)
        {
            Assert.True(_context.BoardState.Flags.GameWon(),
                $"The game is still in progress: {_context.BoardState.Flags}");

            if (side == ActionSide.Red)
            {
                Assert.AreEqual(StateFlags.RedWin, _context.BoardState.Flags & StateFlags.RedWin);
            }
            else if (side == ActionSide.Blue)
            {
                Assert.AreEqual(StateFlags.BlueWin, _context.BoardState.Flags & StateFlags.BlueWin);
            }
        }
    }
}
