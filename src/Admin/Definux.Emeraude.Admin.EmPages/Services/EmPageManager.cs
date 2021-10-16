using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Schema.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Essentials.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
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

        private void SetDataRelatedPlaceholders(IEnumerable<BreadcrumbItemModel> breadcrumbs, IEmPageModel model)
        {
            foreach (var breadcrumb in breadcrumbs)
            {
                if (!string.IsNullOrWhiteSpace(breadcrumb.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(breadcrumb.Title, model, out var convertedTitle))
                {
                    breadcrumb.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(breadcrumb.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(breadcrumb.ActionUrl, model, out var convertedUrl))
                {
                    breadcrumb.ActionUrl = convertedUrl;
                }
            }
        }

        private void SetDataRelatedPlaceholders(IEnumerable<ActionModel> actions, IEmPageModel model)
        {
            foreach (var actionModel in actions)
            {
                if (!string.IsNullOrWhiteSpace(actionModel.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.Title, model, out var convertedTitle))
                {
                    actionModel.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(actionModel.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.ActionUrl, model, out var convertedUrl))
                {
                    actionModel.ActionUrl = convertedUrl;
                }
            }
        }

        private void SetDataRelatedPlaceholders(IEnumerable<ActionModel> actions, EmPageModelResponse modelResponse)
        {
            var fields = modelResponse.Fields.ToDictionary(k => k.Property, v => v.Value);
            if (!fields.ContainsKey("Id"))
            {
                fields["Id"] = modelResponse.Identifier;
            }

            foreach (var actionModel in actions)
            {
                if (!string.IsNullOrWhiteSpace(actionModel.Title) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.Title, fields, out var convertedTitle))
                {
                    actionModel.Title = convertedTitle;
                }

                if (!string.IsNullOrWhiteSpace(actionModel.ActionUrl) && EmPagesPlaceholders.TryApplyModelPropertiesPlaceholders(actionModel.ActionUrl, fields, out var convertedUrl))
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
                model.PropertyComponentPair[viewItem.SourceName] = viewItem.Component;
                model.PropertyTypePair[viewItem.SourceName] = viewItem.SourceType;
                model.PropertyParametersPair[viewItem.SourceName] = viewItem.Parameters;
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