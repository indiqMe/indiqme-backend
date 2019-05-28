using System;
using System.Collections.Generic;
using RestSharp;

namespace IndiqMe.Service.RequestRestSharp
{
    public class GenericRequest : IGenericRequest
    {
        private RestRequest _request;
        private Dictionary<string, string> _headers;
        private Dictionary<string, string> _param;

        private void AddParam()
        {
            if (_param != null)
            {
                foreach (var item in _param)
                {
                    _request.AddParameter(item.Key, item.Value);
                }
            }
        }

        private void AddHeaders()
        {
            if (_headers != null)
            {
                foreach (var item in _headers)
                {
                    _request.AddHeader(item.Key, item.Value);
                }
            }
        }

        public string ReturnJson(Dictionary<string, string> Headers, Dictionary<string, string> Param, Method MethodType, string url)
        {
            _headers = Headers;
            _param = Param;
            _request = new RestRequest(MethodType);
            AddHeaders();
            AddParam();

            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            // execute the request
            IRestResponse response = client.Execute(_request);
            var content = response.Content; // raw content as string
            return content;

        }
    }
}
