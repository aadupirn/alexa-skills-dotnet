using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class ResolutionAuthority
    {
        [JsonProperty("authority")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public ResolutionStatus Status { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public ResolutionValueContainer[] Values { get; set; }
    }
}
