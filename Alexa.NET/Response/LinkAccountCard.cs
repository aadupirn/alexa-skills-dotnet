using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    public class LinkAccountCard : ICard
    {
        [JsonProperty("type")]
        public string Type
        {
            get { return "LinkAccount"; }
        }
    }
}