using VoicifyAlexa.NET.ConnectionTasks;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request.Type
{
    public class LaunchRequestTask
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("input")]
        public IConnectionTask Input { get; set; }
    }
}