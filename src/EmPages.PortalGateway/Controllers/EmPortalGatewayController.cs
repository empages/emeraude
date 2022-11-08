using EmPages.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Base portal gateway API controller.
/// </summary>
[ServiceFilter(typeof(EmPortalFilterAttribute))]
[EnableCors(EmPortalGatewayConstants.CorsPolicyName)]
[ApiExplorerSettings(IgnoreApi = true)]
[Authorize(AuthenticationSchemes = EmPortalGatewayConstants.AuthenticationScheme)]
public abstract class EmPortalGatewayController : ControllerBase
{
}