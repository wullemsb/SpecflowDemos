using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowDemos
{
    [Binding]
    public class MyFirstSpecFlowScenarioSteps
    {
        private readonly Calculator _calculator;
        private List<int> _values=new List<int>();
        private int _result = 0;
        public MyFirstSpecFlowScenarioSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _values.Add(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           _result= _calculator.Add(_values.ToArray());
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, _result);
        }
    }
}
