using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Presentation.PortalGateway.Controllers.Admin
{
    /// <summary>
    /// Admin EmPages API controller.
    /// </summary>
    [Route("/_em/api/admin/em-pages/")]
    [Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
    public class AdminEmPagesApiController : EmPortalGatewayApiController
    {
        private readonly IEmPageManager emPageManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminEmPagesApiController"/> class.
        /// </summary>
        /// <param name="emPageManager"></param>
        public AdminEmPagesApiController(IEmPageManager emPageManager)
        {
            this.emPageManager = emPageManager;
        }

        /// <summary>
        /// Gets index view model.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("index/{route}")]
        public async Task<IActionResult> GetIndexViewModel(string route)
        {
            var viewModel = await this.emPageManager.RetrieveIndexViewModelAsync(route, this.GetQuery());
            if (viewModel == null)
            {
                return this.NotFound();
            }

            return this.Ok(viewModel);
        }

        /// <summary>
        /// Gets details view model.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="modelId"></param>
        /// <returns></returns>
        [HttpGet("details/{route}/{modelId}")]
        public async Task<IActionResult> GetDetailsViewModel(string route, string modelId)
        {
            var viewModel = await this.emPageManager.RetrieveDetailsViewModelAsync(route, modelId, this.GetQuery());
            if (viewModel == null)
            {
                return this.NotFound();
            }

            return this.Ok(viewModel);
        }

        /// <summary>
        /// Gets form view model.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="modelId"></param>
        /// <returns></returns>
        [HttpGet("form/{route}/{modelId?}")]
        public async Task<IActionResult> GetFormViewModel(string route, string modelId = null)
        {
            var type = string.IsNullOrWhiteSpace(modelId) ? EmPageFormType.CreateForm : EmPageFormType.EditForm;
            var viewModel = await this.emPageManager.RetrieveFormViewModelAsync(type, route, modelId, this.GetQuery());
            if (viewModel == null)
            {
                return this.NotFound();
            }

            return this.Ok(viewModel);
        }

        /// <summary>
        /// Gets feature view model.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="modelId"></param>
        /// <param name="featureRoute"></param>
        /// <returns></returns>
        [HttpGet("feature/{route}/{modelId}/{featureRoute}")]
        public async Task<IActionResult> GetFeatureTableViewModel(string route, string modelId, string featureRoute)
        {
            var detailsViewModel = await this.emPageManager.RetrieveDetailsViewModelAsync(route, modelId, this.GetQuery());
            if (detailsViewModel == null)
            {
                return this.NotFound();
            }

            var feature = detailsViewModel
                .Features
                .FirstOrDefault(x => x.Context.Route.Equals(featureRoute, StringComparison.OrdinalIgnoreCase));

            if (feature == null)
            {
                return this.NotFound();
            }

            var featureViewModel = await this.emPageManager.RetrieveFeatureIndexViewModelAsync(feature, detailsViewModel, this.GetQuery());
            if (featureViewModel == null)
            {
                return this.NotFound();
            }

            return this.Ok(featureViewModel);
        }

        private IDictionary<string, StringValues> GetQuery()
            => this.Request.Query.ToDictionary(k => k.Key, v => v.Value);
    }
}