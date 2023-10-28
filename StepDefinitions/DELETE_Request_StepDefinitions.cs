using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class DELETE_Request_StepDefinitions
    {
        private RestResponse response;

        RestAPIHelper restapiHelper = new RestAPIHelper();

        [Given(@"the user sends a delete request with end point as ""([^""]*)""")]
        public void GivenTheUserSendsADeleteRequestWithEndPointAs(string endpoint)
        {
            response = restapiHelper.sendgetordeleterestapirequest(endpoint, Method.Delete); 
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                // Handle a successful deletion (status code 204 No Content) here
                Console.WriteLine("Deletion was successful!");

            }
            else
            {
                // Handle errors
                Console.WriteLine($"Deletion failed with status code: {response.StatusCode}");
                Console.WriteLine(response.Content);
            }
        }

        [Then(@"the validate the response code for delete request")]
        public void ThenTheValidateTheResponseCodeForDeleteRequest()
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(204, actualStatusCode);
        }
    }
}
