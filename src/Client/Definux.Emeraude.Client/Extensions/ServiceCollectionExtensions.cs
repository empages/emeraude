using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Client.EmPages.Conventions;
using Definux.Emeraude.Client.EmPages.Extensions;
using Definux.Emeraude.Client.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Locales.Constraints;
using Definux.Utilities.Options;
using IdentityModel;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register client features (EmPages, language based routes).
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddEmeraudeClient(this IServiceCollection services)
        {
            services.ConfigureClientUI();
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add(LanguageRouteConstraint.LanguageConstraintKey, typeof(LanguageRouteConstraint));
            });

            services.RegisterEmPages();

            return services;
        }

        /// <summary>
        /// Register client authentication scheme.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddClientCookie(this AuthenticationBuilder builder)
        {
            builder
                .AddCookie(AuthenticationDefaults.ClientAuthenticationScheme, options =>
                {
                    options.LoginPath = "/login";
                    options.LogoutPath = "/";
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                    options.Cookie.Name = AuthenticationDefaults.ClientCookieName;
                });

            return builder;
        }

        /// <summary>
        /// Register client mapper configuration.
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IMapperConfigurationExpression AddClientMapperConfiguration(this IMapperConfigurationExpression configuration)
        {
            return configuration;
        }

        /// <summary>
        /// Register Facebook OAuth2 configuration.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddFacebookOAuth2(this AuthenticationBuilder builder, FacebookOAuth2Settings settings)
        {
            builder.AddFacebook(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.AppId = settings.AppId;
                options.AppSecret = settings.AppSecret;
                options.Fields.Add("picture.type(large)");

                options.Events = new OAuthEvents
                {
                    OnCreatingTicket = (context) =>
                    {
                        ClaimsIdentity identity = (ClaimsIdentity)context.Principal.Identity;
                        string profileImage = context
                            .User
                            .GetProperty("picture")
                            .GetProperty("data")
                            .GetProperty("url")
                            .ToString();

                        identity.AddClaim(new Claim(Definux.Emeraude.Configuration.Authorization.ClaimTypes.Picture, profileImage));
                        return Task.CompletedTask;
                    },
                };
            });

            return builder;
        }

        /// <summary>
        /// Register Google OAuth2 configuration.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddGoogleOAuth2(this AuthenticationBuilder builder, GoogleOAuth2Settings settings)
        {
            builder.AddGoogle(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.ClientId = settings.ClientId;
                options.ClientSecret = settings.ClientSecret;
                options.Scope.Add("profile");
                options.Events.OnCreatingTicket = (context) =>
                {
                    var claim = new Claim(Definux.Emeraude.Configuration.Authorization.ClaimTypes.Picture, context.User.GetProperty("picture").GetString());
                    context.Identity.AddClaim(claim);

                    return Task.CompletedTask;
                };
            });

            return builder;
        }

        /// <summary>
        /// Register external OAuth2 providers.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="accountOptions"></param>
        /// <param name="externalOAuth2Options"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddExternalOAuth2Providers(this AuthenticationBuilder builder, AccountOptions accountOptions, ExternalOAuth2ProviderOptions externalOAuth2Options)
        {
            if (accountOptions.HasFacebookLogin)
            {
                builder.AddFacebookOAuth2(externalOAuth2Options.FacebookSettings);
            }

            if (accountOptions.HasGoogleLogin)
            {
                builder.AddGoogleOAuth2(externalOAuth2Options.GoogleSettings);
            }

            return builder;
        }

        /// <summary>
        /// Configure EmPages routes.
        /// </summary>
        /// <param name="options"></param>
        public static void UseCentralEmPagesRoutePrefix(this MvcOptions options)
        {
            options.Conventions.Insert(0, new EmPagesRouteConvention());
        }
    }
}
