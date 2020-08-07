using AutoMapper;
using Definux.Emeraude.Client.EmPages.Conventions;
using Definux.Emeraude.Client.EmPages.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Locales.Constraints;
using Definux.Utilities.Options;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEmeraudeClient(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add(LanguageRouteConstraint.LanguageConstraintKey, typeof(LanguageRouteConstraint));
            });

            services.RegisterEmPages();

            return services;
        }

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

        public static IMapperConfigurationExpression AddClientMapperConfiguration(this IMapperConfigurationExpression configuration)
        {
            return configuration;
        }

        public static AuthenticationBuilder AddFacebookOAuth2(this AuthenticationBuilder builder, FacebookOAuth2Settings settings)
        {
            builder.AddFacebook(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.AppId = settings.AppId;
                options.AppSecret = settings.AppSecret;
            });

            return builder;
        }

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

        public static void UseCentralEmPagesRoutePrefix(this MvcOptions options)
        {
            options.Conventions.Insert(0, new EmPagesRouteConvention());
        }

    }
}
