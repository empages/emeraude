using System.Collections.Generic;

namespace EmPages.PortalGateway;

/// <summary>
/// Internal configuration definition that client must used in order to know how to handle framework API.
/// </summary>
public class EmPortalConfiguration
{
    /// <summary>
    /// Framework configuration.
    /// </summary>
    public EmPortalFrameworkConfiguration Framework { get; init; }

    /// <summary>
    /// Source configuration.
    /// </summary>
    public EmPortalSourceConfiguration Source { get; init; }

    /// <summary>
    /// Identity configuration.
    /// </summary>
    public EmPortalIdentityConfiguration Identity { get; init; }

    /// <summary>
    /// Pages configurations.
    /// </summary>
    public IEnumerable<EmPortalPageConfiguration> Pages { get; init; }

    /// <summary>
    /// Framework configuration.
    /// </summary>
    public class EmPortalFrameworkConfiguration
    {
        /// <summary>
        /// Name of the framework.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Current version of the framework.
        /// </summary>
        public string Version { get; init; }
    }

    /// <summary>
    /// Source configuration.
    /// </summary>
    public class EmPortalSourceConfiguration
    {
        /// <summary>
        /// Source application base URL.
        /// </summary>
        public string BaseUrl { get; init; }

        /// <summary>
        /// Source application environment.
        /// </summary>
        public string Environment { get; init; }

        /// <summary>
        /// Collection of endpoints exposed by the framework.
        /// </summary>
        public IEnumerable<EmPortalSourceConfigurationApiEndpoint> Endpoints { get; init; }
    }

    /// <summary>
    /// Source API endpoint definition.
    /// </summary>
    public class EmPortalSourceConfigurationApiEndpoint
    {
        /// <summary>
        /// Identifier that is used by the portal.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Route that links the portal with the API.
        /// </summary>
        public string Route { get; set; }
    }

    /// <summary>
    /// Identity configuration.
    /// </summary>
    public class EmPortalIdentityConfiguration
    {
        /// <summary>
        /// Flag that returns whether the request is made from authenticated user.
        /// </summary>
        public bool IsAuthenticated { get; init; }

        /// <summary>
        /// Current identity user.
        /// </summary>
        public EmPortalConfigurationIdentityUser CurrentUser { get; set; }

        /// <summary>
        /// Identity user of the configuration.
        /// </summary>
        public class EmPortalConfigurationIdentityUser
        {
            /// <summary>
            /// Email of the current request user.
            /// </summary>
            public string Email { get; init; }

            /// <summary>
            /// Name of the current request user.
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Flag that indicates whether the MFA is enabled.
            /// </summary>
            public bool IsMultiFactorAuthenticationEnabled { get; init; }
        }
    }

    /// <summary>
    /// Page configuration.
    /// </summary>
    public class EmPortalPageConfiguration
    {
    }
}