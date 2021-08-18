using Definux.Emeraude.Admin;
using Definux.Emeraude.Application;
using Definux.Emeraude.Client;
using Definux.Emeraude.ClientBuilder.Options;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails;
using Definux.Emeraude.Emails.Options;
using Definux.Emeraude.Files;
using Definux.Emeraude.Identity;
using Definux.Emeraude.Identity.Options;
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
        public EmMainOptions MainOptions { get; set; } = new ();

        /// <inheritdoc cref="EmApplicationsOptions" />
        public EmApplicationsOptions ApplicationsOptions { get; set; } = new ();

        /// <inheritdoc cref="EmAdminOptions" />
        public EmAdminOptions AdminOptions { get; set; } = new ();

        /// <inheritdoc cref="EmClientOptions" />
        public EmClientOptions ClientOptions { get; set; } = new ();

        /// <inheritdoc cref="EmPersistenceOptions" />
        public EmPersistenceOptions PersistenceOptions { get; set; } = new ();

        /// <inheritdoc cref="EmIdentityOptions" />
        public EmIdentityOptions IdentityOptions { get; set; } = new ();

        /// <inheritdoc cref="EmLoggerOptions" />
        public EmLoggerOptions LoggerOptions { get; set; } = new ();

        /// <inheritdoc cref="EmLocalizationOptions" />
        public EmLocalizationOptions LocalizationOptions { get; set; } = new ();

        /// <inheritdoc cref="EmEmailOptions" />
        public EmEmailOptions EmailOptions { get; set; } = new ();

        /// <inheritdoc cref="EmFilesOptions" />
        public EmFilesOptions FilesOptions { get; set; } = new ();

        /// <inheritdoc cref="EmClientBuilderOptions" />
        public EmClientBuilderOptions ClientBuilderOptions { get; set; } = new ();
    }
}