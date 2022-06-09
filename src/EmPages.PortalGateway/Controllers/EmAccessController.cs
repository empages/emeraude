using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway access controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/access/")]
public class EmAccessController : EmPortalGatewayController
{
}