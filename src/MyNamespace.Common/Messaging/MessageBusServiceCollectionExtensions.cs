﻿using System;
using System.Linq;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MyNamespace.Common.Messaging
{
    public static class MessageBusServiceCollectionExtensions
    {
        public static IServiceCollection AddMessageBus(this IServiceCollection services)
        {
            var myAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(x => x.GetName().Name?.StartsWith("MyNamespace") ?? false)
                .ToArray();
            services.AddMediatR(cfg => cfg.Using<MessageBus>(), myAssemblies);
            services.AddTransient(svc => (IMessageBus) svc.GetRequiredService<IMediator>());
            return services;
        }
    }
}