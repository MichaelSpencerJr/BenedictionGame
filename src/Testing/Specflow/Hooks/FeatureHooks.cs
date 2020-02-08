using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Bindings;
using Testing.SpecFlow.Context;
using Testing.SpecFlow.Hooks;

namespace Testing.SpecFlow.Hooks
{
    [Binding]
    public static class FeatureHooks
    {
        [BeforeFeature(Order = 1)]
        public static void FeatureSetup(FeatureContext featureContext)
        {

        }

        [AfterFeature(Order = 1)]
        public static void FeatureTeardown(FeatureContext featureContext)
        {

        }

        [BeforeFeature("every-change", Order = 101)]
        public static void FeatureImageEveryChange(FeatureContext featureContext)
        {
            featureContext.ImageBehavior(BoardImageBehavior.EveryChange);
        }
        
        [BeforeFeature("step-image-only", Order = 102)]
        public static void FeatureImageEveryStep(FeatureContext featureContext)
        {
            featureContext.ImageBehavior(BoardImageBehavior.EveryStep);
        }

        [BeforeFeature("scenario-image-only", Order = 103)]
        public static void FeatureImageEveryScenario(FeatureContext featureContext)
        {
            featureContext.ImageBehavior(BoardImageBehavior.EveryScenario);
        }

        [BeforeFeature("no-images", Order = 104)]
        public static void FeatureImageNever(FeatureContext featureContext)
        {
            featureContext.ImageBehavior(BoardImageBehavior.NoImages);
        }

    }
}
