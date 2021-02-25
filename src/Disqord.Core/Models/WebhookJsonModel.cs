﻿using Disqord.Serialization.Json;

namespace Disqord.Models
{
    public class WebhookJsonModel : JsonModel
    {
        [JsonProperty("id")]
        public Snowflake Id;

        [JsonProperty("type")]
        public WebhookType Type;

        [JsonProperty("guild_id")]
        public Optional<Snowflake> GuildId;

        [JsonProperty("channel_id")]
        public Snowflake ChannelId;

        [JsonProperty("user")]
        public Optional<UserJsonModel> User;

        [JsonProperty("name")]
        public string Name = default!;

        [JsonProperty("avatar")]
        public string Avatar = default!;

        [JsonProperty("token")]
        public Optional<string> Token;

        [JsonProperty("application_id")]
        public Snowflake? ApplicationId;
    }
}
