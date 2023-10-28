using Newtonsoft.Json;
using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class PATCH_Request_StepDefinitions
    {
        private RestResponse response;

        RestAPIHelper restapiHelper = new RestAPIHelper();

        [Given(@"the user sends a patch request with end point as ""([^""]*)""")]
        public void GivenTheUserSendsAPatchRequestWithEndPointAs(string endpoint)
        {
            
            var User = new RequestModel
            {
                name = "raviukolte",
               
            };
            response = restapiHelper.sendrestapirequest(endpoint, Method.Patch, User);
        }

        [Then(@"the data should be updated using patch request")]
        public void ThenTheDataShouldBeUpdatedUsingPatchRequest()
        {
            int actualStatusCode = (int)response.StatusCode;
            var User = new RequestModel
            {
                name = "raviukolte",
              
            };

            Assert.AreEqual(200, actualStatusCode);
            var actualResponseModel = JsonConvert.DeserializeObject<RequestModel>(response.Content);
            Console.WriteLine(response.Content);
            // Use NUnit assertions to validate the response content
            Assert.AreEqual(User.name, actualResponseModel.name, "Name should match");
           
        }

       
    }
}
