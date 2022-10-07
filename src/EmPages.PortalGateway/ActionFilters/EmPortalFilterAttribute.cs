using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmPages.PortalGateway.ActionFilters;

/// <summary>
/// EmPages portal action filter that checks whether Portal client can access the application via the gateway.
/// </summary>
public class EmPortalFilterAttribute : ActionFilterAttribute
{
    private readonly IEmPortalGatewayOptions options;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPortalFilterAttribute"/> class.
    /// </summary>
    /// <param name="options"></param>
    public EmPortalFilterAttribute(IEmPortalGatewayOptions options)
    {
        this.options = options;
    }

    /// <inheritdoc/>
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey(EmPortalGatewayConstants.GatewayIdentificationHeader) ||
            !context.HttpContext.Request.Headers[EmPortalGatewayConstants.GatewayIdentificationHeader].Equals(this.options.GatewayId))
        {
            context.Result = new NotFoundResult();
        }

        base.OnActionExecuting(context);
    }
}