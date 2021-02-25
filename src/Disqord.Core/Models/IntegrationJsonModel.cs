﻿using System;
using Disqord.Serialization.Json;

namespace Disqord.Models
{
    public class IntegrationJsonModel : JsonModel
    {
        [JsonProperty("id")]
        public Snowflake Id;

        [JsonProperty("name")]
        public string Name = default!;

        [JsonProperty("string")]
        public string Type = default!;

        [JsonProperty("enabled")] 
        public bool Enabled;

        [JsonProperty("syncing")]
        public Optional<bool> Syncing;

        [JsonProperty("role_id")]
        public Optional<Snowflake> RoleId;

        [JsonProperty("enable_emoticons")]
        public Optional<bool> EnableEmoticons;

        [JsonProperty("expire_behavior")]
        public Optional<IntegrationExpireBehavior> ExpireBehavior;

        [JsonProperty("expire_grace_period")]
        public Optional<int> ExpireGracePeriod;

        [JsonProperty("user")]
        public Optional<UserJsonModel> User;

        [JsonProperty("account")]
        public IntegrationAccountJsonModel Account = default!;

        [JsonProperty("synced_at")]
        public Optional<DateTimeOffset> SyncedAt;

        [JsonProperty("subscriber_count")]
        public Optional<int> SubscriberCount;

        [JsonProperty("revoked")]
        public Optional<bool> Revoked;

        [JsonProperty("application")]
        public Optional<IntegrationApplicationJsonModel> Application;
    }
}