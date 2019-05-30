using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IndiqMe.Api.ViewModels
{
    public class TechnologyVM
    {
        [JsonProperty("items")]
        public IList<Item> items { get; set; }

        [JsonProperty("has_more")]
        public bool has_more { get; set; }

        [JsonProperty("quota_max")]
        public int quota_max { get; set; }

        [JsonProperty("quota_remaining")]
        public int quota_remaining { get; set; }
    }
    public class Item
    {
        [JsonProperty("has_synonyms")]
        public bool has_synonyms { get; set; }

        [JsonProperty("is_moderator_only")]
        public bool is_moderator_only { get; set; }

        [JsonProperty("is_required")]
        public bool is_required { get; set; }

        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

}
