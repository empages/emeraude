using System;
using System.Collections.Generic;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Identity.Extensions;

namespace Definux.Emeraude.Extensions
{
    /// <summary>
    /// Extensions for <see cref="EmeraudeSettingsBuilder"/>.
    /// </summary>
    public static class EmeraudeSettingsBuilderExtensions
    {
        /// <summary>
        /// Add external providers authenticators and invoke their registration methods.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="authenticatorsAction"></param>
        /// <returns></returns>
        public static EmeraudeSettingsBuilder AddExternalProvidersAuthenticators(
            this EmeraudeSettingsBuilder builder,
            Action<List<IExternalProviderAuthenticator>> authenticatorsAction)
        {
            builder.Services.RegisterExternalProvidersAuthenticators(
                builder.AuthenticationBuilder,
                authenticatorsAction);

            return builder;
        }
    }
}