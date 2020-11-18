﻿using VoicifyAlexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    [JsonConverter(typeof(CardConverter))]
    public interface ICard : IResponse
    {
    }
}