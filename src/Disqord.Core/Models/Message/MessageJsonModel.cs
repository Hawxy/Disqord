﻿using System;
using Disqord.Serialization.Json;

namespace Disqord.Models
{
    public class MessageJsonModel : JsonModel
    {
        [JsonProperty("id")]
        public Snowflake Id;

        [JsonProperty("channel_id")]
        public Snowflake ChannelId;

        [JsonProperty("guild_id")]
        public Optional<Snowflake> GuildId;

        [JsonProperty("author")]
        public UserJsonModel Author = default!;

        [JsonProperty("member")]
        public Optional<MemberJsonModel> Member;

        [JsonProperty("content")]
        public string Content = default!;

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp;

        [JsonProperty("edited_timestamp")]
        public DateTimeOffset? EditedTimestamp;

        [JsonProperty("tts")]
        public bool Tts;

        [JsonProperty("mention_everyone")]
        public bool MentionEveryone;

        [JsonProperty("mentions")]
        public UserJsonModel[] Mentions = default!;

        [JsonProperty("mention_roles")]
        public Snowflake[] MentionRoles = default!;

        [JsonProperty("mention_channels")]
        public Optional<ChannelMentionJsonModel[]> MentionChannels;

        [JsonProperty("attachments")]
        public AttachmentJsonModel[] Attachments = default!;

        [JsonProperty("embeds")]
        public EmbedJsonModel[] Embeds = default!;

        [JsonProperty("reactions")]
        public Optional<ReactionJsonModel[]> Reactions;

        [JsonProperty("nonce")]
        public Optional<string> Nonce;

        [JsonProperty("pinned")]
        public bool Pinned;

        [JsonProperty("webhook_id")]
        public Optional<Snowflake> WebhookId;

        [JsonProperty("type")]
        public int Type;

        [JsonProperty("activity")]
        public Optional<MessageActivityJsonModel> Activity;

        [JsonProperty("application")]
        public Optional<MessageApplicationJsonModel> Application;

        [JsonProperty("message_reference")]
        public Optional<MessageReferenceJsonModel> MessageReference;

        [JsonProperty("flags")]
        public Optional<MessageFlag> Flags;

        [JsonProperty("stickers")]
        public Optional<StickerJsonModel[]> Stickers;

        [JsonProperty("referenced_message")]
        public Optional<MessageJsonModel> ReferencedMessage;
    }
}
