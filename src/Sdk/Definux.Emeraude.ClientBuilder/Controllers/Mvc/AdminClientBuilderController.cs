using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.ClientBuilder.Extensions;
using Definux.Emeraude.ClientBuilder.Shared;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.ClientBuilder.Controllers.Mvc
{
    /// <summary>
    /// Controller that load the client builder as a sub-application. This controller works only at development environment.
    /// </summary>
    [Area("Admin")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = EmAuthenticationDefaults.AdminAuthenticationScheme)]
    public sealed class AdminClientBuilderController : Controller
    {
        private readonly IEmOptionsProvider optionsProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClientBuilderController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="optionsProvider"></param>
        public AdminClientBuilderController(IHostEnvironment hostEnvironment, IEmOptionsProvider optionsProvider)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }

            this.optionsProvider = optionsProvider;
        }

        /// <summary>
        /// Index action of the controller.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/admin/client-builder/{**route}")]
        public IActionResult Index()
        {
            if (!this.optionsProvider.GetClientBuilderOptions().EnableClientBuilder)
            {
                return this.NotFound();
            }

            return this.View();
        }
    }
}
