using VoicifyAlexa.NET.ConnectionTasks;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Tests.Examples
{
    public class ExampleTask : IConnectionTask
    {
        public string ConnectionUri { get; set; }
        [JsonProperty("randomParameter")]
        public string RandomParameter { get; set; }
    }
}
