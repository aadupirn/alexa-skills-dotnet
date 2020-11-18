using System;
using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.Directive
{
    public class DialogDelegate:IDirective
    {
        [JsonProperty("type")]
        public string Type => "Dialog.Delegate";

        [JsonProperty("updatedIntent",NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}
