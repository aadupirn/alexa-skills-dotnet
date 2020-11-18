using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Helpers;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request.Type
{
    public class SkillEventRequest:Request
    {
        [JsonProperty("eventCreationTime", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime? EventCreationTime { get; set; }

        [JsonProperty("eventPublishingTime", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime? EventPublishingTime { get; set; }
    }
}
