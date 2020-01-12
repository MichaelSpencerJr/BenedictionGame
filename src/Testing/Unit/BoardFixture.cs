using System.Collections.Generic;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;

namespace Testing.Unit
{
    [TestFixture]
    public class BoardFixture
    {
        [TestCaseSource(nameof(BoardLocationCases))]
        public void ValidBoardLocation(int row, int column, bool isValid)
        {
            var targetLocation = row * 16 + column;
            Assert.AreEqual(isValid, Movement.IsValidLocation((Location) targetLocation));
        }

        public static List<object[]> BoardLocationCases()
        {
            var blueWall = new[] {4, 3, 2, 1, 0, 1, 2, 3, 4};
            var redWall = new[] {12, 13, 14, 15, 16, 15, 14, 13, 12};

            var cases = new List<object[]>();

            for (var row = 0; row <= 16; row++)
            {
                for (var column = 0; column <= 8; column++)
                {
                    cases.Add(new object[]
                        {row, column, column % 2 == row % 2 && row >= blueWall[column] && row <= redWall[column]});
                }
            }

            return cases;
        }
    }
}