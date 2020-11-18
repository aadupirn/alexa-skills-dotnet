using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Request.Type
{
    public class SkillEventPersistenceStatus
    {
        [JsonProperty("userInformationPersistenceStatus"),
         JsonConverter(typeof(StringEnumConverter))]
        public PersistenceStatus Status { get; set; }
    }
}