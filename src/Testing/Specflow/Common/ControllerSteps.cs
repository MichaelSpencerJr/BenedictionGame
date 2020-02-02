using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Testing.Specflow.Common
{
    [Binding]
    public sealed class ControllerSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public ControllerSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }
    }
}
