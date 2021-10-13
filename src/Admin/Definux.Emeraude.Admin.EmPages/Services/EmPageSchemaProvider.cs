using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Configuration.Options;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Admin.EmPages.Services
{
    /// <summary>
    /// Admin implementation of <see cref="IEmPageSchemaProvider"/>
    /// </summary>
    public class EmPageSchemaProvider : IEmPageSchemaProvider
    {
        private readonly IEmPageService emPageService;
        private readonly ILogger<EmPageSchemaProvider> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaProvider"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="emPageService"></param>
        /// <param name="logger"></param>
        public EmPageSchemaProvider(
            IEmOptionsProvider optionsProvider,
            IEmPageService emPageService,
            ILogger<EmPageSchemaProvider> logger)
        {
            this.emPageService = emPageService;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<EmPageTableViewSchema> GetTableViewSchemaAsync(string route)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);

            if (!schemaDescription.TableView.IsActive)
            {
                return null;
            }

            var schema = new EmPageTableViewSchema(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            foreach (var tableViewItem in schemaDescription.TableView.ViewItems)
            {
                schema.HeadModel.Cells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                });
            }

            var actions = schemaDescription.ModelActions ?? new List<EmPageAction>();
            schema.HasActions = actions.Any();
            if (schema.HasActions)
            {
                foreach (var action in actions)
                {
                    schema.RowActions.Add(new ActionModel
                    {
                        Title = action.Name,
                        ActionUrl = action.BuildActionUrlFormat(route),
                        Order = action.Order,
                        ActionHttpMethod = action.Method,
                        OpenOnSeparatePage = action.SingleContext,
                        ConfirmationMessage = action.ConfirmationMessage,
                    });
                }
            }

            this.MapViewSchema(schemaDescription.TableView, schema);

            return schema;
        }

        /// <inheritdoc/>
        public async Task<EmPageDetailsViewSchema> GetDetailsViewSchemaAsync(string route)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);

            if (!schemaDescription.DetailsView.IsActive)
            {
                return null;
            }

            var schema = new EmPageDetailsViewSchema(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            this.MapViewSchema(schemaDescription.DetailsView, schema);

            foreach (var feature in schemaDescription.DetailsView.Features)
            {
                schema.Features.Add(new EmPageDetailsFeature
                {
                    Context = new EmPageViewContext
                    {
                        Route = feature.Route,
                        Title = feature.Title,
                    },
                });
            }

            return schema;
        }

        /// <inheritdoc/>
        public async Task<EmPageFormViewSchema> GetFormViewSchemaAsync(EmPageFormType type, string route)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);

            switch (type)
            {
                case EmPageFormType.CreateForm when !schemaDescription.FormView.IsCreateFormActive:
                case EmPageFormType.EditForm when !schemaDescription.FormView.IsEditFormActive:
                    return null;
            }

            var schema = new EmPageFormViewSchema(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            this.MapViewSchema(schemaDescription.FormView, schema);

            // Set built-in placeholders
            var breadcrumbsWithPlaceholders = schema.Context.Breadcrumbs.Where(x => x.IsUsingPlaceholder);
            foreach (var breadcrumb in breadcrumbsWithPlaceholders)
            {
                if (EmPagesPlaceholders.TrySetFormAction(breadcrumb.Title, type, out var foundPlaceholderValue))
                {
                    breadcrumb.Title = foundPlaceholderValue;
                }
            }

            return schema;
        }

        private void MapViewSchema<TViewItem>(
            ViewDescription<TViewItem> sourceDescription,
            EmPageViewSchema destinationSchema)
            where TViewItem : class, IViewItem
        {
            foreach (var pageAction in sourceDescription.PageActions)
            {
                destinationSchema.Context.NavbarActions.Add(new ActionModel
                {
                    Title = pageAction.Name,
                    ActionUrl = pageAction.BuildActionUrlFormat(destinationSchema.Context.Route),
                    Order = pageAction.Order,
                    ActionHttpMethod = pageAction.Method,
                    OpenOnSeparatePage = pageAction.SingleContext,
                    ConfirmationMessage = pageAction.ConfirmationMessage,
                });
            }

            foreach (var breadcrumb in sourceDescription.Breadcrumbs)
            {
                destinationSchema.Context.Breadcrumbs.Add(new BreadcrumbItemModel
                {
                    Title = breadcrumb.Title,
                    ActionUrl = breadcrumb.Href,
                    IsActive = breadcrumb.IsActive,
                    Order = breadcrumb.Order,
                });
            }

            foreach (var viewItem in sourceDescription.ViewItems)
            {
                destinationSchema.PropertyComponentPair[viewItem.SourceName] = viewItem.Component;
                destinationSchema.PropertyTypePair[viewItem.SourceName] = viewItem.SourceType;
                destinationSchema.PropertyParametersPair[viewItem.SourceName] = viewItem.Parameters;
            }
        }
    }
}