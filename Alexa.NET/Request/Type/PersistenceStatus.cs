using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Request.Type
{
    public enum PersistenceStatus
    {
        [EnumMember(Value= "PERSISTED")]
        Persisted,
        [EnumMember(Value= "NOT_PERSISTED")]
        NotPersisted
    }
}