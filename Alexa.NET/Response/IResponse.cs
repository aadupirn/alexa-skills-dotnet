using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    public interface IResponse
    {
        [JsonRequired]
        string Type { get; }
    }
}
