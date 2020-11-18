using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.Request.Type
{
    public interface IDataDrivenRequestTypeConverter : IRequestTypeConverter
    {
        Request Convert(JObject data);
    }
}