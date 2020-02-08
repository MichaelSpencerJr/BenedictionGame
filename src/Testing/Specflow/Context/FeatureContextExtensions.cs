using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Testing.SpecFlow.Context
{
    public static class FeatureContextExtensions
    {
        public static BoardImageBehavior ImageBehavior(this FeatureContext featureContext)
        {
            if (featureContext.TryGetValue<BoardImageBehavior>(nameof(ImageBehavior), out var behavior))
                return behavior;
            featureContext[nameof(ImageBehavior)] = BoardImageBehavior.EveryChange;
            return BoardImageBehavior.EveryChange;
        }

        public static void ImageBehavior(this FeatureContext featureContext, BoardImageBehavior imageBehavior)
        {
            featureContext[nameof(ImageBehavior)] = imageBehavior;
        }
    }
}
