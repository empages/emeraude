using Definux.Emeraude.Admin;
using Definux.Emeraude.Application;
using Definux.Emeraude.Client;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails;
using Definux.Emeraude.Files;
using Definux.Emeraude.Identity;
using Definux.Emeraude.Localization;
using Definux.Emeraude.Logger;
using Definux.Emeraude.Persistence;

namespace Definux.Emeraude
{
    /// <summary>
    /// Setup class that contains reference to all available options in Emeraude Framework.
    /// </summary>
    public class EmOptionsSetup
    {
        /// <inheritdoc cref="EmMainOptions" />
        public EmMainOptions MainOptions { get; set; } = new EmMainOptions();

        /// <inheritdoc cref="EmApplicationsOptions" />
        public EmApplicationsOptions ApplicationsOptions { get; set; } = new EmApplicationsOptions();

        /// <inheritdoc cref="EmAdminOptions" />
        public EmAdminOptions AdminOptions { get; set; } = new EmAdminOptions();

        /// <inheritdoc cref="EmClientOptions" />
        public EmClientOptions ClientOptions { get; set; } = new EmClientOptions();

        /// <inheritdoc cref="EmPersistenceOptions" />
        public EmPersistenceOptions PersistenceOptions { get; set; } = new EmPersistenceOptions();

        /// <inheritdoc cref="EmIdentityOptions" />
        public EmIdentityOptions IdentityOptions { get; set; } = new EmIdentityOptions();

        /// <inheritdoc cref="EmLoggerOptions" />
        public EmLoggerOptions LoggerOptions { get; set; } = new EmLoggerOptions();

        /// <inheritdoc cref="EmLocalizationOptions" />
        public EmLocalizationOptions LocalizationOptions { get; set; } = new EmLocalizationOptions();

        /// <inheritdoc cref="EmEmailOptions" />
        public EmEmailOptions EmailOptions { get; set; } = new EmEmailOptions();

        /// <inheritdoc cref="EmFilesOptions" />
        public EmFilesOptions FilesOptions { get; set; } = new EmFilesOptions();
    }
}