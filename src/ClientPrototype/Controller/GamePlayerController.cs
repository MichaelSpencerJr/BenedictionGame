using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Board;
using Benediction.Model;
using Benediction.View;

namespace Benediction.Controller
{
    public class GamePlayerController : IGamePlayerController
    {
        public IGamePlayerModel Model { get; set; }
        public IGamePlayerView View { get; set; }

        public void ClearMove()
        {
            Model.SelectionObject = Location.Undefined;
            Model.SelectionTarget = Location.Undefined;
            Model.EditorState = Model.CommittedState;
            Model.InHand = Cell.Empty;
            Model.SelectionState = SelectionState.Unselected;
            View.RedrawBoard();
        }

        public void CommitMove()
        {
            var (updatedModel, errorMessage) = Model.Game.CommitPlayerMove()
            ClearMove();
            View.RedrawMoves();
        }

        public GamePlayerController(IGamePlayerModel model, IGamePlayerView view)
        {
            Model = model;
            View = view;
            view.InputEvent += ViewOnInputEvent;
            view.NavigateEvent += ViewOnNavigateEvent;
            Model.CommittedState = Model.Game.Last().NewState;
            Model.AvailableActions =
                AvailableActionController.GetAvailableActions(Model.CommittedState, new HashSet<Guid>());
        }

        private void ViewOnNavigateEvent(object sender, BoardNavigationEventArgs e)
        {
            

        }

        private void ViewOnInputEvent(object sender, BoardLocationEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
