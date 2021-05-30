using System;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Emails.Extensions
{
    /// <summary>
    /// Extensions for <see cref="EmOptions"/>.
    /// </summary>
    public static class OptionsExtensions
    {
        /// <summary>
        /// Get Emeraude email infrastructure options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static EmEmailOptions GetEmailOptions(this EmOptions options) => options.GetExternalOption<EmEmailOptions>() ?? new EmEmailOptions();

        /// <summary>
        /// Add external Emeraude email options
        /// </summary>
        /// <param name="options"></param>
        /// <param name="emailOptionsAction"></param>
        public static void ConfigureEmailsInfrastructure(
            this EmOptions options,
            Action<EmEmailOptions> emailOptionsAction)
        {
            EmEmailOptions emailOptions = new EmEmailOptions();
            emailOptionsAction.Invoke(emailOptions);
            options.AddExternalOptions(emailOptions);
        }
    }
}