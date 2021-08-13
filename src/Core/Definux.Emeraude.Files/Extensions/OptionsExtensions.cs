using System;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Files.Extensions
{
    /// <summary>
    /// Extensions for <see cref="EmMainOptions"/>.
    /// </summary>
    public static class OptionsExtensions
    {
        /// <summary>
        /// Get Emeraude files infrastructure options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static EmFilesOptions GetFilesOptions(this EmMainOptions options) => options.GetExternalOption<EmFilesOptions>() ?? new EmFilesOptions();

        /// <summary>
        /// Add external Emeraude files options.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="filesOptionsAction"></param>
        public static void ConfigureFilesInfrastructure(
            this EmMainOptions options,
            Action<EmFilesOptions> filesOptionsAction)
        {
            EmFilesOptions filesOptions = new EmFilesOptions();
            filesOptionsAction.Invoke(filesOptions);
            options.AddExternalOptions(filesOptions);
        }
    }
}