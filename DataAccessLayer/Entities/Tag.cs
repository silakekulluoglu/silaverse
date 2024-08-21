using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Tag
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("tag")]
        public string? TagName { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("things_url")]
        public string? ThingsUrl { get; set; }

        [JsonPropertyName("absolute_url")]
        public string? AbsoluteUrl { get; set; }
    }
}
