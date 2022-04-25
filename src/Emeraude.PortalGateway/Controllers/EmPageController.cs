using System.Threading.Tasks;
using Emeraude.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.PortalGateway.Controllers;

/// <summary>
/// Gateway page controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/pages/")]
public class EmPageController : EmPortalGatewayController
{
    private readonly IEmRouter router;
    private readonly IEmPageMapper pageMapper;
    private readonly IEmServiceFactory serviceFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageController"/> class.
    /// </summary>
    /// <param name="router"></param>
    /// <param name="pageMapper"></param>
    /// <param name="serviceFactory"></param>
    public EmPageController(
        IEmRouter router,
        IEmPageMapper pageMapper,
        IEmServiceFactory serviceFactory)
    {
        this.router = router;
        this.pageMapper = pageMapper;
        this.serviceFactory = serviceFactory;
    }

    /// <summary>
    /// Retrieves page data.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("retrieve")]
    public async Task<IActionResult> RetrievePage([FromBody]EmRequest request)
    {
        var pageDescriptor = this.FindPage(request.Route);
        var pageInstance = this.serviceFactory.CreatePage(pageDescriptor.PageType);
        var pageResponse = await this.pageMapper.MapAsync(pageInstance, request.ToPageRequest());
        return this.Ok(pageResponse);
    }

    /// <summary>
    /// Executes page command.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("command")]
    public async Task<IActionResult> ExecutePageCommand([FromBody]EmRequest request)
    {
        var pageDescriptor = this.FindPage(request.Route);
        var commandType = pageDescriptor.FindCommandType(request.Command);
        if (commandType == null)
        {
            throw new EmNotRegisteredCommandException($"There is not registered command '{request.Command}' for page with route '{request.Route}'");
        }

        var commandInstance = this.serviceFactory.CreateCommand(commandType);
        await commandInstance.HandleAsync(request.ToCommandPageRequest());
        return this.Ok();
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
}