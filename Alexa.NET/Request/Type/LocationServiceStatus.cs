using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Request.Type
{
    public enum LocationServiceStatus
    {
        [EnumMember(Value = "RUNNING")]
        Running,
        [EnumMember(Value = "STOPPED")]
        Stopped
    }
}