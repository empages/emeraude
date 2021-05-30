using System;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Files.Extensions
{
    /// <summary>
    /// Extensions for <see cref="EmOptions"/>.
    /// </summary>
    public static class OptionsExtensions
    {
        /// <summary>
        /// Get Emeraude files infrastructure options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static EmFilesOptions GetFilesOptions(this EmOptions options) => options.GetExternalOption<EmFilesOptions>() ?? new EmFilesOptions();

        /// <summary>
        /// Add external Emeraude files options
        /// </summary>
        /// <param name="options"></param>
        /// <param name="filesOptionsAction"></param>
        public static void ConfigureFilesInfrastructure(
            this EmOptions options,
            Action<EmFilesOptions> filesOptionsAction)
        {
            EmFilesOptions filesOptions = new EmFilesOptions();
            filesOptionsAction.Invoke(filesOptions);
            options.AddExternalOptions(filesOptions);
        }
    }
}