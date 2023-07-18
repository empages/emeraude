using System.Threading.Tasks;
using EmPages.Pages;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.Portal.Controllers;

/// <summary>
/// Gateway layout controller.
/// </summary>
[Route($"{EmPortalConstants.RouteApiPrefix}/layout/")]
public class EmLayoutApiController : EmPortalApiController
{
    private readonly IEmLayoutService layoutService;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmLayoutApiController"/> class.
    /// </summary>
    /// <param name="layoutService"></param>
    public EmLayoutApiController(IEmLayoutService layoutService)
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