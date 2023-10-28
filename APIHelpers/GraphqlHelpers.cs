using PageObjectModel_Specflow.ConstantHelpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.APIHelpers
{
    public class GraphqlHelpers
    {
        private RestClient restClient;
        private RestRequest request;
        private RestResponse response;

        public RestResponse sendgraphqlrequest(string query)
        {
            restClient = new RestClient(FrameworkConstants.GraphqlBaseUrl);
            request = new RestRequest(FrameworkConstants.GraphqlEndpoint, Method.Post); // needs to be sent as a post request
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", FrameworkConstants.bearertoken);
            request.AddParameter("application/json", query, ParameterType.RequestBody);
            response = restClient.Execute(request);
            return response;
        }
    }
}
