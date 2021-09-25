using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.Models;
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
    public class EntitiesViewsSchemaProvider : IEmPageSchemaProvider
    {
        private readonly IEmPageService emPageService;
        private readonly IEmLogger logger;
        private readonly EmMainOptions mainOptions;
        private readonly EmAdminOptions adminOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesViewsSchemaProvider"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="emPageService"></param>
        /// <param name="logger"></param>
        public EntitiesViewsSchemaProvider(
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

            if (!schemaDescription.TableViewItems.Any())
            {
                return null;
            }

            var schema = new EmPageTableViewSchema(new EmPageViewSchemaContext
            {
                Key = schemaDescription.Key,
                Title = schemaDescription.Title,
            });
            foreach (var tableViewItem in schemaDescription.TableViewItems)
            {
                schema.HeadModel.Cells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                });

                schema.PropertyComponentPair[tableViewItem.SourceName] = tableViewItem.Component;
                schema.PropertyTypePair[tableViewItem.SourceName] = tableViewItem.SourceType;
            }

            var actions = schemaDescription.ModelActions ?? new List<EntityModelAction>();
            schema.HasActions = actions.Any();
            if (schema.HasActions)
            {
                foreach (var action in actions)
                {
                    schema.RowActions.Add(new ActionModel
                    {
                        Title = action.Name,
                        ActionUrl = $"/admin/{entityKey}/{action.Url}",
                        Order = action.Order,
                        ActionHttpMethod = action.Method,
                        OpenOnSeparatePage = action.ExecuteSeparately,
                        ConfirmationMessage = action.ConfirmationMessage,
                    });
                }
            }

            return schema;
        }

        /// <inheritdoc/>
        public async Task<EmPageDetailsViewSchema> GetDetailsViewSchemaAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);

            if (!schemaDescription.DetailsViewItems.Any())
            {
                return null;
            }

            var schema = new EmPageDetailsViewSchema(new EmPageViewSchemaContext());
            return schema;
        }

        /// <inheritdoc/>
        public async Task<EmPageFormViewSchema> GetFormViewSchemaAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);

            if (!schemaDescription.DetailsViewItems.Any())
            {
                return null;
            }

            var schema = new EmPageFormViewSchema(new EmPageViewSchemaContext());
            return schema;
        }
    }
}