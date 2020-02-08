using System;
using Benediction.Board;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Context;

[Binding]
internal class CommonSteps
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly BoardStateContext _context;

    public CommonSteps(BoardStateContext injectedContext)
    {
        _context = injectedContext;
    }

    [Given(@"the current turn is (\S*)")]
    public void GivenTheCurrentTurnIsRed(StateFlags flags)
    {
        Assert.NotNull(_context.BoardState, "Board State has not been initialized.");
        _context.BoardState.Flags &= (StateFlags.BlueKingTaken | StateFlags.BlueWin | StateFlags.RedKingTaken |
                                      StateFlags.RedWin);
        _context.BoardState.Flags |= flags;
        Console.WriteLine($"Board flags set to: {_context.BoardState.Flags}");
    }

    [Given(@"this test isn't written yet")]
    public static void GivenThisTestIsNotWrittenYet()
    {
        Assert.Inconclusive();
    }

    public static int ParseWordNumber(string word)
    {
        switch (word.ToLower().Trim())
        {
            case "zero":
            case "no": return 0;
            case "one": return 1;
            case "two": return 2;
            case "three": return 3;
            case "four": return 4;
            case "five": return 5;
            case "six": return 6;
            case "seven": return 7;
            case "eight": return 8;
            case "nine": return 9;
            case "ten": return 10;
            case "eleven": return 11;
            case "twelve": return 12;
            case "thirteen": return 13;
            case "fourteen": return 14;
            case "fifteen": return 15;
            default:
                if (int.TryParse(word, out var i)) return i;
                throw new ArgumentOutOfRangeException(nameof(word), word,
                    "Was not a recognizable number between 0 and 15.");
        }
    }
}