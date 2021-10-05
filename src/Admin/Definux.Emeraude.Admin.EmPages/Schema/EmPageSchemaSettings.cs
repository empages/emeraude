using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Schema.DetailsView;
using Definux.Emeraude.Admin.EmPages.Schema.FormView;
using Definux.Emeraude.Admin.EmPages.Schema.TableView;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;

namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Settings implementation for entity EmPage schema.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageSchemaSettings<TEntity, TModel> : IEmPageSchemaSettings
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly TableViewConfigurationBuilder<TEntity, TModel> tableViewConfigurationBuilder;
        private readonly DetailsViewConfigurationBuilder<TEntity, TModel> detailsViewConfigurationBuilder;
        private readonly FormViewConfigurationBuilder<TEntity, TModel> formViewConfigurationBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaSettings{TEntity, TModel}"/> class.
        /// </summary>
        public EmPageSchemaSettings()
        {
            this.tableViewConfigurationBuilder = new TableViewConfigurationBuilder<TEntity, TModel>();
            this.detailsViewConfigurationBuilder = new DetailsViewConfigurationBuilder<TEntity, TModel>();
            this.formViewConfigurationBuilder = new FormViewConfigurationBuilder<TEntity, TModel>();

            this.ModelActions = new List<EmPageAction>();
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
        /// Defines model actions that can be executed.
        /// </summary>
        /// <returns></returns>
        public IList<EmPageAction> ModelActions { get; }

        /// <summary>
        /// Set defaults of the current schema.
        /// </summary>
        public void UseDefaults()
        {
            this.ModelActions.Add(new EmPageAction()
            {
                Name = "Details",
                RelativeUrlFormat = "/{0}",
            });

            this.ModelActions.Add(new EmPageAction()
            {
                Order = 1,
                Name = "Edit",
                RelativeUrlFormat = "/{0}/edit",
            });

            this.ModelActions.Add(new EmPageAction()
            {
                Order = 2,
                Name = "Delete",
                RelativeUrlFormat = "/{0}",
                Method = HttpMethod.Delete,
                ConfirmationMessage = "Are you sure you want to delete this entity?",
            });

            this.tableViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
            {
                Title = this.Title,
            });

            this.detailsViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
            {
                Title = this.Title,
                IsActive = true,
                Href = $"/admin/{this.Key}",
            });

            this.detailsViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
            {
                Title = "Details",
                Order = 1,
                IsActive = false,
            });
        }

        /// <summary>
        /// Table view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TEntity, TModel> ConfigureTableView(
            Action<TableViewConfigurationBuilder<TEntity, TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.tableViewConfigurationBuilder);
            return this;
        }

        /// <summary>
        /// Details view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TEntity, TModel> ConfigureDetailsView(
            Action<DetailsViewConfigurationBuilder<TEntity, TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.detailsViewConfigurationBuilder);
            return this;
        }

        /// <summary>
        /// Form view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TEntity, TModel> ConfigureFormView(
            Action<FormViewConfigurationBuilder<TEntity, TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.formViewConfigurationBuilder);
            return this;
        }

        /// <inheritdoc/>
        public EmPageSchemaDescription BuildDescription(IEnumerable<Assembly> targetAssemblies)
        {
            var dataManagerType = AssemblyHelpers
                .GetClassesThatImplements<IEmPageDataManager>(targetAssemblies)
                .FirstOrDefault(x =>
                    !x.IsAbstract &&
                    x.BaseType != null &&
                    x.BaseType?.GetGenericArguments().ElementAt(0) == typeof(TEntity) &&
                    x.BaseType?.GetGenericArguments().ElementAt(1) == typeof(TModel));

            var description = new EmPageSchemaDescription()
            {
                Key = this.Key,
                Title = this.Title,
                ModelType = typeof(TModel),
                EntityType = typeof(TEntity),
                DataManagerType = dataManagerType,
                ModelActions = this.ModelActions,
                TableView = new TableViewDescription
                {
                    ViewItems = this.tableViewConfigurationBuilder.ViewItems,
                    PageActions = this.tableViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.tableViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                },
                DetailsView = new DetailsViewDescription
                {
                    ViewItems = this.detailsViewConfigurationBuilder.ViewItems,
                    PageActions = this.detailsViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.detailsViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                },
                FormView = new FormViewDescription
                {
                    ViewItems = this.formViewConfigurationBuilder.ViewItems,
                    PageActions = this.formViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.formViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                },
            };

            return description;
        }
    }
}