using System;
using Emeraude.Application.Consumer.Adapters;
using Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Application.Consumer.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register client features.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientOptions"></param>
        public static void AddEmeraudeConsumer(this IServiceCollection services, EmConsumerOptions clientOptions)
        {
            services.AddScoped(typeof(ISitemapComposition), clientOptions.SitemapCompositionType);
        }

        /// <summary>
        /// Register client authentication scheme.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddConsumerCookie(this AuthenticationBuilder builder)
        {
            builder
                .AddCookie(EmAuthenticationDefaults.CookieAuthenticationScheme, options =>
                {
                    options.LoginPath = "/login";
                    options.LogoutPath = "/";
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                    options.Cookie.Name = EmAuthenticationDefaults.SessionCookieName;
                });

            return builder;
        }
    }
}
