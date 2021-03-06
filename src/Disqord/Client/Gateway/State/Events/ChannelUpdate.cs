﻿using System.Threading.Tasks;
using Disqord.Events;
using Disqord.Logging;
using Disqord.Models;

namespace Disqord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleChannelUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<ChannelModel>();
            var channel = GetChannel(model.Id);
            if (channel == null)
            {
                _client.Log(LogSeverity.Warning, $"Unknown channel in ChannelUpdate. Id: {model.Id}.");
                return Task.CompletedTask;
            }

            var before = channel.Clone();
            channel.Update(model);
            return _client._channelUpdated.InvokeAsync(new ChannelUpdatedEventArgs(before, channel));
        }
    }
}
