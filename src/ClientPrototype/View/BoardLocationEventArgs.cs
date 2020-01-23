using Benediction.Board;

namespace Benediction.View
{
    public class BoardLocationEventArgs
    {
        public Location Location { get; set; }
        public BoardMouseEventType MouseEvent { get; set; }
    }
}