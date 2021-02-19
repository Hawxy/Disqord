﻿using Disqord.Events;

namespace Disqord.Gateway
{
    public partial interface IGatewayDispatcher
    {
        AsynchronousEvent<ReadyEventArgs> ReadyEvent { get; }

        AsynchronousEvent<ChannelCreatedEventArgs> ChannelCreatedEvent { get; }

        AsynchronousEvent<ChannelUpdatedEventArgs> ChannelUpdatedEvent { get; }

        AsynchronousEvent<ChannelDeletedEventArgs> ChannelDeletedEvent { get; }

        AsynchronousEvent<ChannelPinsUpdatedEventArgs> ChannelPinsUpdatedEvent { get; }

        AsynchronousEvent<GuildAvailableEventArgs> GuildAvailableEvent { get; }

        AsynchronousEvent<JoinedGuildEventArgs> JoinedGuildEvent { get; }

        AsynchronousEvent<GuildUnavailableEventArgs> GuildUnavailableEvent { get; }

        AsynchronousEvent<LeftGuildEventArgs> LeftGuildEvent { get; }

        AsynchronousEvent<BanCreatedEventArgs> BanCreatedEvent { get; }

        AsynchronousEvent<BanDeletedEventArgs> BanDeletedEvent { get; }

        AsynchronousEvent<MessageReceivedEventArgs> MessageReceivedEvent { get; }

        AsynchronousEvent<TypingStartedEventArgs> TypingStartedEvent { get; }

        AsynchronousEvent<VoiceStateUpdatedEventArgs> VoiceStateUpdatedEvent { get; }

        AsynchronousEvent<VoiceServerUpdatedEventArgs> VoiceServerUpdatedEvent { get; }
    }
}