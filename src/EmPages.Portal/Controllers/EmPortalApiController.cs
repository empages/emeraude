using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.Portal.Controllers;

/// <summary>
/// Base portal API controller.
/// </summary>
[ApiExplorerSettings(IgnoreApi = true)]
[Authorize(AuthenticationSchemes = EmPortalConstants.AuthenticationScheme)]
public abstract class EmPortalApiController : ControllerBase
{
}