using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Context;

namespace Testing.SpecFlow.Common
{
    [Binding]
    public sealed class SetupSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BoardStateContext _context;

        public SetupSteps(BoardStateContext injectedContext)
        {
            _context = injectedContext;
        }

        [Given(@"I have an empty (\S*) (\S*) board")]
        public void GivenIHaveAnEmptyBoard(Location redHome, Location blueHome)
        {
            _context.BoardState = StateManager.Create(redHome, blueHome);
            Console.WriteLine($"Loaded empty game board with Red Home at {redHome} and Blue Home at {blueHome}");
        }

        [Given(@"I have board (.*)")]
        public void GivenIHaveNamedBoard(string boardName)
        {
            Assert.IsNotEmpty(_context.StateLibrary, "Named boards should be defined in Background first.");
            Assert.IsTrue(_context.StateLibrary.ContainsKey(boardName), $"No board was defined in Background with the name {boardName}");
            _context.BoardState = _context.StateLibrary[boardName];
            if (_context.ImageBehavior == BoardImageBehavior.EveryStep || _context.ImageBehavior == BoardImageBehavior.EveryChange)
            {
                Console.WriteLine(_context.BoardState.ImageMarkdown());
            }
            Console.WriteLine($"Loaded board {boardName}.");
        }

        [Given(@"I define board (.*) as:")]
        public void GivenIDefine(string boardName, Table table)
        {
            var boardText = string.Join("\r\n", table.Rows.Select(tr => tr[0]));
            _context.StateLibrary[boardName] = StateSerializer.FromString(boardText);
        }

        [Given(@"I load this board:")]
        [Given(@"I load this board")]
        public void GivenILoad(Table table)
        {
            var boardText = string.Join("\r\n", table.Rows.Select(tr => tr[0]));
            _context.BoardState = StateSerializer.FromString(boardText);
            if (_context.ImageBehavior == BoardImageBehavior.EveryStep ||
                _context.ImageBehavior == BoardImageBehavior.EveryChange)
            {
                Console.WriteLine(_context.BoardState.ImageMarkdown());
            }
        }

        [Given(@"I add this (\S*) piece: (.*)")]
        [Given(@"I add these (\S*) pieces: (.*)")]
        public void GivenIAddPieces(ActionSide side, string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            _context.BoardState = StateSerializer.ParseSideV1(_context.BoardState, $"{(side == ActionSide.Red ? "R" : "B")}:{definition}");
            if (_context.ImageBehavior == BoardImageBehavior.EveryStep ||
                _context.ImageBehavior == BoardImageBehavior.EveryChange)
            {
                Console.WriteLine(_context.BoardState.ImageMarkdown());
            }
        }

    }
}
