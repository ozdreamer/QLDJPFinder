using System.Collections.Generic;
using Newtonsoft.Json;

namespace QLDJPFinder.Core
{
    public class APIJSONObject
    {
        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("result")]
        public APIJSONResult Result { get; set; }
    }

    public class APIJSONResult
    {
        [JsonProperty("include_total")]
        public bool IncludeTotal { get; set; }

        [JsonProperty("resource_id")]
        public string ResourceId { get; set; }

        [JsonProperty("fields")]
        public List<APIJSONField> Fields { get; set; }

        [JsonProperty("records_format")]
        public string RecordsFormat { get; set; }

        [JsonProperty("records")]
        public List<JPInfo> Records { get; set; }
    }

    public class APIJSONField
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
