using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;

namespace Benediction.Board.Measurement
{
    public static class StateHydration
    {
        //public static MeasuredState Hydrate(State state)
        //{
        //    var measured = new MeasuredState {State = state};
        //    SetBlocks(ref measured);
        //    var (redCurrent, blueCurrent) = BuildStackTypeSetCurrent(measured);

        //}

        private static void SetBlocks(ref MeasuredState measured)
        {
            foreach (var location in State.AllBoardLocations)
            {
                measured.Blocks[location] = measured.State[location].IsBlock();
            }
        }

        private static (StackTypeMeasurementSet, StackTypeMeasurementSet) BuildStackTypeSetCurrent(MeasuredState measured)
        {
            var redMs = new StackTypeMeasurementSet();
            var blueMs = new StackTypeMeasurementSet();

            foreach (var location in State.AllBoardLocations)
            {
                var current = measured.State[location];

                redMs.Normal.OneStack[location] = current == (Cell.SideRed | Cell.Size1);
                redMs.Normal.TwoStack[location] = current == (Cell.SideRed | Cell.Size2);
                redMs.Normal.ThreeStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Size2);
                redMs.Normal.FourStack[location] = current == (Cell.SideRed | Cell.Size4);
                redMs.Normal.FiveStack[location] = current.IsPiece() && current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && !current.IsKing() && !current.IsCursed();
                blueMs.Normal.OneStack[location] = current == Cell.Size1;
                blueMs.Normal.TwoStack[location] = current == Cell.Size2;
                blueMs.Normal.ThreeStack[location] = current == (Cell.Size1 | Cell.Size2);
                blueMs.Normal.FourStack[location] = current == Cell.Size4;
                blueMs.Normal.FiveStack[location] = current.IsPiece() && !current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && !current.IsKing() && !current.IsCursed();

                redMs.Blessed.OneStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Blessed);
                redMs.Blessed.TwoStack[location] = current == (Cell.SideRed | Cell.Size2 | Cell.Blessed);
                redMs.Blessed.ThreeStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Size2 | Cell.Blessed);
                redMs.Blessed.FourStack[location] = current == (Cell.SideRed | Cell.Size4 | Cell.Blessed);
                redMs.Blessed.FiveStack[location] = current.IsPiece() && current.RedPiece() && current.GetSize() > 4 && current.IsBlessed() && !current.IsKing() && !current.IsCursed();
                blueMs.Blessed.OneStack[location] = current == (Cell.Size1 | Cell.Blessed);
                blueMs.Blessed.TwoStack[location] = current == (Cell.Size2 | Cell.Blessed);
                blueMs.Blessed.ThreeStack[location] = current == (Cell.Size1 | Cell.Size2 | Cell.Blessed);
                blueMs.Blessed.FourStack[location] = current == (Cell.Size4 | Cell.Blessed);
                blueMs.Blessed.FiveStack[location] = current.IsPiece() && !current.RedPiece() && current.GetSize() > 4 && current.IsBlessed() && !current.IsKing() && !current.IsCursed();

                redMs.Cursed.OneStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Cursed);
                redMs.Cursed.TwoStack[location] = current == (Cell.SideRed | Cell.Size2 | Cell.Cursed);
                redMs.Cursed.ThreeStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Size2 | Cell.Cursed);
                redMs.Cursed.FourStack[location] = current == (Cell.SideRed | Cell.Size4 | Cell.Cursed);
                redMs.Cursed.FiveStack[location] = current.IsPiece() && current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && !current.IsKing() && current.IsCursed();
                blueMs.Cursed.OneStack[location] = current == (Cell.Size1 | Cell.Cursed);
                blueMs.Cursed.TwoStack[location] = current == (Cell.Size2 | Cell.Cursed);
                blueMs.Cursed.ThreeStack[location] = current == (Cell.Size1 | Cell.Size2 | Cell.Cursed);
                blueMs.Cursed.FourStack[location] = current == (Cell.Size4 | Cell.Cursed);
                blueMs.Cursed.FiveStack[location] = current.IsPiece() && !current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && !current.IsKing() && current.IsCursed();

                redMs.King.OneStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.King);
                redMs.King.TwoStack[location] = current == (Cell.SideRed | Cell.Size2 | Cell.King);
                redMs.King.ThreeStack[location] = current == (Cell.SideRed | Cell.Size1 | Cell.Size2 | Cell.King);
                redMs.King.FourStack[location] = current == (Cell.SideRed | Cell.Size4 | Cell.King);
                redMs.King.FiveStack[location] = current.IsPiece() && current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && current.IsKing() && !current.IsCursed();
                blueMs.King.OneStack[location] = current == (Cell.Size1 | Cell.King);
                blueMs.King.TwoStack[location] = current == (Cell.Size2 | Cell.King);
                blueMs.King.ThreeStack[location] = current == (Cell.Size1 | Cell.Size2 | Cell.King);
                blueMs.King.FourStack[location] = current == (Cell.Size4 | Cell.King);
                blueMs.King.FiveStack[location] = current.IsPiece() && !current.RedPiece() && current.GetSize() > 4 && !current.IsBlessed() && current.IsKing() && !current.IsCursed();
            }

            return (redMs, blueMs);
        }

        private static StackTypeMeasurementSet Project(StackTypeMeasurementSet initial, BitMeasurement blocks, bool isRed)
        {
            var next = initial;

            foreach (var pm in AllProjectedMoves(initial, blocks, isRed))
            {
                //Returned moves start from a self-owned piece and don't pass over any blockades -- that's all we know.
                //Options are move, merge, split-move, split-merge.
                if (initial.AnyPiece(pm.To))
                {

                }
            }

            return next;
        }

        private static BitMeasurement AddDrops(BitMeasurement normalSingles, BitMeasurement blocks, State initialState,
            bool isRed)
        {
            var home = isRed ? initialState.RedHome : initialState.BlueHome;

            foreach (var move in Movement.AllMoves)
            {
                var dropTarget = move(home, false, false);
                if (!Movement.IsValidLocation(dropTarget)) continue;
                if (normalSingles[dropTarget] || blocks[dropTarget]) continue;
                if (initialState[dropTarget].IsPiece() && initialState[dropTarget].RedPiece() != isRed) continue;
                normalSingles[dropTarget] = true;
            }

            return normalSingles;
        }

        private static IEnumerable<ProjectedMove> AllProjectedMoves(StackTypeMeasurementSet initial,
            BitMeasurement blocks, bool isRed)
        {
            foreach (var loc in State.AllBoardLocations)
            {
                if (!initial.AnyPiece(loc)) continue;

                foreach (var move in Movement.AllMoves)
                {
                    var one = initial.AnyOneStack(loc);
                    var two = initial.AnyTwoStack(loc);
                    var three = initial.AnyThreeStack(loc);
                    var four = initial.AnyFourStack(loc);
                    var five = initial.AnyFiveStack(loc);

                    if (one || two || three || four || five)
                    {
                        foreach (var pm in MoveGenerator(loc, 1, move, blocks, isRed))
                        {
                            yield return pm;
                        }
                    }

                    if (two || three || four || five)
                    {
                        foreach (var pm in MoveGenerator(loc, 2, move, blocks, isRed))
                        {
                            yield return pm;
                        }
                    }

                    if (three || four || five)
                    {
                        foreach (var pm in MoveGenerator(loc, 3, move, blocks, isRed))
                        {
                            yield return pm;
                        }
                    }

                    if (four || five)
                    {
                        foreach (var pm in MoveGenerator(loc, 4, move, blocks, isRed))
                        {
                            yield return pm;
                        }
                    }

                    if (five)
                    {
                        foreach (var pm in MoveGenerator(loc, 5, move, blocks, isRed))
                        {
                            yield return pm;
                        }
                    }
                }
            }
        }

        private static IEnumerable<ProjectedMove> MoveGenerator(Location loc, int size,
            Func<Location, bool, bool, Location> mover, BitMeasurement blocks, bool isRed)
        {
            var tPrev = loc;
            for (var i = 1; i <= size; i++)
            {
                var tCur = mover(tPrev, isRed, !isRed);
                if (!Movement.IsValidLocation(tCur) || blocks[tCur]) yield break;
                yield return new ProjectedMove
                    {From = loc, Size = size, To = tCur, Wrap = !Movement.IsValidLocation(mover(tPrev, false, false))};
                tPrev = tCur;
            }
        }
    }
}
