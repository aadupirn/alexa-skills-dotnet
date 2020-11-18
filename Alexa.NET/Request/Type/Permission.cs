using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request.Type
{
    public class Permission
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}