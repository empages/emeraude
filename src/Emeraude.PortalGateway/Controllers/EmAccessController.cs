using Microsoft.AspNetCore.Mvc;

namespace Emeraude.PortalGateway.Controllers;

/// <summary>
/// Gateway access controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/access/")]
public class EmAccessController : EmPortalGatewayController
{
}