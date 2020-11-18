using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request.Type
{
    public class SkillEventPermissions
    {
        [JsonProperty("acceptedPermissions")]
        public Permission[] AcceptedPermissions { get; set; }
    }
}