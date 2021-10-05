using System;
using System.Collections.Generic;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.ClientBuilder.DataTransferObjects;
using Definux.Emeraude.ClientBuilder.Extensions;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.ClientBuilder.Services;
using Definux.Emeraude.ClientBuilder.Shared;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.ClientBuilder.Controllers.Api
{
    /// <summary>
    /// Client Builder API controller that provide all access and generation features.
    /// </summary>
    [Route("/api/client-builder/")]
    [EnableCors(ClientBuilderConstants.CorsPolicyName)]
    public sealed class ClientBuilderApiController : EmApiController
    {
        private readonly IEndpointService endpointService;
        private readonly IScaffoldModulesFactory scaffoldModulesFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBuilderApiController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="endpointService"></param>
        /// <param name="scaffoldModulesFactory"></param>
        public ClientBuilderApiController(
            IHostEnvironment hostEnvironment,
            IEndpointService endpointService = null,
            IScaffoldModulesFactory scaffoldModulesFactory = null)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }

            this.endpointService = endpointService;
            this.scaffoldModulesFactory = scaffoldModulesFactory;
        }

        /// <summary>
        /// Checks availability of the Client Builder.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("availability")]
        public IActionResult CheckAvailability()
        {
            return this.Ok();
        }

        /// <summary>
        /// Returns current version of the framework.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("version")]
        public IActionResult GetVersion()
        {
            var frameworkVersion = this.OptionsProvider.GetMainOptions().EmeraudeVersion;
            return this.Ok(new { Version = frameworkVersion });
        }

        /// <summary>
        /// Get all marked API endpoints detected by Client Builder.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("endpoints")]
        public IActionResult GetAllEndpoints()
        {
            return this.Ok(this.endpointService.GetAllEndpoints());
        }

        /// <summary>
        /// Get all loaded scaffold modules.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("scaffold/modules")]
        public IActionResult GetAllModules()
        {
            return this.Ok(this.scaffoldModulesFactory.Modules);
        }

        /// <summary>
        /// Trigger specified module generation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate")]
        public IActionResult GenerateModule([FromBody]ScaffoldGenerateByIdRequest request)
        {
            var targetModule = this.scaffoldModulesFactory.GetModule(request.ModuleId);
            return this.TriggerGeneration(new List<ScaffoldModule> { targetModule });
        }

        /// <summary>
        /// Trigger generation for all modules that are filtered by instance type.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate/by-instance")]
        public IActionResult GenerateMobileModules([FromBody]ScaffoldGenerateByInstanceTypeRequest request)
        {
            var modules = this.scaffoldModulesFactory.GetModulesByInstance(request.InstanceType);
            return this.TriggerGeneration(modules);
        }

        /// <summary>
        /// Trigger generation for all modules that are filtered by client id.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate/by-client")]
        public IActionResult GenerateModulesByParentModuleId([FromBody]ScaffoldGenerateByClientIdRequest request)
        {
            var modules = this.scaffoldModulesFactory.GetModulesByClientId(request.ClientId);
            return this.TriggerGeneration(modules);
        }

        /// <inheritdoc />
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!this.OptionsProvider.GetClientBuilderOptions().EnableClientBuilder)
            {
                context.Result = this.NotFound();
            }

            base.OnActionExecuting(context);
        }

        private IActionResult TriggerGeneration(IEnumerable<ScaffoldModule> modules)
        {
            string errorMessage;
            try
            {
                foreach (var module in modules)
                {
                    this.scaffoldModulesFactory.GenerateModule(module.Id, out errorMessage);
                }

                return this.Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.BadRequest(errorMessage);
        }
    }
}
