using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Utilities;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Settings implementation for entity EmPage schema.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageSchemaSettings<TModel> : IEmPageSchemaSettings
        where TModel : class, IEmPageModel, new()
    {
        private readonly TableViewConfigurationBuilder<TModel> tableViewConfigurationBuilder;
        private readonly DetailsViewConfigurationBuilder<TModel> detailsViewConfigurationBuilder;
        private readonly FormViewConfigurationBuilder<TModel> formViewConfigurationBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaSettings{TModel}"/> class.
        /// </summary>
        public EmPageSchemaSettings()
        {
            this.tableViewConfigurationBuilder = new TableViewConfigurationBuilder<TModel>();
            this.detailsViewConfigurationBuilder = new DetailsViewConfigurationBuilder<TModel>();
            this.formViewConfigurationBuilder = new FormViewConfigurationBuilder<TModel>();
        }

        /// <summary>
        /// Entity key used for identification of specified entity in plural format. Example: 'dogs'. This key will be used as a route as well.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Title of the entity in plural format.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Table view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ConfigureTableView(
            Action<TableViewConfigurationBuilder<TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.tableViewConfigurationBuilder);
            return this;
        }

        /// <summary>
        /// Details view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ConfigureDetailsView(
            Action<DetailsViewConfigurationBuilder<TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.detailsViewConfigurationBuilder);
            return this;
        }

        /// <summary>
        /// Form view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ConfigureFormView(
            Action<FormViewConfigurationBuilder<TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.formViewConfigurationBuilder);
            return this;
        }

        /// <summary>
        /// Defines model actions that can be executed.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EntityModelAction> ModelActions() =>
            new List<EntityModelAction>
            {
                new ()
                {
                    Order = 0,
                    Name = "Details",
                    Url = "{0}",
                },
                new ()
                {
                    Order = 0,
                    Name = "Modify",
                    Url = "{0}/modify",
                },
                new ()
                {
                    Order = 0,
                    Name = "Delete",
                    Url = "{0}",
                    Method = HttpMethod.Delete,
                    ConfirmationMessage = "Are you sure you want to delete this entity?",
                },
            };

        /// <inheritdoc/>
        public EmPageSchemaDescription BuildDescription(IEnumerable<Assembly> targetAssemblies)
        {
            var controllerType = AssemblyHelpers
                .GetClassesThatImplements<IEmPageDataController>(targetAssemblies)
                .FirstOrDefault(x => !x.IsAbstract && x.BaseType != null && x.BaseType?.GetGenericArguments().ElementAt(1) == typeof(TModel));

            var description = new EmPageSchemaDescription()
            {
                Key = this.Key,
                Title = this.Title,
                ModelType = typeof(TModel),
                DataControllerType = controllerType,
                ModelActions = this.ModelActions(),
                TableViewItems = this.tableViewConfigurationBuilder.ViewItems,
                DetailsViewItems = this.detailsViewConfigurationBuilder.ViewItems,
                FormViewItems = this.formViewConfigurationBuilder.ViewItems,
            };

            return description;
        }
    }
}