using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;

namespace Benediction.View
{
    public interface IGamePlayerView
    {
        event EventHandler<BoardLocationEventArgs> InputEvent;
        event EventHandler<BoardNavigationEventArgs> NavigateEvent;
        void RedrawBoard();
        void RedrawMoves();
    }

    public class BoardLocationEventArgs
    {
        public Location Location { get; set; }
        public BoardMouseEventType MouseEvent { get; set; }
    }

    public enum BoardMouseEventType
    {
        Undefined,
        Hover,
        LeftClick,
        RightClick,
        LeftDragStart,
        RightDragStart,
        LeftDragEnd,
        RightDragEnd
    }

    public class BoardNavigationEventArgs
    {
        public NavigationEventType EventType { get; set; }
        public State Selected { get; set; }
    }

    public enum NavigationEventType
    {
        Undefined,
        ShowHistory,
        ShowCurrent,
        NewGame
    }
}
