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
    public class StateController : Controller
    {

        private readonly IGenericRequest _genericRequest;

        public StateController(IGenericRequest genericRequest)
        {
            _genericRequest = genericRequest;
        }

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            string request = _genericRequest.ReturnJson(null, null, Method.GET, "http://servicodados.ibge.gov.br/api/v1/localidades/estados/");
            return request;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
