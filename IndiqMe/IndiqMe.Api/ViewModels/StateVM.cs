using System;
using Newtonsoft.Json;

namespace IndiqMe.Api.ViewModels
{
    public class StateVM
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sigla")]
        public string Initials { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("regiao")]
        public Region Region { get; set; }
    }

    public class Region
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sigla")]
        public string Initials { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }
    }

}
