using Benediction.Board;

namespace Benediction.View
{
    public class BoardNavigationEventArgs
    {
        public NavigationEventType EventType { get; set; }
        public State Selected { get; set; }
    }
}