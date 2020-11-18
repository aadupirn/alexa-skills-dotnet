using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.Request.Type
{
    public interface IConnectionResponseHandler
    {
        bool CanCreate(JObject data);
        ConnectionResponseRequest Create(JObject data);
    }
}