using System.Collections.Generic;
using Emeraude.Configuration.Options;
using Emeraude.Presentation.PortalGateway.Controllers.Admin;
using Emeraude.Presentation.PortalGateway.FeatureProviders;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Emeraude.Presentation.PortalGateway;

/// <summary>
/// Options for Emeraude portal.
/// </summary>
public class EmPortalGatewayOptions : IEmOptions
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPortalGatewayOptions"/> class.
    /// </summary>
    public EmPortalGatewayOptions()
    {
        this.PortalUrls = new List<string>
        {
            EmPortalConstants.EmeraudePortalUrl,
        };
    }

    /// <summary>
    /// List of all portal URLs that consume data through the gateway.
    /// </summary>
    public IList<string> PortalUrls { get; }

    /// <summary>
    /// Identification of the gateway. Make sure that value is complex enough.
    /// </summary>
    public string GatewayId { get; set; }

    /// <summary>
    /// Admin auth controller feature provider for informing the MVC configuration how to recognize the admin authentication API controller.
    /// </summary>
    public ControllerFeatureProvider AdminAuthControllerFeatureProvider { get; private set; } = new AdminAuthControllerFeatureProvider<AdminAuthApiController>();

    /// <summary>
    /// Sets the admin authentication controller.
    /// For the purposes of overriding - make your own admin authentication controller by implement <see cref="IAdminAuthApiController"/>.
    /// </summary>
    /// <typeparam name="TControllerType">Type of the controller.</typeparam>
    public void SetAdminAuthenticationController<TControllerType>()
        where TControllerType : class, IAdminAuthApiController
    {
        this.AdminAuthControllerFeatureProvider = new AdminAuthControllerFeatureProvider<TControllerType>();
    }

    /// <summary>
    /// Disables the admin authentication.
    /// </summary>
    public void DisableAdminAuthentication() => this.AdminAuthControllerFeatureProvider = null;

    /// <inheritdoc/>
    public void Validate()
    {
    }
}