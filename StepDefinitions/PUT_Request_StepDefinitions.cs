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

            if(!(actualStatusCode == 200 || actualStatusCode == 201))
            {
                Console.WriteLine("Status code is neither 200 nor 201", actualStatusCode);
                Assert.Fail();
            }
            var actualResponseModel = JsonConvert.DeserializeObject<RequestModel>(response.Content);

            // Use NUnit assertions to validate the response content
            Assert.AreEqual(User.name, actualResponseModel.name, "Name should match");
            Assert.AreEqual(User.job, actualResponseModel.job, "Job should match");
        }
        
    }
}
