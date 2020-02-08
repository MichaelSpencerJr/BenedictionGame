﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Testing.SpecFlow.Common
{
    [Binding]
    public sealed class ViewSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public ViewSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }
    }
}
