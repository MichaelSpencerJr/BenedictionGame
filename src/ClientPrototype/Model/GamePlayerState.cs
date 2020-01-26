using System;

namespace Benediction.Model
{
    [Flags]
    public enum GamePlayerState
    {
        /// <summary>No valid game interface state information</summary>
        Undefined,
 
        /// <summary>Title screen and initial mode selection</summary>
        TitleScreen = 0x01,
        
        /// <summary>Game is in progress</summary>
        GameInProgress = 0x02,
        
        /// <summary>Showing History State</summary>
        ShowingHistory = 0x04,
        
        /// <summary>Board is being edited</summary>
        BoardEditor = 0x08,
        
        /// <summary>Local Player Controls Red</summary>
        LocalControlsRed = 0x10,
        
        /// <summary>Local Player Controls Blue</summary>
        LocalControlsBlue = 0x20,
        
        /// <summary>CPU Player Is Connected</summary>
        CpuPlayerConnected = 0x40,
        
        /// <summary>Networked Player Is Connected</summary>
        NetworkPlayerConnected = 0x80,
    }
}