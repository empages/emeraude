using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Application.Admin.Models;
using Emeraude.Essentials.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <inheritdoc cref="IEmPageManager" />
    public partial class EmPageManager : IEmPageManager
    {
        private readonly IEmPageService emPageService;
        private readonly IServiceProvider serviceProvider;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IAuthorizationService authorizationService;
        private readonly JsonOptions jsonOptions;
        private readonly ILogger<EmPageManager> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageManager"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="jsonOptionsAccessor"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="authorizationService"></param>
        /// <param name="logger"></param>
        public EmPageManager(
            IEmPageService emPageService,
            IServiceProvider serviceProvider,
            IOptions<JsonOptions> jsonOptionsAccessor,
            IHttpContextAccessor httpContextAccessor,
            IAuthorizationService authorizationService,
            ILogger<EmPageManager> logger)
        {
            this.emPageService = emPageService;
            this.serviceProvider = serviceProvider;
            this.httpContextAccessor = httpContextAccessor;
            this.authorizationService = authorizationService;
            this.jsonOptions = jsonOptionsAccessor.Value;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteModelAsync(string route, string modelId)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            await this.EmPageOperationAuthorizationGuardAsync(EmPageOperation.DeleteModel, schemaDescription);
            var dataManager = this.GetDataManagerInstance(schemaDescription);
            return await dataManager.DeleteAsync(modelId);
        }

        private IEmPageDataManager GetDataManagerInstance(EmPageSchemaDescription schemaDescription)
        {
            var dataManager = this.serviceProvider.GetService(schemaDescription.DataManagerType) as IEmPageDataManager;
            if (dataManager == null)
            {
                this.logger.LogWarning("No data manager has been found for schema with route {Route}", schemaDescription.Route);
                throw new EmPageMissingConfigurationException($"No data manager has been found for schema with route {schemaDescription.Route}");
            }

            return dataManager;
        }

        private void SetDataRelatedPlaceholders(IEnumerable<BreadcrumbItemModel> breadcrumbs, IEmPageModel model, EmPageSchemaDescription schemaDescription)
        {
            foreach (var breadcrumb in breadcrumbs)
            {
                if (!string.IsNullOrWhiteSpace(breadcrumb.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(breadcrumb.Title, model, schemaDescription.Route, out var convertedTitle))
                {
                    breadcrumb.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(breadcrumb.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(breadcrumb.ActionUrl, model, schemaDescription.Route, out var convertedUrl))
                {
                    breadcrumb.ActionUrl = convertedUrl;
                }
            }
        }

        private void SetDataRelatedPlaceholders(IEnumerable<ActionModel> actions, IEmPageModel model, EmPageSchemaDescription schemaDescription)
        {
            foreach (var actionModel in actions)
            {
                if (!string.IsNullOrWhiteSpace(actionModel.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.Title, model, schemaDescription.Route, out var convertedTitle))
                {
                    actionModel.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(actionModel.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.ActionUrl, model, schemaDescription.Route, out var convertedUrl))
                {
                    actionModel.ActionUrl = convertedUrl;
                }
            }
        }

        private void SetDataRelatedPlaceholders(IEnumerable<ActionModel> actions, EmPageModelResponse modelResponse, EmPageSchemaDescription schemaDescription)
        {
            var fields = modelResponse.Fields.ToDictionary(k => k.Property, v => v.Value);
            if (!fields.ContainsKey("Id"))
            {
                fields["Id"] = modelResponse.Identifier;
            }

            foreach (var actionModel in actions)
            {
                if (!string.IsNullOrWhiteSpace(actionModel.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.Title, fields, schemaDescription.Route, out var convertedTitle))
                {
                    actionModel.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(actionModel.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.ActionUrl, fields, schemaDescription.Route, out var convertedUrl))
                {
                    actionModel.ActionUrl = convertedUrl;
                }
            }
        }

        private void MapToViewModel<TViewItem>(
            ViewDescription<TViewItem> sourceDescription,
            EmPageViewModel model)
            where TViewItem : class, IViewItem
        {
            foreach (var pageAction in sourceDescription.PageActions)
            {
                model.Context.NavbarActions.Add(this.MapAction(pageAction, model.Context.Route));
            }

            foreach (var breadcrumb in sourceDescription.Breadcrumbs)
            {
                model.Context.Breadcrumbs.Add(this.MapBreadcrumb(breadcrumb));
            }

            foreach (var viewItem in sourceDescription.ViewItems)
            {
                model.PropertyComponentMap.Add(new PropertyMap<EmPageComponent>(viewItem.SourceName, viewItem.Component));
                model.PropertyParametersMap.Add(new PropertyMap<object>(viewItem.SourceName, viewItem.Parameters));
                model.PropertyOrderMap.Add(new PropertyMap<int>(viewItem.SourceName, viewItem.Order));

                var originalSourceType = ReflectionHelpers.GetTypeByIgnoreTheNullable(viewItem.SourceType);
                if (originalSourceType.IsEnum && !model.ModelEnumerations.ContainsKey(originalSourceType.FullName))
                {
                    model.ModelEnumerations[originalSourceType.FullName] = EnumUtilities.GetEnumValueItems(originalSourceType);
                }
            }
        }

        private BreadcrumbItemModel MapBreadcrumb(EmPageBreadcrumb breadcrumb) =>
            new ()
            {
                Title = breadcrumb.Title,
                ActionUrl = breadcrumb.Href,
                IsActive = breadcrumb.IsActive,
                Order = breadcrumb.Order,
            };

        private ActionModel MapAction(EmPageAction action, string contextRoute) =>
            new ()
            {
                Title = action.Name,
                ActionUrl = action.BuildActionUrlFormat(contextRoute),
                Order = action.Order,
                ActionHttpMethod = action.Method,
                OpenOnSeparatePage = action.SingleContext,
                ConfirmationMessage = action.ConfirmationMessage,
            };

        private async Task EmPageOperationAuthorizationGuardAsync(EmPageOperation operation, EmPageSchemaDescription schemaDescription)
        {
            if (!await this.IsOperationPermittedAsync(operation, schemaDescription))
            {
                string friendlyOperationName = StringUtilities.SplitWordsByCapitalLetters(operation.ToString());
                throw new EmPageAuthorizationException($"Current user is not authorized to execute '{friendlyOperationName}' operation for schema with route: '{schemaDescription.Route}'");
            }
        }

        private async Task<bool> IsOperationPermittedAsync(EmPageOperation operation, EmPageSchemaDescription schemaDescription)
        {
            if (!schemaDescription.OperationsAuthorizationRequirements.ContainsKey(operation))
            {
                return true;
            }

            var requirements = schemaDescription.OperationsAuthorizationRequirements[operation];
            return await this.IsUserAuthorizedAsync(requirements);
        }

        private async Task<bool> IsUserAuthorizedAsync(IEnumerable<IAuthorizationRequirement> requirements)
        {
            try
            {
                if (this.httpContextAccessor.HttpContext?.User == null)
                {
                    return false;
                }

                var authorizationResult = await this.authorizationService.AuthorizeAsync(this.httpContextAccessor.HttpContext?.User, null, requirements);
                return authorizationResult?.Succeeded ?? false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}