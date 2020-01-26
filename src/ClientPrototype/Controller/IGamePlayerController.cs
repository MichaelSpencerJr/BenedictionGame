using Benediction.Model;
using Benediction.View;

namespace Benediction.Controller
{
    public interface IGamePlayerController
    {
        IGamePlayerModel Model { get; set; }

        IGamePlayerView View { get; set; }
    }
}