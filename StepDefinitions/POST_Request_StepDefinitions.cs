using Newtonsoft.Json;
using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class POST_Request_StepDefinitions
    {

        private RestResponse response;

        RestAPIHelper restapiHelper = new RestAPIHelper();
         dynamic User;

        [Given(@"the user sends a post request with end point as ""([^""]*)""")]
        public void GivenTheUserSendsAPostRequestWithEndPointAs(string endpoint)
        {
            var User = new RequestModel
            {
                name = "ravik",
                job = "leader"
            };
            response = restapiHelper.sendrestapirequest(endpoint, Method.Post, User);


        }

        [Then(@"the user should get a success response")]
        public void ThenTheUserShouldGetASuccessResponse()
        {
            int actualStatusCode = (int)response.StatusCode;
            var User = new RequestModel
            {
                name = "ravik",
                job = "leader"
            };

            Assert.AreEqual(201, actualStatusCode);
            var actualResponseModel = JsonConvert.DeserializeObject<RequestModel>(response.Content);
            Console.WriteLine(response.Content);
            // Use NUnit assertions to validate the response content
            Assert.AreEqual(User.name, actualResponseModel.name, "Name should match");
            Assert.AreEqual(User.job, actualResponseModel.job, "Job should match");

        }

        [Then(@"I print the created user details")]
        public void ThenIprintthecreateduserdetails()
        {
          //  Console.WriteLine($"Name of new user is {response}");
            Console.WriteLine($"Name of new user is {User.job}");
            // Console.WriteLine("Response Body: " + response.Content);
        }


    }
}
