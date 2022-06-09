using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway general controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/general/")]
public class EmGeneralController : EmPortalGatewayController
{
}