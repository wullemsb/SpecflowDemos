using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowDemos
{
    [Binding]
    public class SpecflowDemosSteps
    {
        List<Person> _persons = new List<Person>();
        Person _foundPerson = null;

        [Given(@"I have the following persons")]
        public void GivenIHaveTheFollowingPersons(Table table)
        {
            foreach (var row in table.Rows)
            {
                var person = new Person();
                person.FirstName = row["FirstName"];
                person.LastName = row["LastName"];
                _persons.Add(person);
            }
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(string firstName)
        {
            _foundPerson = _persons.FirstOrDefault(p => p.FirstName == firstName);
        }

        [Then(@"the following person should be returned")]
        public void ThenTheFollowingPersonShouldBeReturned(Table table)
        {
            var person = new Person();
            person.FirstName = table.Rows[0]["FirstName"];
            person.LastName = table.Rows[0]["LastName"];

            Assert.AreEqual(person.FirstName, _foundPerson.FirstName);
            Assert.AreEqual(person.LastName, _foundPerson.LastName);

        }
    }
}
