using System.Collections.Generic;
using EmPages.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway access controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/config")]
public class EmConfigurationController : EmPortalGatewayController
{
    private readonly IWebHostEnvironment hostEnvironment;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmConfigurationController"/> class.
    /// </summary>
    /// <param name="hostEnvironment"></param>
    public EmConfigurationController(IWebHostEnvironment hostEnvironment)
    {
        this.hostEnvironment = hostEnvironment;
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
                Endpoints = new List<EmPortalConfiguration.EmPortalSourceConfigurationApiEndpoint>
                {
                    new ()
                    {
                        Id = "identity.auth.login",
                        Route = "/__em/identity/auth/login",
                        Method = "POST",
                    },
                    new ()
                    {
                        Id = "identity.auth.login.mfa",
                        Route = "/__em/identity/auth/login-mfa",
                        Method = "POST",
                    },
                },
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