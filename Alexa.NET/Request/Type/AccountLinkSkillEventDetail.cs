using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request.Type
{
    public class AccountLinkSkillEventDetail
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}