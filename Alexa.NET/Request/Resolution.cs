using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class Resolution
    {
        [JsonProperty("resolutionsPerAuthority")]
        public ResolutionAuthority[] Authorities { get; set; }
    }
}
