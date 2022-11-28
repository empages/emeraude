using System.Threading.Tasks;
using EmPages.Pages;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway layout controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/layout/")]
public class EmLayoutController : EmPortalGatewayController
{
    private readonly IEmLayoutService layoutService;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmLayoutController"/> class.
    /// </summary>
    /// <param name="layoutService"></param>
    public EmLayoutController(IEmLayoutService layoutService)
    {
        this.layoutService = layoutService;
    }

    /// <summary>
    /// Fetches pages navigation.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetLayout() =>
        this.Ok(this.layoutService.GetLayout());
}