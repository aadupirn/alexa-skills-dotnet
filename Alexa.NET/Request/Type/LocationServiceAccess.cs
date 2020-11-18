using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Request.Type
{
    public enum LocationServiceAccess
    {
        [EnumMember(Value = "ENABLED")]
        Enabled,
        [EnumMember(Value = "DISABLED")]
        Disabled
    }
}