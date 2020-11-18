using System;
using System.Xml.Linq;
namespace VoicifyAlexa.NET.Response.Ssml
{
    public interface ISsml
    {
        XNode ToXml();
    }
}
