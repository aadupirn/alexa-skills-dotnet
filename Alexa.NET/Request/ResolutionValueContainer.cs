using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class ResolutionValueContainer
    {
        [JsonProperty("value")]
        public ResolutionValue Value { get; set; }
    }
}
