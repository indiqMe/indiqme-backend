using System;
using RestSharp;
using System.Collections.Generic;

namespace IndiqMe.Service.RequestRestSharp
{
    public interface IGenericRequest
    {
        string ReturnJson(Dictionary<string, string> Headers, Dictionary<string, string> Param, Method MethodType, string url);

    }
}
