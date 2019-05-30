using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndiqMe.Service.RequestRestSharp;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IndiqMe.Api.Controllers
{
    [Route("api/[controller]")]
    public class TechnologyController : Controller
    {
        private readonly IGenericRequest _genericRequest;

        public TechnologyController(IGenericRequest genericRequest)
        {
            _genericRequest = genericRequest;
        }
        // GET: api/values
        [HttpGet()]
        [Route("getall")]
        public string Get(string page)
        {
            var param = new Dictionary<string, string>();
            param.Add("page", page);
            param.Add("order", "desc");
            param.Add("sort", "popular");
            param.Add("site", "stackoverflow");

            var request = _genericRequest.ReturnJson(null, param, Method.GET, "https://api.stackexchange.com/2.2/tags");
            return request;

        }

        // GET api/values/5
        [HttpGet()]
        [Route("getname")]
        public string Get(string page, string name)
        {
            var param = new Dictionary<string, string>();
            param.Add("page", page);
            param.Add("order", "desc");
            param.Add("sort", "popular");
            param.Add("site", "stackoverflow");
            param.Add("inname", name.ToLower());

            var request = _genericRequest.ReturnJson(null, param, Method.GET, "https://api.stackexchange.com/2.2/tags");
            return request;

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
