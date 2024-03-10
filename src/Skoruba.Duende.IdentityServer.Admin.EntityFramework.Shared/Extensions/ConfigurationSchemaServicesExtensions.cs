﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Skoruba.Duende.IdentityServer.Admin.EntityFramework.Shared.Configuration.Schema;

namespace Skoruba.Duende.IdentityServer.Admin.EntityFramework.Shared.Extensions
{
    public static class ConfigurationSchemaServicesExtensions
    {
        public static IServiceCollection ConfigureAdminAspNetIdentitySchema(this IServiceCollection services,
            Action<AdminIdentityDbSchemaConfiguration> configureOptions)
        {
            if (configureOptions == null)
            {
                throw new ArgumentNullException(nameof(configureOptions));
            }

            var adminIdentitySchema = new AdminIdentityDbSchemaConfiguration();
            configureOptions(adminIdentitySchema);

            services.AddSingleton(adminIdentitySchema);

            return services;
        }
    }
}