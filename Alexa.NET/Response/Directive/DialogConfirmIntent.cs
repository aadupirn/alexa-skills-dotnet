using System;
using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.Directive
{
    public class DialogConfirmIntent : IDirective
    {
        [JsonProperty("type")]
        public string Type => "Dialog.ConfirmIntent";

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}
