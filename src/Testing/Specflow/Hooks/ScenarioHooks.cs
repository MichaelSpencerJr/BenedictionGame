using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Testing.SpecFlow.Common;
using Testing.SpecFlow.Context;
using FeatureContext = TechTalk.SpecFlow.FeatureContext;

namespace Testing.SpecFlow.Hooks
{
    [Binding]
    public class ScenarioHooks
    {
        private readonly BoardStateContext _context;
        private readonly FeatureContext _featureContext;

        public ScenarioHooks(BoardStateContext injectedContext, FeatureContext featureContext)
        {
            _context = injectedContext;
            _featureContext = featureContext;
        }

        [BeforeScenario(Order = 1)]
        public void InitializeImageBehavior()
        {
            _context.ImageBehavior = _featureContext.ImageBehavior();
        }

        [BeforeScenario("every-change", Order = 101)]
        public void FeatureImageEveryChange()
        {
            _context.ImageBehavior = BoardImageBehavior.EveryChange;
        }

        [BeforeScenario("step-image-only", Order = 102)]
        public void FeatureImageEveryStep()
        {
            _context.ImageBehavior = BoardImageBehavior.EveryStep;
        }

        [BeforeScenario("scenario-image-only", Order = 103)]
        public void FeatureImageEveryScenario()
        {
            _context.ImageBehavior = BoardImageBehavior.EveryScenario;
        }

        [BeforeScenario("no-images", Order = 104)]
        public void FeatureImageNever()
        {
            _context.ImageBehavior = BoardImageBehavior.NoImages;
        }

        [AfterScenario(Order = 101)]
        public void ImageAfterScenario()
        {
            if (_context.ImageBehavior == BoardImageBehavior.EveryScenario && _context.BoardState != null)
            {
                Console.WriteLine(_context.BoardState.ImageMarkdown());
            }
        }

        [AfterStep(Order = 101)]
        public void ImageAfterStep()
        {
            if (_context.ImageBehavior == BoardImageBehavior.EveryStep &&
                _context.BoardState.BoardId != _context.LastPrintedBoard)
            {
                Console.WriteLine(_context.BoardState.ImageMarkdown());
            }
        }
    }
}
