using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Presentation.PortalGateway.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Definux.Emeraude.Presentation.PortalGateway.ActionFilters
{
    /// <summary>
    /// Emeraude portal action filter that checks whether Portal client can access the application via the gateway.
    /// </summary>
    public class PortalFilterAttribute : ActionFilterAttribute
    {
        private readonly EmPortalGatewayOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalFilterAttribute"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        public PortalFilterAttribute(IEmOptionsProvider optionsProvider)
        {
            this.options = optionsProvider.GetPortalGatewayOptions();
        }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey(EmPortalConstants.GatewayIdentificationHeader) ||
                !context.HttpContext.Request.Headers[EmPortalConstants.GatewayIdentificationHeader].Equals(this.options.GatewayId))
            {
                context.Result = new BadRequestResult();
            }

            base.OnActionExecuting(context);
        }
    }
}