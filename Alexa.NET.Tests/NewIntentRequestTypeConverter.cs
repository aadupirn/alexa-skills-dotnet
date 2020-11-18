using VoicifyAlexa.NET.Request.Type;

namespace VoicifyAlexa.NET.Tests
{
    public class NewIntentRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "AlexaNet.CustomIntent";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new NewIntentRequest();
        }
    }
}