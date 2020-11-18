﻿using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.Response.Directive
{
    public interface IConnectionSendRequestHandler
    {
        bool CanCreate(JObject data);

        ConnectionSendRequest Create();
    }
}