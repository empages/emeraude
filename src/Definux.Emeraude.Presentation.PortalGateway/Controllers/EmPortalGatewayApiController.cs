using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PortalGateway.Controllers
{
    /// <summary>
    /// Base portal gateway API controller
    /// </summary>
    [ServiceFilter(typeof(PortalFilterAttribute))]
    [EnableCors(EmPortalConstants.CorsPolicyName)]
    public abstract class EmPortalGatewayApiController : EmApiController
    {
    }
}