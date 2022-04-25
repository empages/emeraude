using Microsoft.AspNetCore.Mvc;

namespace Emeraude.PortalGateway.Controllers;

/// <summary>
/// Gateway identity controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/identity/")]
public class EmIdentityController : EmPortalGatewayController
{
}