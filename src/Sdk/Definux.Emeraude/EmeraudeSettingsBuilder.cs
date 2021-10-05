using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude
{
    /// <summary>
    /// Helper class that contains all additional registration models for applying additional settings.
    /// </summary>
    public class EmeraudeSettingsBuilder
    {
        /// <inheritdoc cref="IServiceCollection" />
        public IServiceCollection Services { get; set; }

        /// <inheritdoc cref="AuthenticationBuilder" />
        public AuthenticationBuilder AuthenticationBuilder { get; set; }
    }
}