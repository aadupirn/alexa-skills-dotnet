using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Request
{
    public enum SlotValueType
    {
        [EnumMember(Value="Simple")]
        Simple,
        [EnumMember(Value="List")]
        List
    }
}