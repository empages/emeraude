using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.Adapters
{
    /// <summary>
    /// Admin implementation of <see cref="IEntitiesViewsSchemaProvider"/>
    /// </summary>
    public class EntitiesViewsSchemaProvider : IEntitiesViewsSchemaProvider
    {
        private readonly IEmLogger logger;
        private readonly EmMainOptions mainOptions;
        private readonly EmAdminOptions adminOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesViewsSchemaProvider"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        public EntitiesViewsSchemaProvider(
            IEmOptionsProvider optionsProvider,
            IEmLogger logger)
        {
            this.logger = logger;
            this.mainOptions = optionsProvider.GetMainOptions();
            this.adminOptions = optionsProvider.GetAdminOptions();
        }

        /// <inheritdoc/>
        public EntityTableViewSchema GetTableViewSchema(string entityKey)
        {
            var modelsDescriptions = this.GetAllEntitiesAdminModelsDescriptions();
            if (!this.ValidateEntityKeyValid(entityKey, modelsDescriptions, out var modelDescription))
            {
                return null;
            }

            if (!modelDescription.TableViewItems.Any())
            {
                return null;
            }

            var schema = new EntityTableViewSchema(new EntityViewSchemaContext
            {
                Key = modelDescription.SchemaSettings.Key,
                Title = modelDescription.SchemaSettings.Title,
            });
            foreach (var tableViewItem in modelDescription.TableViewItems)
            {
                schema.HeadModel.Cells.Add(new EntityTableHeadCellModel
                {
                    Name = tableViewItem.Name,
                    Order = tableViewItem.Order,
                });

                schema.PropertyComponentPair[tableViewItem.Key] = tableViewItem.Component;
                schema.PropertyTypePair[tableViewItem.Key] = tableViewItem.Type;
            }

            if (Activator.CreateInstance(modelDescription.Type) is IEntityAdminSchemaModel targetModelInstance)
            {
                var actions = modelDescription.SchemaSettings.ModelActions() ?? new List<EntityModelAction>();
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
            }

            return schema;
        }

        /// <inheritdoc/>
        public EntityDetailsViewSchema GetDetailsViewSchema(string entityKey)
        {
            var modelsDescriptions = this.GetAllEntitiesAdminModelsDescriptions();
            if (!this.ValidateEntityKeyValid(entityKey, modelsDescriptions, out var modelDescription))
            {
                return null;
            }

            if (!modelDescription.DetailsViewItems.Any())
            {
                return null;
            }

            var schema = new EntityDetailsViewSchema(new EntityViewSchemaContext());
            return schema;
        }

        /// <inheritdoc/>
        public EntityFormViewSchema GetFormViewSchema(string entityKey)
        {
            var modelsDescriptions = this.GetAllEntitiesAdminModelsDescriptions();
            if (!this.ValidateEntityKeyValid(entityKey, modelsDescriptions, out var modelDescription))
            {
                return null;
            }

            if (!modelDescription.DetailsViewItems.Any())
            {
                return null;
            }

            var schema = new EntityFormViewSchema(new EntityViewSchemaContext());
            return schema;
        }

        private bool ValidateEntityKeyValid(
            string entityKey,
            IEnumerable<EntityAdminModelTypeDescription> modelsDescriptions,
            out EntityAdminModelTypeDescription modelDescription)
        {
            modelDescription = modelsDescriptions
                .FirstOrDefault(x => x.SchemaSettings.Key.Equals(entityKey, StringComparison.OrdinalIgnoreCase));

            return modelDescription != null;
        }

        private IEnumerable<EntityAdminModelTypeDescription> GetAllEntitiesAdminModelsDescriptions()
        {
            var resultTypes = AssemblyHelpers.GetClassesThatImplements<IEntityAdminSchemaModel>(this.mainOptions.Assemblies);

            var resultDescriptions = new List<EntityAdminModelTypeDescription>();
            foreach (var type in resultTypes)
            {
                var currentDescription = this.BuildModelDescription(type, resultDescriptions.Select(x => x.SchemaSettings.Key));
                if (currentDescription != null)
                {
                    resultDescriptions.Add(currentDescription);
                }
            }

            return resultDescriptions;
        }

        private EntityAdminModelTypeDescription BuildModelDescription(Type type, IEnumerable<string> existingKeys)
        {
            var description = new EntityAdminModelTypeDescription(type);

            description.TableViewItems = type
                .GetProperties()
                .Where(x => x.HasAttribute<TableColumnAttribute>())
                .Select(x => new TableViewItemArgs(x))
                .Select(x => new TableViewItem(x));

            description.DetailsViewItems = type
                .GetProperties()
                .Where(x => x.HasAttribute<DetailsFieldAttribute>())
                .Select(x => new DetailsViewItemArgs(x))
                .Select(x => new DetailsViewItem(x));

            description.FormViewItems = type
                .GetProperties()
                .Where(x => x.HasAttribute<FormInputAttribute>())
                .Select(x => new FormViewItemArgs(x))
                .Select(x => new FormViewItem(x));

            return description;
        }
    }
}