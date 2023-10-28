using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class GET_Request_StepDefinitions
    {
 
        private RestResponse response;

        RestAPIHelper restapiHelper = new RestAPIHelper();  

        [Given(@"the user sends a get request with end point as ""([^""]*)""")]
        public void GivenTheUserSendsAGetRequestWithEndPointAs(string endpoint)
        {
            response = restapiHelper.sendgetordeleterestapirequest(endpoint, Method.Get);
        }
     
        [Then(@"the response status code should be (.*)s")]
        public void ThenTheResponseStatusCodeShouldBeS(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Console.WriteLine(response.Content);
            Assert.AreEqual(expectedStatusCode, actualStatusCode);
        }
    }
}
