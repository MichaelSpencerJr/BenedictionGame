using System;
using Benediction.Board;

namespace Benediction.Game
{
    /// <summary>
    /// Aggregate game state transition which wraps four other transitions,
    /// intended to represent a red-red-blue-blue game turn.
    /// </summary>
    public class GameTurn : StateTransition
    {
        public StateTransition Red1 { get; set; }
        public StateTransition Red2 { get; set; }
        public StateTransition Blue1 { get; set; }
        public StateTransition Blue2 { get; set; }
        public override string ToString() => $"{Red1,8} {Red2,8} / {Blue1,8} {Blue2,8}";

        public override int EmptyColumn
        {
            get
            {
                if (Red1 == null || Red1 is NullAction) return 0;
                if (Red2 == null || Red2 is NullAction) return 1;
                if (Blue1 == null || Blue1 is NullAction) return 2;
                if (Blue2 == null || Blue2 is NullAction) return 3;
                return -1;
            }
        }

        public new State InitialState => Red1.InitialState;
        public new State NewState
        {
            get
            {
                switch (EmptyColumn)
                {
                    case 0: return Red1.InitialState;
                    case 1: return Red1.NewState;
                    case 2: return Red2.NewState;
                    case 3: return Blue1.NewState;
                    default: return Blue2.NewState;
                }
            }
        }

        public StateTransition this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return Red1;
                    case 1: return Red2;
                    case 2: return Blue1;
                    case 3: return Blue2;
                    default: return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Red1 = value;
                        break;
                    case 1:
                        Red2 = value;
                        break;
                    case 2:
                        Blue1 = value;
                        break;
                    case 3:
                        Blue2 = value;
                        break;
                    default: throw new IndexOutOfRangeException("Valid move indices are 0, 1, 2, or 3.");
                }
            }
        }

        public GameTurn(State initialState)
        {
            Red1 = new NullAction();
            Red2 = new NullAction();
            Blue1 = new NullAction();
            Blue2 = new NullAction();
        }
    }
}