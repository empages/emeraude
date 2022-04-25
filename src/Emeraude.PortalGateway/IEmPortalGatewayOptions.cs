using System.Collections.Generic;

namespace Emeraude.PortalGateway;

/// <summary>
/// Options for configuring Emeraude portal gateway.
/// </summary>
public interface IEmPortalGatewayOptions
{
    /// <summary>
    /// List of all portal URLs that can consume data through the gateway.
    /// </summary>
    IReadOnlyList<string> PortalUrls { get; }

    /// <summary>
    /// Identification of the gateway. Make sure that value is complex enough.
    /// </summary>
    string GatewayId { get; }
}