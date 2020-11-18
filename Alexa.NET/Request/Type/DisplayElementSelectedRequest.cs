﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VoicifyAlexa.NET.Request.Type
{
    public class DisplayElementSelectedRequest:Request
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
