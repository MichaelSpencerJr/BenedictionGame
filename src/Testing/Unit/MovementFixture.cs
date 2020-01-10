using System;
using System.Collections.Generic;
using Benediction;
using NUnit.Framework;

namespace Testing.Unit
{
    [TestFixture]
    public class MovementFixture
    {
        [TestCaseSource(nameof(NorthSouthCases))]
        public void NorthSouthMovementTest(BoardLocation south, BoardLocation north, bool isLegal)
        {
            MovementTestInternal(south, north, Movement.North, isLegal, nameof(Movement.North));
            MovementTestInternal(north, south, Movement.South, isLegal, nameof(Movement.South));
        }

        [TestCaseSource(nameof(NorthEastSouthWestCases))]
        public void NorthEastSouthWestMovementTest(BoardLocation southWest, BoardLocation northEast, bool isLegal, bool isReciprocal)
        {
            MovementTestInternal(southWest, northEast, Movement.NorthEast, isLegal, nameof(Movement.NorthEast));
            MovementTestInternal(northEast, southWest, Movement.SouthWest, isLegal && isReciprocal, nameof(Movement.SouthWest));
        }

        [TestCaseSource(nameof(NorthWestSouthEastCases))]
        public void NorthWestSouthEastMovementTest(BoardLocation southEast, BoardLocation northWest, bool isLegal, bool isReciprocal)
        {
            MovementTestInternal(southEast, northWest, Movement.NorthWest, isLegal, nameof(Movement.NorthWest));
            MovementTestInternal(northWest, southEast, Movement.SouthEast, isLegal && isReciprocal, nameof(Movement.SouthEast));
        }

        private void MovementTestInternal(BoardLocation from, BoardLocation to,
            Func<BoardLocation, BoardLocation> moverFunc, bool isLegal, string moveName)
        {
            try
            {
                var actualTo = moverFunc(from);
                Assert.True(isLegal, "{0} move from {1} was allowed but was expected to be illegal", moveName, from);
                Assert.AreEqual(to, actualTo, "{0} move from {1} was expected to go to {2} but actually went to {3}.",
                    moveName, from, actualTo, to);
                Console.WriteLine($"{moveName} from {from} leads to {to}");
            }
            catch
            {
                Assert.IsFalse(isLegal, "{0} move from {1} was illegal but was expected to be allowed.", moveName,
                    from);
            }
        }

        public static List<object[]> NorthSouthCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { BoardLocation.A5, BoardLocation.A1, true});
            cases.Add(new object[] { BoardLocation.B2, BoardLocation.B3, true});
            cases.Add(new object[] { BoardLocation.F7, BoardLocation.F8, true});
            cases.Add(new object[] { BoardLocation.E9, BoardLocation.E1, true});
            cases.Add(new object[] { BoardLocation.I1, BoardLocation.I2, true});

            return cases;
        }

        public static List<object[]> NorthEastSouthWestCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { BoardLocation.E9, BoardLocation.A5, true, false});
            cases.Add(new object[] { BoardLocation.A3, BoardLocation.B4, true, true});
            cases.Add(new object[] { BoardLocation.I2, BoardLocation.Undefined, false, false});
            cases.Add(new object[] { BoardLocation.I5, BoardLocation.A1, true, true});
            cases.Add(new object[] { BoardLocation.A5, BoardLocation.B6, true, true});

            return cases;
        }

        public static List<object[]> NorthWestSouthEastCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { BoardLocation.E9, BoardLocation.I5, true, false});
            cases.Add(new object[] { BoardLocation.A5, BoardLocation.I1, true, true});
            cases.Add(new object[] { BoardLocation.A3, BoardLocation.Undefined, false, false});
            cases.Add(new object[] { BoardLocation.I5, BoardLocation.H6, true, true});
            cases.Add(new object[] { BoardLocation.F4, BoardLocation.E5, true, true});

            return cases;
        }
    }
}