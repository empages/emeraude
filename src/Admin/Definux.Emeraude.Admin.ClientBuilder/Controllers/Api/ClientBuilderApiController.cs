using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.DataTransferObjects;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Hosting;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Presentation.Controllers;

namespace Definux.Emeraude.Admin.ClientBuilder.Controllers.Api
{
    [Route("/api/client-builder/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class ClientBuilderApiController : ApiController
    {
        private readonly IPageService pageService;
        private readonly IEndpointService endpointService;
        private readonly IScaffoldModulesProvider scaffoldModulesProvider;

        public ClientBuilderApiController(
            IHostEnvironment hostEnvironment,
            IPageService pageService,
            IEndpointService endpointService,
            IScaffoldModulesProvider scaffoldModulesProvider)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }

            this.pageService = pageService;
            this.endpointService = endpointService;
            this.scaffoldModulesProvider = scaffoldModulesProvider;
        }

        [HttpGet]
        [Route("pages")]
        public IActionResult GetAllPages()
        {
            return Ok(this.pageService.GetAllPages());
        }

        [HttpGet]
        [Route("endpoints")]
        public IActionResult GetAllEndpoints()
        {
            return Ok(this.endpointService.GetAllEndpoints());
        }

        [HttpGet]
        [Route("scaffold/modules")]
        public IActionResult GetAllModules()
        {
            return Ok(this.scaffoldModulesProvider.Modules);
        }

        [HttpPost]
        [Route("scaffold/generate")]
        public IActionResult GenerateModule([FromBody]ScaffoldGenerateRequest request)
        {
            string errorMessage = null;
            try
            {
                if (this.scaffoldModulesProvider.GenerateModule(request.ModuleId, out errorMessage))
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return BadRequest(errorMessage);
        }

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

                return Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return BadRequest(errorMessage);
        }

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

                return Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return BadRequest(errorMessage);
        }

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

                return Ok();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return BadRequest(errorMessage);
        }
    }
}
