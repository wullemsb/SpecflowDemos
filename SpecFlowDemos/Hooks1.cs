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

        [BeforeScenario("normalscenario")]
        public void BeforeScenario()
        {
            Trace.WriteLine("Before scenario");
        }

        [BeforeStep("specialscenario")]
        public void BeforeStep()
        {
            Trace.WriteLine("Before special step");
        }

        [AfterStep("normalscenario")]
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
