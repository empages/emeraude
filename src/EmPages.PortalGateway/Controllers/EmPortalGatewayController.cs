using EmPages.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Base portal gateway API controller.
/// </summary>
[ServiceFilter(typeof(EmPortalFilterAttribute))]
[EnableCors(EmPortalGatewayConstants.CorsPolicyName)]
[ApiExplorerSettings(IgnoreApi = true)]
public abstract class EmPortalGatewayController : ControllerBase
{
}