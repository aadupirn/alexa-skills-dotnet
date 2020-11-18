using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class User
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }
    }
}