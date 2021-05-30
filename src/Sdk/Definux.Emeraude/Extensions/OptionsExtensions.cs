using System;
using Definux.Emeraude.Configuration.Options;
using Definux.Seo.Options;

namespace Definux.Emeraude.Extensions
{
    /// <summary>
    /// Extensions for <see cref="EmOptions"/>.
    /// </summary>
    public static class OptionsExtensions
    {
        /// <summary>
        /// Add external m
        /// </summary>
        /// <param name="options"></param>
        /// <param name="seoOptionsAction"></param>
        public static void ConfigureSeo(
            this EmOptions options,
            Action<DefinuxSeoOptions> seoOptionsAction)
        {
            options.AddExternalOptions(seoOptionsAction);
        }
    }
}