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
          [Given(@"dat ik (.*) heb ingegeven in de rekenmachine")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _values.Add(p0);
        }

         [When(@"ik op add klik")]
        public void WhenIPressAdd()
        {
           _result= _calculator.Add(_values.ToArray());
        }


         [Then(@"moet het resultaat (.*) zijn")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, _result);
        }
    }
}
