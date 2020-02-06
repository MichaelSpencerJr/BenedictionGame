using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Bindings;
using Testing.SpecFlow.Hooks;

namespace Testing.SpecFlow.Hooks
{
    [Binding]
    public static class FeatureHooks
    {
        [BeforeFeature()]
        public static void FeatureSetup()
        {

        }

        [AfterFeature()]
        public static void FeatureTeardown()
        {

        }
    }
}
