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

        [Given(@"I have an empty (.*) (.*) board")]
        public void GivenIHaveAnEmptyBoard(Location redHome, Location blueHome)
        {
            _context.BoardState = new State {RedHome = redHome, BlueHome = blueHome};
            Console.WriteLine($"Loaded empty game board with Red Home at {redHome} and Blue Home at {blueHome}");
        }

        [Given(@"I have board (.*)")]
        public void GivenIHaveNamedBoard(string boardName)
        {
            Assert.IsNotEmpty(_context.StateLibrary, "Named boards should be defined in Background first.");
            Assert.IsTrue(_context.StateLibrary.ContainsKey(boardName), $"No board was defined in Background with the name {boardName}");
            _context.BoardState = _context.StateLibrary[boardName].DeepCopy();
            Console.WriteLine(_context.BoardState.ImageMarkdown());
            Console.WriteLine($"Loaded board {boardName}.");
        }

        [Given(@"I define board (.*) as:")]
        public void GivenIDefine(string boardName, Table table)
        {
            var boardText = string.Join("\r\n", table.Rows.Select(tr => tr[0]));
            _context.StateLibrary[boardName] = new State(boardText);
        }

        [Given(@"I load this board:")]
        public void GivenILoad(Table table)
        {
            var boardText = string.Join("\r\n", table.Rows.Select(tr => tr[0]));
            _context.BoardState = new State(boardText);
            Console.WriteLine(_context.BoardState.ImageMarkdown());
        }

        [Given(@"I add this (.*) piece: (.*)")]
        [Given(@"I add these (.*) pieces: (.*)")]
        public void GivenIAddPieces(ActionSide side, string definition)
        {
            Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
            _context.BoardState.ParseSideV1($"{(side == ActionSide.Red ? "R" : "B")}:{definition}");
            Console.WriteLine(_context.BoardState.ImageMarkdown());
        }

    }
}
