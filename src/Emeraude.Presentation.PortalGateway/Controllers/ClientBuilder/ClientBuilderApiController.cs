using System;
using System.Collections.Generic;
using Emeraude.Application.ClientBuilder.DataTransferObjects;
using Emeraude.Application.ClientBuilder.Extensions;
using Emeraude.Application.ClientBuilder.ScaffoldModules;
using Emeraude.Application.ClientBuilder.Services;
using Emeraude.Application.ClientBuilder.Shared;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;

namespace Emeraude.Presentation.PortalGateway.Controllers.ClientBuilder
{
    /// <summary>
    /// Client Builder API controller that provide all access and generation features.
    /// </summary>
    [Route("/_em/api/client-builder/")]
    public sealed class ClientBuilderApiController : EmPortalGatewayApiController
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
        /// Get all marked API endpoints detected by Client Builder.
        /// </summary>
        /// <returns></returns>
        [HttpGet("endpoints")]
        public IActionResult GetAllEndpoints()
        {
            return this.Ok(this.endpointService.GetAllEndpoints());
        }

        /// <summary>
        /// Get all loaded scaffold modules.
        /// </summary>
        /// <returns></returns>
        [HttpGet("scaffold/modules")]
        public IActionResult GetAllModules()
        {
            return this.Ok(this.scaffoldModulesFactory.Modules);
        }

        /// <summary>
        /// Trigger specified module generation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("scaffold/generate")]
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
        [HttpPost("scaffold/generate/by-instance")]
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

                return this.Ok(SimpleResult.SuccessfulResult);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.BadRequest(errorMessage);
        }
    }
}
