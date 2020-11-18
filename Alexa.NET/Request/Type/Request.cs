using Newtonsoft.Json;
using System;
using VoicifyAlexa.NET.Helpers;

namespace VoicifyAlexa.NET.Request.Type
{
    [JsonConverter(typeof(RequestConverter))]
    public abstract class Request
    {
        [JsonProperty("type",Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("timestamp"),JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}