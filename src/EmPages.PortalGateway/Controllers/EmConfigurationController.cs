using System.Collections.Generic;
using EmPages.Common;
using EmPages.PortalGateway.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway configuration controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/config")]
public class EmConfigurationController : EmPortalGatewayController
{
    private readonly IWebHostEnvironment hostEnvironment;
    private readonly IGatewayEndpointsRetriever gatewayEndpointsRetriever;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmConfigurationController"/> class.
    /// </summary>
    /// <param name="hostEnvironment"></param>
    /// <param name="gatewayEndpointsRetriever"></param>
    public EmConfigurationController(IWebHostEnvironment hostEnvironment, IGatewayEndpointsRetriever gatewayEndpointsRetriever)
    {
        this.hostEnvironment = hostEnvironment;
        this.gatewayEndpointsRetriever = gatewayEndpointsRetriever;
    }

    /// <summary>
    /// Construct portal configuration file.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult GetConfiguration() =>
        this.Ok(new EmPortalConfiguration
        {
            Framework = new EmPortalConfiguration.EmPortalFrameworkConfiguration
            {
                Name = EmConstants.FrameworkName,
                Version = this.GetType()?.Assembly?.GetName()?.Version?.ToString(),
            },
            Source = new EmPortalConfiguration.EmPortalSourceConfiguration
            {
                BaseUrl = this.GetBaseUrl(),
                Environment = this.hostEnvironment.EnvironmentName,
                Endpoints = this.gatewayEndpointsRetriever.RetrieveApiEndpoints(),
            },
            Identity = new EmPortalConfiguration.EmPortalIdentityConfiguration
            {
                IsAuthenticated = this.User?.Identity?.IsAuthenticated ?? false,
                CurrentUser = null,
            },
            Pages = new List<EmPortalConfiguration.EmPortalPageConfiguration>(),
        });

    private string GetBaseUrl()
    {
        return $"{(this.HttpContext.Request.IsHttps ? "https" : "http")}://{this.HttpContext.Request.Host.Value}";
    }
}