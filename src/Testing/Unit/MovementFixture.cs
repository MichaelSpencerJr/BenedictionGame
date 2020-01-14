using System;
using System.Collections.Generic;
using Benediction;
using Benediction.Actions;
using Benediction.Board;
using NUnit.Framework;

namespace Testing.Unit
{
    [TestFixture]
    public class MovementFixture
    {
        [TestCaseSource(nameof(NorthSouthCases))]
        public void NorthSouthMovementTest(Location south, Location north, bool isLegal)
        {
            MovementTestInternal(south, north, Movement.North, isLegal, nameof(Movement.North));
            MovementTestInternal(north, south, Movement.South, isLegal, nameof(Movement.South));
        }

        [TestCaseSource(nameof(NorthEastSouthWestCases))]
        public void NorthEastSouthWestMovementTest(Location southWest, Location northEast, bool isLegal, bool isReciprocal)
        {
            MovementTestInternal(southWest, northEast, Movement.NorthEast, isLegal, nameof(Movement.NorthEast));
            MovementTestInternal(northEast, southWest, Movement.SouthWest, isLegal && isReciprocal, nameof(Movement.SouthWest));
        }

        [TestCaseSource(nameof(NorthWestSouthEastCases))]
        public void NorthWestSouthEastMovementTest(Location southEast, Location northWest, bool isLegal, bool isReciprocal)
        {
            MovementTestInternal(southEast, northWest, Movement.NorthWest, isLegal, nameof(Movement.NorthWest));
            MovementTestInternal(northWest, southEast, Movement.SouthEast, isLegal && isReciprocal, nameof(Movement.SouthEast));
        }

        private void MovementTestInternal(Location from, Location to,
            Func<Location, bool, bool, Location> moverFunc, bool isLegal, string moveName)
        {
            try
            {
                var actualTo = moverFunc(from, true, true);
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

            cases.Add(new object[] { Location.A5, Location.A1, true});
            cases.Add(new object[] { Location.B2, Location.B3, true});
            cases.Add(new object[] { Location.F7, Location.F8, true});
            cases.Add(new object[] { Location.E9, Location.E1, true});
            cases.Add(new object[] { Location.I1, Location.I2, true});

            return cases;
        }

        public static List<object[]> NorthEastSouthWestCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { Location.E9, Location.A5, true, false});
            cases.Add(new object[] { Location.A3, Location.B4, true, true});
            cases.Add(new object[] { Location.I2, Location.Undefined, false, false});
            cases.Add(new object[] { Location.I5, Location.A1, true, true});
            cases.Add(new object[] { Location.A5, Location.B6, true, true});

            return cases;
        }

        public static List<object[]> NorthWestSouthEastCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { Location.E9, Location.I5, true, false});
            cases.Add(new object[] { Location.A5, Location.I1, true, true});
            cases.Add(new object[] { Location.A3, Location.Undefined, false, false});
            cases.Add(new object[] { Location.I5, Location.H6, true, true});
            cases.Add(new object[] { Location.F4, Location.E5, true, true});

            return cases;
        }
    }
}