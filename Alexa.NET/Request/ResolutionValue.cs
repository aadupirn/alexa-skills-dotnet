﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class ResolutionValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
