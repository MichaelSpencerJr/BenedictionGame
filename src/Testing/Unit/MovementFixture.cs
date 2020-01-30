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
            var actualTo = moverFunc(from, true, true);
            if (actualTo == Location.Undefined)
            {
                Assert.IsFalse(isLegal, "{0} move from {1} was illegal but was expected to be allowed.", moveName,
                    from);
            }
            else
            {
                Assert.True(isLegal, "{0} move from {1} was allowed but was expected to be illegal", moveName,
                    from);
                Assert.AreEqual(to, actualTo,
                    "{0} move from {1} was expected to go to {2} but actually went to {3}.",
                    moveName, from, to, actualTo);
                Console.WriteLine($"{moveName} from {from} leads to {to}");
            }
        }

        public static List<object[]> NorthSouthCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { Location.A5, Location.A1, true});
            cases.Add(new object[] { Location.B6, Location.B1, true});
            cases.Add(new object[] { Location.C7, Location.C1, true});
            cases.Add(new object[] { Location.D8, Location.D1, true});
            cases.Add(new object[] { Location.E9, Location.E1, true});
            cases.Add(new object[] { Location.F8, Location.F1, true});
            cases.Add(new object[] { Location.G7, Location.G1, true});
            cases.Add(new object[] { Location.H6, Location.H1, true});
            cases.Add(new object[] { Location.I5, Location.I1, true});
            cases.Add(new object[] { Location.B2, Location.B3, true});
            cases.Add(new object[] { Location.F7, Location.F8, true});

            return cases;
        }

        public static List<object[]> NorthEastSouthWestCases()
        {
            var cases = new List<object[]>();

            cases.Add(new object[] { Location.A3, Location.B4, true, true});
            cases.Add(new object[] { Location.B2, Location.C3, true, true});
            cases.Add(new object[] { Location.I2, Location.Undefined, false, false});
            cases.Add(new object[] { Location.F7, Location.G7, true, true});
            cases.Add(new object[] { Location.A5, Location.B6, true, true});
            cases.Add(new object[] { Location.B6, Location.C7, true, true});
            cases.Add(new object[] { Location.C7, Location.D8, true, true});
            cases.Add(new object[] { Location.D8, Location.E9, true, true});
            cases.Add(new object[] { Location.E9, Location.A5, true, false});
            cases.Add(new object[] { Location.F8, Location.A4, true, false});
            cases.Add(new object[] { Location.G7, Location.A3, true, false});
            cases.Add(new object[] { Location.H6, Location.A2, true, false});
            cases.Add(new object[] { Location.I5, Location.A1, true, true});
            cases.Add(new object[] { Location.A1, Location.B2, true, true});
            cases.Add(new object[] { Location.B1, Location.C2, true, true});
            cases.Add(new object[] { Location.C1, Location.D2, true, true});
            cases.Add(new object[] { Location.D1, Location.E2, true, true});
            cases.Add(new object[] { Location.E1, Location.F1, true, true});
            cases.Add(new object[] { Location.F1, Location.G1, true, true});
            cases.Add(new object[] { Location.G1, Location.H1, true, true});
            cases.Add(new object[] { Location.H1, Location.I1, true, true});
            cases.Add(new object[] { Location.I1, Location.Undefined, false, false});

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
            cases.Add(new object[] { Location.A5, Location.I1, true, true});
            cases.Add(new object[] { Location.B6, Location.I2, true, false});
            cases.Add(new object[] { Location.C7, Location.I3, true, false});
            cases.Add(new object[] { Location.D8, Location.I4, true, false});
            cases.Add(new object[] { Location.E9, Location.I5, true, false});
            cases.Add(new object[] { Location.F8, Location.E9, true, true});
            cases.Add(new object[] { Location.G7, Location.F8, true, true});
            cases.Add(new object[] { Location.H6, Location.G7, true, true});
            cases.Add(new object[] { Location.I5, Location.H6, true, true});
            cases.Add(new object[] { Location.B2, Location.A2, true, true});
            cases.Add(new object[] { Location.B1, Location.A1, true, true});
            cases.Add(new object[] { Location.C1, Location.B1, true, true});
            cases.Add(new object[] { Location.D1, Location.C1, true, true});
            cases.Add(new object[] { Location.E1, Location.D1, true, true});
            cases.Add(new object[] { Location.F1, Location.E2, true, true});
            cases.Add(new object[] { Location.G1, Location.F2, true, true});
            cases.Add(new object[] { Location.H1, Location.G2, true, true});
            cases.Add(new object[] { Location.I1, Location.H2, true, true});

            return cases;
        }
    }
}