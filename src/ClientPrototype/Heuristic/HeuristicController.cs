using System;
using System.Collections.Generic;
using System.Linq;
using Benediction.Board;
using Benediction.Controller;
using Benediction.Model;

namespace Benediction.Heuristic
{
    public class HeuristicController
    {
        public Dictionary<string, double> Weights { get; protected set; } = new Dictionary<string, double>(StringComparer.InvariantCultureIgnoreCase);

        public Dictionary<string, ClassifierBase> Classifiers { get; protected set; } =
            new Dictionary<string, ClassifierBase>(StringComparer.InvariantCultureIgnoreCase);

        public HeuristicController()
        {
            Weights[nameof(PieceCount)] = 1d;
            Weights[nameof(StackCount)] = 1d;
            Weights[nameof(BlessCount)] = 1d;
            Weights[nameof(CurseCount)] = -1d;
            Weights[nameof(KingCount)] = -1d;
            Weights[nameof(WinLose)] = 1d;
            Classifiers[nameof(PieceCount)] = new PieceCount();
            Classifiers[nameof(StackCount)] = new StackCount();
            Classifiers[nameof(BlessCount)] = new BlessCount();
            Classifiers[nameof(CurseCount)] = new CurseCount();
            Classifiers[nameof(KingCount)] = new KingCount();
            Classifiers[nameof(WinLose)] = new WinLose();
        }

        public double GetScore(State state)
        {
            double retval = 0;
            foreach (var weight in Weights)
            {
                if (!Classifiers.ContainsKey(weight.Key)) continue;
                retval += weight.Value * Classifiers[weight.Key].Score(state);
            }

            return retval;
        }

/*    if depth = 0 or node is a terminal node then
        return the heuristic value of node
    if maximizingPlayer then
        value := −∞
        for each child of node do
            value := max(value, alphabeta(child, depth − 1, α, β, FALSE))
            α := max(α, value)
            if α ≥ β then
                break (* β cut-off *)
        return value
    else
        value := +∞
        for each child of node do
            value := min(value, alphabeta(child, depth − 1, α, β, TRUE))
            β := min(β, value)
            if α ≥ β then
                break (* α cut-off *)
        return value*/

        public double AlphaBeta(State state, int depth)
        {
            var maximizingPlayer = state.Flags.IsRedTurn();
            var seenStates = new HashSet<Guid>();
            return AlphaBetaInternal(state, depth, double.NegativeInfinity, double.PositiveInfinity, maximizingPlayer,
                state.Flags.IsSecondTurn(), seenStates);
        }

        private double AlphaBetaInternal(State state, int depth, double alpha, double beta, bool maximizingPlayer,
            bool secondTurn, HashSet<Guid> seenStates)
        {
            if (depth == 0 || state.Flags.GameEnded()) return GetScore(state);

            if (maximizingPlayer)
            {
                var v = double.NegativeInfinity;
                foreach (var proposed in AvailableActionController.GetAvailableActions(state, seenStates).OrderByDescending(kvp => kvp.Value.Heuristic))
                {
                    v = Math.Max(v, AlphaBetaInternal(proposed.Value.Result, depth - 1, alpha, beta,
                        secondTurn ^ maximizingPlayer, !secondTurn, seenStates));
                    alpha = Math.Max(alpha, v);
                    if (alpha >= beta) break;
                }

                return v;
            }
            else
            {
                var v = double.PositiveInfinity;
                foreach (var proposed in AvailableActionController.GetAvailableActions(state, seenStates)
                    .OrderByDescending(kvp => kvp.Value.Heuristic))
                {
                    v = Math.Min(v, AlphaBetaInternal(proposed.Value.Result, depth - 1, alpha, beta,
                        secondTurn ^ maximizingPlayer, !secondTurn, seenStates));
                    beta = Math.Min(beta, v);
                    if (alpha >= beta) break;
                }

                return v;
            }

        }
//grabbing space, having more space:
//I see this as a linear rank of the total number of spaces on the board your current pieces could possibly move to.  More or less?

//having more pieces on the board:
//Seems straightforward: total count of pieces/stacks of your color on the board

//having more stacks:
//Seems like this would overlap a bit with grabbing space, as a larger stack number can attack more board spaces . . . but this could be an additional bonus that encourages creating stacks more than, say, moving existing stacks farther apart to increase their attack area.

//penalty for splitting:
//grabbing space seems like it'd naturally discourage this but maybe this is an additional penalty.  A board heuristic doesn't know what move led to the current board, though, so I feel like we'd capture this by penalizing cursed pieces of scoring an X+Y stack higher than the score of X and the score of Y combined.

//undo penalty if blesses split pieces:
//So maybe the penalty is just for the count of cursed pieces.

//undo penalty if captures critical opponent defenders:
//A board score is going to be your side's heuristic score minus your opponent's heuristic score, so I think the opponent score would be naturally diminished by such a loss anyway.

//opponent zone blockades:
//Seems straightforward: blockades adjacent opponent home. Could be deployed as two opposite blockades or as three 120-degree-apart blockades I think, so maybe there are separate tunable bonuses for each.

//blockades preventing blockades in own zone:
//Also straightforward: number of spaces adjacent your own home where a blockade is illegal due to existing blockades.  It seems there are some spaces which protect 1 zone space, and some spaces which protect 2 zone spaces.

//blessed pieces:
//Maybe this bonus can grow according to the largest reachable friendly stack you could merge with.

//cursed men in or adjacent opponent zone:
//maybe separate bonuses for each (in vs adjacent)

//controlling a corridor:
//How would you describe a corridor?  Any contiguous path of board spaces leading between red and blue walls?  Or more general regions of the board?
//How would you define control?  Occupying or threatening most of the board spaces, with your opponent occupying or threatening few of the board spaces?

    }
}
