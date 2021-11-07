using System.Linq;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Infrastructure.FileStorage.Services;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.PortalGateway.Extensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Definux.Emeraude.Presentation.PortalGateway.Controllers
{
    /// <summary>
    /// Runtime assets API controller.
    /// </summary>
    [Route("/_em/api/runtime-assets/")]
    [DisableCors]
    public class AdminRuntimeAssetsApiController : EmApiController
    {
        private const string RuntimeInjectionStyleFileName = "runtime-injection.style.min.css";
        private const string RuntimeInjectionBundleFileName = "runtime-injection.bundle.min.js";
        private const string PrivateRootPortalFolder = "portal";

        private readonly IRootsService rootsService;
        private readonly ISystemFilesService systemFilesService;
        private readonly EmPortalGatewayOptions portalGatewayOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRuntimeAssetsApiController"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="rootsService"></param>
        /// <param name="systemFilesService"></param>
        public AdminRuntimeAssetsApiController(
            IEmOptionsProvider optionsProvider,
            IRootsService rootsService,
            ISystemFilesService systemFilesService)
        {
            this.rootsService = rootsService;
            this.systemFilesService = systemFilesService;
            this.portalGatewayOptions = optionsProvider.GetPortalGatewayOptions();
        }

        /// <summary>
        /// Gets runtime injection styles.
        /// </summary>
        /// <returns></returns>
        [HttpGet(RuntimeInjectionStyleFileName)]
        public IActionResult GetInjectionStyle()
        {
            string stylesPath = this.rootsService.GetPathFromPrivateRoot(PrivateRootPortalFolder, RuntimeInjectionStyleFileName);

            var stylesFile = this.systemFilesService.GetFile(stylesPath);
            return this.File(stylesFile.Stream, stylesFile.ContentType);
        }

        /// <summary>
        /// Gets runtime injection scripts.
        /// </summary>
        /// <returns></returns>
        [HttpGet(RuntimeInjectionBundleFileName)]
        public IActionResult GetInjectionBundle()
        {
            string scriptsPath = this.rootsService.GetPathFromPrivateRoot(PrivateRootPortalFolder, RuntimeInjectionBundleFileName);

            var scriptsFile = this.systemFilesService.GetFile(scriptsPath);
            return this.File(scriptsFile.Stream, scriptsFile.ContentType);
        }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Query.TryGetValue("gatewayId", out var gatewayId) ||
                !this.portalGatewayOptions.GatewayId.Equals(gatewayId.FirstOrDefault()))
            {
                context.Result = this.BadRequest();
            }

            base.OnActionExecuting(context);
        }
    }
}