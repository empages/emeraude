using System.Reflection;
using Emeraude.Presentation.PortalGateway.Controllers.Admin;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Emeraude.Presentation.PortalGateway.FeatureProviders
{
    /// <summary>
    /// Feature provider for defining the default admin authentication controller.
    /// </summary>
    /// <typeparam name="TControllerType">Type of the controller.</typeparam>
    public class AdminAuthControllerFeatureProvider<TControllerType> : ControllerFeatureProvider
        where TControllerType : class, IAdminAuthApiController
    {
        /// <inheritdoc/>
        protected override bool IsController(TypeInfo typeInfo)
        {
            if (!typeInfo.IsAbstract && typeInfo == typeof(TControllerType))
            {
                return true;
            }

            return base.IsController(typeInfo);
        }
    }
}