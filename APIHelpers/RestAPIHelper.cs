using PageObjectModel_Specflow.ConstantHelpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.APIHelpers
{
    public class RestAPIHelper
    {
        private RestClient restClient;
        private RestRequest request;
        private RestResponse response;

        public RestResponse sendgetordeleterestapirequest(string endpoint, Method method)
        {
            restClient = new RestClient(FrameworkConstants.APIBaseUrl);
            request = new RestRequest(endpoint, method);
            response = restClient.Execute(request);
            return response;
        }

        public RestResponse sendrestapirequest(string endpoint,Method method, RequestModel body)
        {
            restClient = new RestClient(FrameworkConstants.APIBaseUrl);
            request = new RestRequest(endpoint, method);
            request.AddJsonBody(body);
            response = restClient.Execute(request);
            return response;
        }
    }
}
