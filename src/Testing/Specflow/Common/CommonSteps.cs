using System;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Context;

namespace Testing.SpecFlow.Common
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

        [Given(@"this test isn't written yet")]
        public void GivenThisTestIsNotWrittenYet()
        {
            Assert.Inconclusive("This test isn't written yet.");
        }
    }
}
