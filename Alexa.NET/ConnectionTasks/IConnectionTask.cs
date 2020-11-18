using System.Text;
using VoicifyAlexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.ConnectionTasks
{
    [JsonConverter(typeof(ConnectionTaskConverter))]
    public interface IConnectionTask
    {
        [JsonIgnore]
        string ConnectionUri { get; }
    }
}
