using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway identity controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/identity/")]
public class EmIdentityController : EmPortalGatewayController
{
}