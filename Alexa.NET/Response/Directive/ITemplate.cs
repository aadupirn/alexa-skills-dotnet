using System;
using VoicifyAlexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.Directive
{
    [JsonConverter(typeof(TemplateConverter))]
    public interface ITemplate
    {
        [JsonProperty("type", Required = Required.Always)]
        string Type { get; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        string Token { get; set; }
    }
}