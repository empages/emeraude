using System.Reflection;

namespace Emeraude
{
    /// <summary>
    /// List of all assemblies that are defined in the framework.
    /// </summary>
    public static class FrameworkAssemblies
    {
        /// <summary>
        /// Emeraude assembly.
        /// </summary>
        public static readonly Assembly Emeraude = Assembly.Load("Emeraude");

        /// <summary>
        /// Emeraude.Contracts assembly.
        /// </summary>
        public static readonly Assembly EmeraudeContracts = Assembly.Load("Emeraude.Contracts");

        /// <summary>
        /// Emeraude.Configuration assembly.
        /// </summary>
        public static readonly Assembly EmeraudeConfiguration = Assembly.Load("Emeraude.Configuration");

        /// <summary>
        /// Emeraude.Essentials assembly.
        /// </summary>
        public static readonly Assembly EmeraudeEssentials = Assembly.Load("Emeraude.Essentials");

        /// <summary>
        /// Emeraude.Application assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplication = Assembly.Load("Emeraude.Application");

        /// <summary>
        /// Emeraude.Application.Admin assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationAdmin = Assembly.Load("Emeraude.Application.Admin");

        /// <summary>
        /// Emeraude.Application.Admin.EmPages assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationAdminEmPages = Assembly.Load("Emeraude.Application.Admin.EmPages");

        /// <summary>
        /// Emeraude.Application.ClientBuilder assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationClientBuilder = Assembly.Load("Emeraude.Application.ClientBuilder");

        /// <summary>
        /// Emeraude.Application.Consumer assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationConsumer = Assembly.Load("Emeraude.Application.Consumer");

        /// <summary>
        /// Emeraude.Application.Identity assembly.
        /// </summary>
        public static readonly Assembly EmeraudeApplicationIdentity = Assembly.Load("Emeraude.Application.Identity");

        /// <summary>
        /// Emeraude.Infrastructure assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructure = Assembly.Load("Emeraude.Infrastructure");

        /// <summary>
        /// Emeraude.Infrastructure.FileStorage assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureFileStorage = Assembly.Load("Emeraude.Infrastructure.FileStorage");

        /// <summary>
        /// Emeraude.Infrastructure.Identity assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureIdentity = Assembly.Load("Emeraude.Infrastructure.Identity");

        /// <summary>
        /// Emeraude.Infrastructure.Localization assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructureLocalization = Assembly.Load("Emeraude.Infrastructure.Localization");

        /// <summary>
        /// Emeraude.Infrastructure.Persistence assembly.
        /// </summary>
        public static readonly Assembly EmeraudeInfrastructurePersistence = Assembly.Load("Emeraude.Infrastructure.Persistence");

        /// <summary>
        /// Emeraude.Presentation assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentation = Assembly.Load("Emeraude.Presentation");

        /// <summary>
        /// Emeraude.Presentation.PlatformBase assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentationPlatformBase = Assembly.Load("Emeraude.Presentation.PlatformBase");

        /// <summary>
        /// Emeraude.Presentation.PortalGateway assembly.
        /// </summary>
        public static readonly Assembly EmeraudePresentationPortalGateway = Assembly.Load("Emeraude.Presentation.PortalGateway");
    }
}