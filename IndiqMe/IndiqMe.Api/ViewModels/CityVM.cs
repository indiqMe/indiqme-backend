using System;
using Newtonsoft.Json;

namespace IndiqMe.Api.ViewModels
{
    public class CityVM
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }
    }
}
