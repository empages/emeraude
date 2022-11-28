using System;
using System.Threading.Tasks;
using EmPages.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway page controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/page/")]
public class EmPageController : EmPortalGatewayController
{
    private readonly IEmRouter router;
    private readonly IEmPageHandler pageHandler;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageController"/> class.
    /// </summary>
    /// <param name="router"></param>
    /// <param name="pageHandler"></param>
    public EmPageController(
        IEmRouter router,
        IEmPageHandler pageHandler)
    {
        this.router = router;
        this.pageHandler = pageHandler;
    }

    /// <summary>
    /// Retrieves page data.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [Route("retrieve")]
    [HttpPost]
    public async Task<IActionResult> RetrievePage([FromBody]EmRequest request)
    {
        var pageDescriptor = this.FindPage(request.Route);
        var pageInstance = this.GetPage(pageDescriptor.PageType);
        var pageResponse = await this.pageHandler.HandleAsync(pageInstance, request.ToPageRequest(pageDescriptor));
        return this.Ok(pageResponse);
    }

    /// <summary>
    /// Executes page command.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [Route("command")]
    [HttpPost]
    public async Task<IActionResult> ExecutePageCommand([FromBody]EmRequest request)
    {
        var pageDescriptor = this.FindPage(request.Route);
        var commandType = pageDescriptor.FindCommandType(request.Command);
        if (commandType == null)
        {
            throw new EmNotRegisteredCommandException($"There is not registered command '{request.Command}' for page with route '{request.Route}'");
        }

        var commandInstance = this.GetPageCommand(commandType);
        var result = await commandInstance.HandleAsync(request.ToPageRequest(pageDescriptor));
        return this.Ok(result);
    }

    private EmPageDescriptor FindPage(string route)
    {
        var pageDescriptor = this.router.RouteToPage(route);
        if (pageDescriptor == null)
        {
            throw new EmPageNotFoundException($"Page for route {route} is not found");
        }

        return pageDescriptor;
    }

    private IEmPage GetPage(Type pageType) =>
        (IEmPage)this.HttpContext.RequestServices.GetRequiredService(pageType);

    private IEmPageCommand GetPageCommand(Type commandType) =>
        (IEmPageCommand)this.HttpContext.RequestServices.GetRequiredService(commandType);
}