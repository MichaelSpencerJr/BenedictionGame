namespace Benediction.Model
{
    public enum SelectionState
    {
        /// <summary>No valid state information</summary>
        Undefined,

        /// <summary>No selection has been made</summary>
        Unselected,

        /// <summary>User has selected an empty space</summary>
        EmptySelected,

        /// <summary>User has picked up a full piece and is selecting a destination or target</summary>
        PieceInHand,

        /// <summary>User has picked up part of a piece and is selecting a destination or target</summary>
        SplitInHand,

        /// <summary>User has selected both endpoints of a move</summary>
        MoveSelected,
    }
}