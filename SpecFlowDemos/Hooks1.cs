using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemos
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Trace.WriteLine("Before scenario");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Trace.WriteLine("Before step");
        }

        [AfterStep]
        public void AfterStep()
        {
            Trace.WriteLine("After step");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Trace.WriteLine("After scenario");
        }
    }
}
