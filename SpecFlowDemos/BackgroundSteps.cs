using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemos
{
    [Binding]
    public class BackgroundSteps
    {
        private readonly Calculator _calculator;
        public BackgroundSteps(Calculator calculator)
        {
            _calculator = calculator;
        }


        [Given(@"I have reset the calculator")]
        public void GivenIHaveResetTheCalculator()
        {
            _calculator.Reset();
        }
    }
}
