﻿using Disqord.Serialization.Json;

namespace Disqord.Models
{
    public class EmbedImageJsonModel : JsonModel
    {
        [JsonProperty("url")]
        public Optional<string> Url;

        [JsonProperty("proxy_url")]
        public Optional<string> ProxyUrl;

        [JsonProperty("height")]
        public Optional<int> IconUrl;

        [JsonProperty("width")]
        public Optional<int> ProxyIconUrl;
    }
}