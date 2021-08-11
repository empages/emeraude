using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.ClientBuilder.Shared;
using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.ClientBuilder.Controllers.Mvc
{
    /// <summary>
    /// Controller that load the client builder as a sub-application. This controller works only at development environment.
    /// </summary>
    [Area("Admin")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public sealed class AdminClientBuilderController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClientBuilderController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        public AdminClientBuilderController(IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }
        }

        /// <summary>
        /// Index action of the controller.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/admin/client-builder/{**route}")]
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
