namespace Benediction.View
{
    public enum NavigationEventType
    {
        /// <summary>Not set - invalid</summary>
        Undefined,

        /// <summary>Player indicates to erase the move in progress and reset the board editor state to the last committed state</summary>
        ClearMove,

        /// <summary>Player indicates to commit the move in progress and advance to the next turn</summary>
        CommitMove,

        /// <summary>Player indicates to show previous game state within the editor in a non-playable state</summary>
        ShowHistory,

        /// <summary>Player indicates to start a new game, erasing previous game history</summary>
        NewGame,

        /// <summary>Player indicates to load a previous game from saved game text</summary>
        LoadGame,

        /// <summary>Player indicates to enter or exit editor mode</summary>
        ToggleEditMode,

        /// <summary>Player indicates to commit a manually edited board as the game state used for the next turn</summary>
        Editor
    }
}