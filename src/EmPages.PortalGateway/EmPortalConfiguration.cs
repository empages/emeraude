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
    /// Page configuration.
    /// </summary>
    public class EmPortalPageConfiguration
    {
    }
}