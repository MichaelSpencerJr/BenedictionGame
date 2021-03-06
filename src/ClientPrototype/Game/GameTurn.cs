﻿using System;
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
                if (Blue2 == null || Blue2 is NullAction) return 3;
                if (Blue1 == null || Blue1 is NullAction) return 2;
                if (Red2 == null || Red2 is NullAction) return 1;
                if (Red1 == null || Red1 is NullAction) return 0;
                return -1;
            }
        }

        public new State InitialState
        {
            get
            {
                if (Red1.InitialState.Unset)
                {
                    if (Red1.NewState.Unset)
                    {
                        if (Red2.NewState.Unset)
                        {
                            if (Blue1.NewState.Unset)
                            {
                                return Blue2.NewState;
                            }

                            return Blue1.NewState;
                        }

                        return Red2.NewState;
                    }

                    return Red1.NewState;
                }

                return Red1.InitialState;
            }
        }

        public override State NewState
        {
            get
            {
                if (Blue2.NewState.Unset)
                {
                    if (Blue1.NewState.Unset)
                    {
                        if (Red2.NewState.Unset)
                        {
                            if (Red1.NewState.Unset)
                            {
                                return Red1.InitialState;
                            }

                            return Red1.NewState;
                        }

                        return Red2.NewState;
                    }

                    return Blue1.NewState;
                }

                return Blue2.NewState;
            }
            set
            {
                switch (EmptyColumn)
                {
                    case 0: Red1.InitialState = value;
                        break;
                    case 1: Red1.NewState = value;
                        break;
                    case 2: Red2.NewState = value;
                        break;
                    case 3: Blue1.NewState = value;
                        break;
                    default: Blue2.NewState = value;
                        break;
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