using Emeraude.Presentation.Controllers;
using Emeraude.Presentation.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers;

/// <summary>
/// Base portal gateway API controller.
/// </summary>
[ServiceFilter(typeof(PortalFilterAttribute))]
[EnableCors(EmPortalConstants.CorsPolicyName)]
[ApiExplorerSettings(IgnoreApi = true)]
public abstract class EmPortalGatewayApiController : EmApiController
{
}