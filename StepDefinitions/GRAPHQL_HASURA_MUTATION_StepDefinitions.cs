using NUnit.Framework;
using PageObjectModel_Specflow.APIHelpers;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting_Specflow.StepDefinitions
{
    [Binding]
    public class GRAPHQL_HASURA_MUTATION_StepDefinitions
    {

        private RestResponse response;
        GraphqlHelpers graphQLHelpers = new GraphqlHelpers();

        [Given(@"the user hits the graphql url for post request using hasura")]
        public void GivenTheUserHitsTheGraphqlUrlForPostRequestUsingHasura()
        {
            response = graphQLHelpers.sendgraphqlrequest(Queries.getgraphqlquery);
        }

        [Then(@"print the response and verify the response status code for graphql mutation")]
        public void ThenPrintTheResponseAndVerifyTheResponseStatusCodeForGraphqlMutation()
        {
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(200, actualStatusCode);
        }
    }
}
