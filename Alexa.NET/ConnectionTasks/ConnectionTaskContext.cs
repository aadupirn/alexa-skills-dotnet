using Newtonsoft.Json;

namespace VoicifyAlexa.NET.ConnectionTasks
{
    public class ConnectionTaskContext
    {
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
    }
}