using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude
{
    /// <summary>
    /// Helper class that contains all additional registration models for applying additional settings.
    /// </summary>
    public class EmeraudeSettingsBuilder
    {
        /// <inheritdoc cref="AuthenticationBuilder" />
        public AuthenticationBuilder AuthenticationBuilder { get; set; }

        /// <inheritdoc cref="IdentityBuilder" />
        public IdentityBuilder IdentityBuilder { get; set; }

        /// <inheritdoc cref="IMvcBuilder" />
        public IMvcBuilder MvcBuilder { get; set; }

        /// <summary>
        /// Execute post configuration over the already setup builders.
        /// </summary>
        /// <param name="settingsBuilder"></param>
        public void EmeraudePostConfigure(Action<EmeraudeSettingsBuilder> settingsBuilder)
        {
            settingsBuilder?.Invoke(this);
        }
    }
}