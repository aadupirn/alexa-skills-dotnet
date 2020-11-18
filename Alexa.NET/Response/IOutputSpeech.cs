using VoicifyAlexa.NET.Response.Converters;
using VoicifyAlexa.NET.Response.Directive;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    [JsonConverter(typeof(OutputSpeechConverter))]
    public interface IOutputSpeech : IResponse
    {
        PlayBehavior? PlayBehavior { get; set; }
    }
}