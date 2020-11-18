﻿using VoicifyAlexa.NET.Request.Type;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class SkillRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("session")]
        public Session Session { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }

        [JsonProperty("request")]
        public Type.Request Request { get; set; }

        public System.Type GetRequestType()
        {
            return Request?.GetType();
        }
    }
}