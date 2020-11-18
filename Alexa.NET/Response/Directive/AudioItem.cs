﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.Directive
{
    public class AudioItem
    {
        [JsonRequired]
        [JsonProperty("stream")]
        public AudioItemStream Stream { get; set; }

		[JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
		public AudioItemMetadata Metadata { get; set; }
    }
}
