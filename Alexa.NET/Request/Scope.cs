using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class Scope
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
