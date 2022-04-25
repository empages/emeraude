using Emeraude.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.PortalGateway.Controllers;

/// <summary>
/// Base portal gateway API controller.
/// </summary>
[ServiceFilter(typeof(EmPortalFilterAttribute))]
[EnableCors(EmPortalGatewayConstants.CorsPolicyName)]
[ApiExplorerSettings(IgnoreApi = true)]
public abstract class EmPortalGatewayController : ControllerBase
{
}