﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Disqord
{
    public abstract partial class DiscordClientBase
    {
        public async Task InitialiseExtensionsAsync(CancellationToken cancellationToken = default)
        {
            if (_extensions.Count == 0)
                return;

            Logger.LogDebug("Initialising client extensions: {0}", _extensions.Values.Select(x => x.GetType().Name));
            foreach (var extension in _extensions.Values)
            {
                try
                {
                    await extension.InitialiseAsync(this, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, "An exception occurred while initialising extension {0}.", extension);
                }
            }
        }

        public TExtension? GetExtension<TExtension>()
            where TExtension : DiscordClientExtension
            => _extensions.GetValueOrDefault(typeof(TExtension)) as TExtension;

        public TExtension GetRequiredExtension<TExtension>()
            where TExtension : DiscordClientExtension
        {
            var extension = GetExtension<TExtension>();
            if (extension == null)
                throw new InvalidOperationException($"No extension for type '{typeof(TExtension)}' has been registered.");

            return extension;
        }
    }
}
