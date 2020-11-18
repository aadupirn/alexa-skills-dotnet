using VoicifyAlexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    [JsonConverter(typeof(DirectiveConverter))]
    public interface IDirective
    {
        [JsonRequired]
        string Type { get; }
    }
}