using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace SpecFlowDemos
{
    [Binding]
    public class SpecflowDemosSteps
    {
        IEnumerable<Person> _persons=null;
        Person _foundPerson = null;

        [Given(@"I have the following persons")]
        public void GivenIHaveTheFollowingPersons(Table table)
        {
            _persons = table.CreateSet<Person>();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(string firstName)
        {
            _foundPerson = _persons.FirstOrDefault(p => p.FirstName == firstName);
        }

        [Then(@"the following person should be returned")]
        public void ThenTheFollowingPersonShouldBeReturned(Table table)
        {
            table.CompareToInstance(_foundPerson);
        }
    }
}
