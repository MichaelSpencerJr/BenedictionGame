using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.View
{
    public interface IGamePlayerView
    {
        event EventHandler<BoardLocationEventArgs> InputEvent;
        event EventHandler<BoardNavigationEventArgs> NavigateEvent;
        void RedrawBoard();
        void UpdateGameMoveGrid();
        void BoardEditorUpdate();
    }
}
