using Newtonsoft.Json.Linq;
using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using Newtonsoft.Json;

namespace APITesting_Specflow.StepDefinitions
{


    [Binding]
    public class GET_Request_StepDefinitions
    {

        private RestResponse response;
        RestAPIHelper restapiHelper = new RestAPIHelper();
        dynamic data;

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


        [Then(@"I print the email addresses")]
        public void ThenIprinttheemailaddresses()
        {
            data = JsonConvert.DeserializeObject(response.Content);
            foreach (var user in data.data)
            {
                Console.WriteLine(user.email);
            }

        }

        [Then(@"I print the user details")]
        public void ThenIPrintTheUserDetails()
        {
            data = JsonConvert.DeserializeObject(response.Content);
            foreach (var user in data.data)
            {
                Console.WriteLine($"User ID: {user}");
            }

        }
    }
}

