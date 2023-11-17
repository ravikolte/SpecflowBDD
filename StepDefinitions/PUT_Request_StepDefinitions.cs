using Newtonsoft.Json;
using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class PUT_Request_StepDefinitions
    {
        private RestResponse response;
        private RequestModel user;

        RestAPIHelper restapiHelper = new RestAPIHelper();

        [Given(@"the user sends a put request with end point as ""([^""]*)""")]
        public void GivenTheUserSendsAPutRequestWithEndPointAs(string endpoint)
        {

            var User = new RequestModel
            {
                name = "ravikolte_",
                job = "leader"
            };
            response = restapiHelper.sendrestapirequest(endpoint, Method.Put, User);

        }

        [Then(@"the data should be updated using put request")]
        public void ThenTheDataShouldBeUpdatedUsingPutRequest()
        {
            int actualStatusCode = (int)response.StatusCode;
            var User = new RequestModel
            {
                name = "ravikolte_",
                job = "leader"
            };

            if (!(actualStatusCode == 200 || actualStatusCode == 201))
            {
                Console.WriteLine("Status code is neither 200 nor 201", actualStatusCode);
                Assert.Fail();
            }
            var actualResponseModel = JsonConvert.DeserializeObject<RequestModel>(response.Content);

            // Use NUnit assertions to validate the response content
            Assert.AreEqual(User.name, actualResponseModel.name, "Name should match");
            Assert.AreEqual(User.job, actualResponseModel.job, "Job should match");
        }

        [Given(@"the user wants to update a user with end point as ""([^""]*)""")]
        public void GivenTheUserWantsToUpdateAUserWithEndPointAs(string endpoint)
        {
            user = new RequestModel
            {
                name = "TusharD",
                job = "QA Automation Engineer"
            };
            response = restapiHelper.sendrestapirequest(endpoint, Method.Put, user);
        }

        [Then(@"the user should get a success response with updated user details")]
        public void ThenTheUserShouldGetASuccessResponseWithUpdatedUserDetails()
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(200, actualStatusCode);
            var actualResponseModel = JsonConvert.DeserializeObject<RequestModel>(response.Content);
            Console.WriteLine(response.Content);
            // Print actualResponseModel for debugging
            Console.WriteLine($"Actual Response Model: {JsonConvert.SerializeObject(actualResponseModel)}");

            // Use NUnit assertions to validate the response content
            Assert.AreEqual(user.name, actualResponseModel.name, "Name should match");
            Assert.AreEqual(user.job, actualResponseModel.job, "Job should match");
        }




    }
}
