using System;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.ClientBuilder.DataTransferObjects;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.ClientBuilder.Services;
using Definux.Emeraude.ClientBuilder.Shared;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.ClientBuilder.Controllers.Api
{
    /// <summary>
    /// Client Builder API controller that provide all access and generation features.
    /// </summary>
    [Route("/api/client-builder/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public sealed class ClientBuilderApiController : ApiController
    {
        private readonly IEndpointService endpointService;
        private readonly IScaffoldModulesProvider scaffoldModulesProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBuilderApiController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="endpointService"></param>
        /// <param name="scaffoldModulesProvider"></param>
        public ClientBuilderApiController(
            IHostEnvironment hostEnvironment,
            IEndpointService endpointService,
            IScaffoldModulesProvider scaffoldModulesProvider)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }

            this.endpointService = endpointService;
            this.scaffoldModulesProvider = scaffoldModulesProvider;
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
            return this.Ok(this.scaffoldModulesProvider.Modules);
        }

        /// <summary>
        /// Trigger specified module generation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate")]
        public IActionResult GenerateModule([FromBody]ScaffoldGenerateRequest request)
        {
            string errorMessage = null;
            try
            {
                if (this.scaffoldModulesProvider.GenerateModule(request.ModuleId, out errorMessage))
                {
                    return this.Ok();
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.BadRequest(errorMessage);
        }

        /// <summary>
        /// Trigger all loaded web modules generation.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate/web")]
        public IActionResult GenerateWebModules()
        {
            string errorMessage = null;
            try
            {
                var modules = this.scaffoldModulesProvider.WebModules;
                foreach (var module in modules)
                {
                    this.scaffoldModulesProvider.GenerateModule(module.Id, out errorMessage);
                }

                return this.Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.BadRequest(errorMessage);
        }

        /// <summary>
        /// Trigger all loaded mobile modules generation.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate/mobile")]
        public IActionResult GenerateMobileModules()
        {
            string errorMessage = null;
            try
            {
                var modules = this.scaffoldModulesProvider.MobileModules;
                foreach (var module in modules)
                {
                    this.scaffoldModulesProvider.GenerateModule(module.Id, out errorMessage);
                }

                return this.Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.BadRequest(errorMessage);
        }

        /// <summary>
        /// Trigger all filtered by parent module id loaded modules generation.
        /// </summary>
        /// <param name="parentModuleId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scaffold/generate/{parentModuleId}")]
        public IActionResult GenerateModulesByParentModuleId(string parentModuleId)
        {
            string errorMessage = null;
            try
            {
                var modules = this.scaffoldModulesProvider.GetModulesByParentModuleId(parentModuleId);
                foreach (var module in modules)
                {
                    this.scaffoldModulesProvider.GenerateModule(module.Id, out errorMessage);
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
