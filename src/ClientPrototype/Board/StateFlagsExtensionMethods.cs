using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Board
{
    public static class StateFlagsExtensionMethods
    {
        public static bool IsRedTurn(this StateFlags flags) =>
            flags.HasFlag(StateFlags.RedAction1) || flags.HasFlag(StateFlags.RedAction2);

        public static bool IsBlueTurn(this StateFlags flags) =>
            flags.HasFlag(StateFlags.BlueAction1) || flags.HasFlag(StateFlags.BlueAction2);

        public static bool IsSecondTurn(this StateFlags flags) =>
            flags.HasFlag(StateFlags.RedAction2) || flags.HasFlag(StateFlags.BlueAction2);

        public static bool GameEnded(this StateFlags flags) =>
            (flags & (StateFlags.RedAction1 | StateFlags.RedAction2 | StateFlags.BlueAction1 |
                      StateFlags.BlueAction2)) == 0;

        public static bool GameWon(this StateFlags flags) =>
            flags.HasFlag(StateFlags.RedWin) || flags.HasFlag(StateFlags.BlueWin);

        public static StateFlags SetFlag(this StateFlags flags, StateFlags targetFlag, bool value) =>
            value ? flags | targetFlag : flags & ~targetFlag;

        public static StateFlags ReplaceFlag(this StateFlags flags, StateFlags flagToRemove, StateFlags flagToAdd) =>
            (flags & ~flagToRemove) | flagToAdd;

        public static StateFlags NextTurn(this StateFlags flags)
        {
            if (flags.GameWon())
            {
                return flags & (StateFlags.BlueKingTaken | StateFlags.RedKingTaken | StateFlags.BlueWin |
                                StateFlags.RedWin);
            }

            if (flags.IsSecondTurn())
            {
                if (flags.IsRedTurn())
                {
                    return flags.ReplaceFlag(StateFlags.RedAction2, StateFlags.BlueAction1);
                }

                return flags.ReplaceFlag(StateFlags.BlueAction2, StateFlags.RedAction1);
            }

            if (flags.IsBlueTurn())
            {
                return flags.ReplaceFlag(StateFlags.BlueAction1, StateFlags.BlueAction2);
            }

            return flags.ReplaceFlag(StateFlags.RedAction1, StateFlags.RedAction2);
        }

        public static StateFlags HandleKingCaptureFlag(this StateFlags flags)
        {
            if (flags.HasFlag(StateFlags.RedKingTaken))
            {
                return flags | StateFlags.BlueWin;
            }

            if (flags.HasFlag(StateFlags.BlueKingTaken))
            {
                return flags | StateFlags.RedWin;
            }

            return flags;
        }
    }
}
