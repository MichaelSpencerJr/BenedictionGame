using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Controller;
using Benediction.Model;
using Benediction.View;

namespace Testing.SpecFlow.Mock
{
    class MockController : IGamePlayerController
    {
        public IGamePlayerModel Model { get; set; }
        public IGamePlayerView View { get; set; }
    }
}
