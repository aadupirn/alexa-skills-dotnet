using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class Application
    {
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }
    }
}
