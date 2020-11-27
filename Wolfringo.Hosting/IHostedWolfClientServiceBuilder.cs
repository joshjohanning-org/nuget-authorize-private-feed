﻿using System;
using TehGM.Wolfringo.Hosting;
using TehGM.Wolfringo.Messages.Serialization;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Builder for hosted WOLF client.</summary>
    public interface IHostedWolfClientServiceBuilder
    {
        /// <summary>Alters configuration of WOLF Client.</summary>
        IHostedWolfClientServiceBuilder Configure(Action<HostedWolfClient> configure);
        /// <summary>Alters configuration of Message Serializer Provider.</summary>
        IHostedWolfClientServiceBuilder ConfigureMessageSerializerProvider(Action<MessageSerializerProviderOptions> configure);
        /// <summary>Alters configuration of Response Serializer Provider.</summary>
        IHostedWolfClientServiceBuilder ConfigureResponseSerializerProvider(Action<ResponseSerializerProviderOptions> configure);
    }
}
