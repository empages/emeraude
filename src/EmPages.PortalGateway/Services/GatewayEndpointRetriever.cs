using System.Collections.Generic;
using System.Linq;
using EmPages.PortalGateway.Controllers;
using Essentials.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Services;

/// <summary>
/// <inheritdoc cref="IGatewayEndpointsRetriever"/>
/// </summary>
internal class GatewayEndpointRetriever : IGatewayEndpointsRetriever
{
    /// <inheritdoc />
    public IEnumerable<EmPortalConfiguration.EmPortalSourceConfigurationApiEndpoint> RetrieveApiEndpoints()
    {
        var controllers = this.GetType()
            .Assembly
            .GetTypes()
            .Where(x => x.BaseType == typeof(EmPortalGatewayController));

        var actions = controllers
            .SelectMany(x => x
                .GetMethods()
                .Where(y => y.HasAttribute<EmPortalEndpointAttribute>()));

        return actions
            .Select(x => new EmPortalConfiguration.EmPortalSourceConfigurationApiEndpoint
            {
                Id = x.GetAttribute<EmPortalEndpointAttribute>().Id,
                Route = x.DeclaringType.GetAttribute<RouteAttribute>().Template + x.GetAttribute<RouteAttribute>().Template,
            });
    }
}