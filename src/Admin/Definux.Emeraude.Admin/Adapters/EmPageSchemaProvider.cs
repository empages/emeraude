using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Admin.Adapters
{
    /// <summary>
    /// Admin implementation of <see cref="IEmPageSchemaProvider"/>
    /// </summary>
    public class EmPageSchemaProvider : IEmPageSchemaProvider
    {
        private readonly IEmPageService emPageService;
        private readonly IEmLogger logger;
        private readonly EmMainOptions mainOptions;
        private readonly EmAdminOptions adminOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaProvider"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="emPageService"></param>
        /// <param name="logger"></param>
        public EmPageSchemaProvider(
            IEmOptionsProvider optionsProvider,
            IEmPageService emPageService,
            IEmLogger logger)
        {
            this.emPageService = emPageService;
            this.logger = logger;
            this.mainOptions = optionsProvider.GetMainOptions();
            this.adminOptions = optionsProvider.GetAdminOptions();
        }

        /// <inheritdoc/>
        public async Task<EmPageTableViewSchema> GetTableViewSchemaAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);

            if (!schemaDescription.TableView.IsActive)
            {
                return null;
            }

            var schema = new EmPageTableViewSchema(new EmPageViewSchemaContext
            {
                Key = schemaDescription.Key,
                Title = schemaDescription.Title,
            });
            foreach (var tableViewItem in schemaDescription.TableView.ViewItems)
            {
                schema.HeadModel.Cells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                });

                schema.PropertyComponentPair[tableViewItem.SourceName] = tableViewItem.Component;
                schema.PropertyTypePair[tableViewItem.SourceName] = tableViewItem.SourceType;
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
                        ActionUrl = action.BuildActionUrlFormat(entityKey),
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
        public async Task<EmPageDetailsViewSchema> GetDetailsViewSchemaAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);

            if (!schemaDescription.DetailsView.IsActive)
            {
                return null;
            }

            var schema = new EmPageDetailsViewSchema(new EmPageViewSchemaContext
            {
                Key = schemaDescription.Key,
                Title = schemaDescription.Title,
            });

            this.MapViewSchema(schemaDescription.DetailsView, schema);

            return schema;
        }

        /// <inheritdoc/>
        public async Task<EmPageFormViewSchema> GetFormViewSchemaAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);

            if (!schemaDescription.FormView.IsActive)
            {
                return null;
            }

            var schema = new EmPageFormViewSchema(new EmPageViewSchemaContext
            {
                Key = schemaDescription.Key,
                Title = schemaDescription.Title,
            });

            return schema;
        }

        private void MapViewSchema<TViewItem>(
            ViewDescription<TViewItem> sourceDescription,
            EmPageViewSchema destinationSchema)
            where TViewItem : class, IViewItem
        {
            foreach (var pageAction in sourceDescription.PageActions)
            {
                destinationSchema.NavbarActions.Add(new ActionModel
                {
                    Title = pageAction.Name,
                    ActionUrl = pageAction.BuildActionUrlFormat(destinationSchema.Context.Key),
                    Order = pageAction.Order,
                    ActionHttpMethod = pageAction.Method,
                    OpenOnSeparatePage = pageAction.SingleContext,
                    ConfirmationMessage = pageAction.ConfirmationMessage,
                });
            }

            foreach (var breadcrumb in sourceDescription.Breadcrumbs)
            {
                destinationSchema.Breadcrumbs.Add(new BreadcrumbItemModel
                {
                    Title = breadcrumb.Title,
                    ActionUrl = breadcrumb.Href,
                    IsActive = breadcrumb.IsActive,
                    Order = breadcrumb.Order,
                });
            }
        }
    }
}