using System;
using System.Collections.Generic;
using System.Linq;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.FormView;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Application.Admin.Models;
using Emeraude.Essentials.Helpers;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <inheritdoc cref="IEmPageManager" />
    public partial class EmPageManager : IEmPageManager
    {
        private readonly IEmPageService emPageService;
        private readonly IServiceProvider serviceProvider;
        private readonly ILogger<EmPageManager> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageManager"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="logger"></param>
        public EmPageManager(
            IEmPageService emPageService,
            IServiceProvider serviceProvider,
            ILogger<EmPageManager> logger)
        {
            this.emPageService = emPageService;
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        private IEmPageModel BuildModel(IEnumerable<EmPageFormInputModel> inputs, Type modelType) =>
            DictionaryUtilities.NewClassInstanceFromDictionary(
                modelType,
                inputs.ToDictionary(k => k.Property, v => v.Value)) as IEmPageModel;

        private IEmPageDataManager GetDataManagerInstance(EmPageSchemaDescription schemaDescription)
        {
            if (schemaDescription == null)
            {
                throw new ArgumentNullException(nameof(schemaDescription));
            }

            return this.serviceProvider.GetService(schemaDescription.DataManagerType) as IEmPageDataManager;
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
                var itemParameters = viewItem.Parameters.Select(x => new Parameter { Name = x.Key, Value = x.Value });
                model.PropertyComponentMap.Add(new PropertyMap<EmPageComponent>(viewItem.SourceName, viewItem.Component));
                model.PropertyParametersMap.Add(new PropertyMap<IEnumerable<Parameter>>(viewItem.SourceName, itemParameters));
                model.PropertyOrderMap.Add(new PropertyMap<int>(viewItem.SourceName, viewItem.Order));

                if (viewItem.SourceType.IsEnum && !model.ModelEnumerations.ContainsKey(viewItem.SourceType.FullName))
                {
                    model.ModelEnumerations[viewItem.SourceType.FullName] = EnumUtilities.GetEnumValueItems(viewItem.SourceType);
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
    }
}