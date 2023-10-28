using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace PageObjectModel_Specflow.StepDefinitions
{
    [Binding]
    public class DataDriven_StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public DataDriven_StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext["FirstNumber"] = number;

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            _scenarioContext["SecondNumber"] = number;

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            var firstNumber = (int)_scenarioContext["FirstNumber"];
            var secondNumber = (int)_scenarioContext["SecondNumber"];
            _scenarioContext["Result"] = firstNumber + secondNumber;



        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            var r = _scenarioContext["Result"];
            Assert.AreEqual(r, result);


        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            var firstNumber = (int)_scenarioContext["FirstNumber"];
            var secondNumber = (int)_scenarioContext["SecondNumber"];
            _scenarioContext["Result"] = firstNumber - secondNumber;


        }
    }
}
