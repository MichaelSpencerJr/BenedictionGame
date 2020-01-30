using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.View;

namespace Testing.SpecFlow.Mock
{
    class MockView : IGamePlayerView
    {
        public event EventHandler<BoardLocationEventArgs> InputEvent;
        public event EventHandler<BoardNavigationEventArgs> NavigateEvent;
        public void RedrawBoard()
        {
            throw new NotImplementedException();
        }

        public void UpdateGameMoveGrid()
        {
            throw new NotImplementedException();
        }

        public void BoardEditorUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
