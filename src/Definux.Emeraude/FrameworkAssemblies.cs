using System.Reflection;

namespace Definux.Emeraude
{
    /// <summary>
    /// List of all assemblies that are defined in the framework.
    /// </summary>
    public static class FrameworkAssemblies
    {
        /// <summary>
        /// Definux.Emeraude assembly.
        /// </summary>
        public static readonly Assembly Emeraude = Assembly.Load("Definux.Emeraude");

        /// <summary>
        /// Definux.Emeraude.Contracts assembly.
        /// </summary>
        public static readonly Assembly EmeraudeContracts = Assembly.Load("Definux.Emeraude.Contracts");

        /// <summary>
        /// Definux.Emeraude.Configuration assembly.
        /// </summary>
        public static readonly Assembly EmeraudeConfiguration = Assembly.Load("Definux.Emeraude.Configuration");

        /// <summary>
        /// Definux.Emeraude.Essentials assembly.
        /// </summary>
        public static readonly Assembly EmeraudeEssentials = Assembly.Load("Definux.Emeraude.Essentials");

        /// <summary>
        /// Definux.Emeraude.Application assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplication = Assembly.Load("Definux.Emeraude.Application");

        /// <summary>
        /// Definux.Emeraude.Application.Admin assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationAdmin = Assembly.Load("Definux.Emeraude.Application.Admin");

        /// <summary>
        /// Definux.Emeraude.Application.Admin.EmPages assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationAdminEmPages = Assembly.Load("Definux.Emeraude.Application.Admin.EmPages");

        /// <summary>
        /// Definux.Emeraude.Application.ClientBuilder assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationClientBuilder = Assembly.Load("Definux.Emeraude.Application.ClientBuilder");

        /// <summary>
        /// Definux.Emeraude.Application.Consumer assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationConsumer = Assembly.Load("Definux.Emeraude.Application.Consumer");

        /// <summary>
        /// Definux.Emeraude.Application.General assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationGeneral = Assembly.Load("Definux.Emeraude.Application.General");

        /// <summary>
        /// Definux.Emeraude.Application.Identity assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationIdentity = Assembly.Load("Definux.Emeraude.Application.Identity");

        /// <summary>
        /// Definux.Emeraude.Infrastructure assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructure = Assembly.Load("Definux.Emeraude.Infrastructure");

        /// <summary>
        /// Definux.Emeraude.Infrastructure.FileStorage assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureFileStorage = Assembly.Load("Definux.Emeraude.Infrastructure.FileStorage");

        /// <summary>
        /// Definux.Emeraude.Infrastructure.Identity assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureIdentity = Assembly.Load("Definux.Emeraude.Infrastructure.Identity");

        /// <summary>
        /// Definux.Emeraude.Infrastructure.Localization assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureLocalization = Assembly.Load("Definux.Emeraude.Infrastructure.Localization");

        /// <summary>
        /// Definux.Emeraude.Infrastructure.Persistence assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructurePersistence = Assembly.Load("Definux.Emeraude.Infrastructure.Persistence");

        /// <summary>
        /// Definux.Emeraude.Presentation assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentation = Assembly.Load("Definux.Emeraude.Presentation");

        /// <summary>
        /// Definux.Emeraude.Presentation.PlatformBase assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentationPlatformBase = Assembly.Load("Definux.Emeraude.Presentation.PlatformBase");

        /// <summary>
        /// Definux.Emeraude.Presentation.PortalGateway assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentationPortalGateway = Assembly.Load("Definux.Emeraude.Presentation.PortalGateway");
    }
}