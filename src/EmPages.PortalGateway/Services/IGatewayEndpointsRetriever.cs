using System.Collections.Generic;

namespace EmPages.PortalGateway.Services;

/// <summary>
/// Gateway endpoint retriever. Internal service.
/// </summary>
public interface IGatewayEndpointsRetriever
{
    /// <summary>
    /// Retrieves endpoints from current package assembly.
    /// </summary>
    /// <returns></returns>
    IEnumerable<EmPortalConfiguration.EmPortalSourceConfigurationApiEndpoint> RetrieveApiEndpoints();
}