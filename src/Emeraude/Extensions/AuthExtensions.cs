using System;
using System.Text;
using Emeraude.Essentials.Base;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.Options;
using Emeraude.Presentation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Emeraude.Extensions
{
    /// <summary>
    /// Extensions for authentication and authorization options.
    /// </summary>
    internal static class AuthExtensions
    {
        /// <summary>
        /// Applies authorization policies to administration.
        /// </summary>
        /// <param name="options"></param>
        internal static void ApplyEmeraudeAdminAuthorizationPolicies(this AuthorizationOptions options)
        {
            foreach (ApplicationPermission permission in EmPermissions.AllPermissions)
            {
                options.AddPolicy(permission.Name, policy =>
                {
                    policy.AuthenticationSchemes.Add(EmAuthenticationDefaults.BearerAuthenticationScheme);
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim(EmClaimTypes.Permission, permission.Value);
                });
            }
        }

        /// <summary>
        /// Register consumer cookie authentication.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        internal static AuthenticationBuilder AddConsumerCookie(this AuthenticationBuilder builder)
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

        /// <summary>
        /// Registers bearer authentication.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="accessTokenOptions"></param>
        /// <returns></returns>
        internal static AuthenticationBuilder AddBearerAuthentication(
            this AuthenticationBuilder builder,
            AccessTokenOptions accessTokenOptions)
        {
            builder
                .AddJwtBearer(EmAuthenticationDefaults.BearerAuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = accessTokenOptions.Issuer,
                        ValidAudience = accessTokenOptions.Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(accessTokenOptions.Key)),
                    };
                });

            return builder;
        }
    }
}