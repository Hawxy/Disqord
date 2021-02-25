﻿using System.Collections.Generic;
using Disqord.Collections;
using Disqord.Models;

namespace Disqord
{
    public abstract class TransientGuildChannel : TransientChannel, IGuildChannel
    {
        public Snowflake GuildId => Model.GuildId.Value;

        public int Position => Model.Position.Value;

        public IReadOnlyList<IOverwrite>? Overwrites
        {
            get
            {
                if (_overwrites == null)
                    _overwrites = Model.PermissionOverwrites.Value?.ToReadOnlyList(this, (x, @this) => new TransientOverwrite(@this.Client, @this.Id, x));

                return _overwrites;
            }
        }
        private IReadOnlyList<IOverwrite>? _overwrites;

        public TransientGuildChannel(IClient client, ChannelJsonModel model)
            : base(client, model)
        { }

        public new static TransientGuildChannel Create(IClient client, ChannelJsonModel model)
        {
            switch (model.Type)
            {
                case ChannelType.Text:
                case ChannelType.News:
                case ChannelType.Store:
                // TODO: threads
                case ChannelType.Thread:
                    return new TransientTextChannel(client, model);

                case ChannelType.Voice:
                    return new TransientVoiceChannel(client, model);

                case ChannelType.Category:
                    return new TransientCategoryChannel(client, model);
            }

            return null!/*TransientUnknownChannel(client, model)*/;
        }
    }
}
