using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Testing.SpecFlow.Context;

namespace Testing.SpecFlow.Common
{
    [Binding]
    public sealed class ValidationSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BoardStateContext _context;

        public ValidationSteps(BoardStateContext injectedContext)
        {
            _context = injectedContext;
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

        [Then("the following locations match:")]
        [Then("the following board positions match:")]
        public void ThenTheFollowingLocationsMatch(Table table)
        {
            var errorLog = new StringBuilder();
            int count = 0, success = 0, failure = 0;

            foreach (var validation in table.Rows.Select(Validation.ParseRow))
            {
                var result = errorLog.ValidateRow(_context.BoardState, validation);
                count++;
                if (result)
                {
                    success++;
                    Console.WriteLine($"{validation.Location} OK");
                }
                else
                {
                    failure++;
                    Console.Write(errorLog.ToString());
                    errorLog.Clear();
                }
            }

            Assert.Zero(failure,
                $"{success} Success{(success == 1 ? "" : "es")} and {failure} " +
                $"Failure{(failure == 1 ? "" : "s")} out of {count} Total.");
        }
    }

    public static class Validation
    {
        public static ValidationType ParseRow(TableRow row)
        {
            var retval = new ValidationType();
            Assert.IsTrue(row.ContainsKey(nameof(ValidationType.Location)), "Table requires Location column.");
            Assert.IsTrue(Enum.TryParse<Location>(row[nameof(ValidationType.Location)], out var location),
                $"{row[nameof(ValidationType.Location)]} is not a board location.");

            retval.Location = location;

            if (row.ContainsKey(nameof(ValidationType.Contents)) &&
                !string.IsNullOrWhiteSpace(row[nameof(ValidationType.Contents)]) &&
                Enum.TryParse<ValidationPiece>(row[nameof(ValidationType.Contents)], true, out var contents))
            {
                retval.Contents = contents;
            }

            if (row.ContainsKey(nameof(ValidationType.Size)) &&
                !string.IsNullOrWhiteSpace(row[nameof(ValidationType.Size)]) &&
                int.TryParse(row[nameof(ValidationType.Size)], out var size))
            {
                retval.Size = size;
            }

            if (row.ContainsKey(nameof(ValidationType.Type)) &&
                !string.IsNullOrWhiteSpace(row[nameof(ValidationType.Type)]) &&
                Enum.TryParse<ValidationFlag>(row[nameof(ValidationType.Type)], out var type))
            {
                retval.Type = type;
            }

            return retval;
        }

        public static bool CheckPiece(this StringBuilder errorLog, Cell expected, Cell actual, Cell differenceMask)
        {
            if ((expected & differenceMask) == (actual & differenceMask)) return true;

            errorLog.AppendLine($"Expected: {expected & differenceMask}; Actual: {actual & differenceMask}");

            return false;
        }

        public static bool ValidateRow(this StringBuilder errorLog, State actual, ValidationType validation)
        {
            Cell expected = 0, mask = 0;
            if (validation.Type.HasValue)
            {
                mask = Cell.Blessed | Cell.Cursed | Cell.King;
                switch (validation.Type.Value)
                {
                    case ValidationFlag.Blessed:
                        expected = Cell.Blessed;
                        break;
                    case ValidationFlag.Cursed:
                        expected = Cell.Cursed;
                        break;
                    case ValidationFlag.King:
                        expected = Cell.King;
                        break;
                    case ValidationFlag.BlessedKing:
                        expected = Cell.Blessed | Cell.King;
                        break;
                }
            }

            if (validation.Size.HasValue)
            {
                expected |= (Cell)validation.Size;
                mask |= Cell.SizeMask;
            }

            if (validation.Contents.HasValue)
            {
                switch (validation.Contents.Value)
                {
                    case ValidationPiece.Empty:
                        expected = Cell.Empty;
                        mask = ~(Cell) 0;
                        break;
                    case ValidationPiece.Red:
                        expected |= Cell.SideRed;
                        mask |= Cell.SideRed;
                        break;
                    case ValidationPiece.Blue:
                        mask |= Cell.SideRed;
                        break;
                    case ValidationPiece.Block:
                        expected = Cell.Block;
                        mask = ~(Cell) 0;
                        break;
                }
            }

            Assert.IsTrue(actual.ContainsKey(validation.Location),
                $"{validation.Location} (0x{((int) (validation.Location)):X2}) is not a board location.");
            return errorLog.CheckPiece(expected, actual[validation.Location], mask);
        }
    }

    public class ValidationType
    {
        public Location Location { get; set; }
        public ValidationPiece? Contents { get; set; }
        public int? Size { get; set; }
        public ValidationFlag? Type { get; set; }

    }

    public enum ValidationPiece
    {
        Empty,
        Red,
        Blue,
        Block
    }

    public enum ValidationFlag
    {
        Normal,
        Blessed,
        Cursed,
        King,
        BlessedKing
    }
}
