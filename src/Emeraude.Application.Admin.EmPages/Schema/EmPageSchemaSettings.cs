﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Schema.DetailsView;
using Emeraude.Application.Admin.EmPages.Schema.FormView;
using Emeraude.Application.Admin.EmPages.Schema.IndexView;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Application.Admin.EmPages.Schema
{
    /// <summary>
    /// Settings implementation for entity EmPage schema.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageSchemaSettings<TModel> : IEmPageSchemaSettings
        where TModel : class, IEmPageModel, new()
    {
        private readonly IndexViewConfigurationBuilder<TModel> indexViewConfigurationBuilder;
        private readonly DetailsViewConfigurationBuilder<TModel> detailsViewConfigurationBuilder;
        private readonly FormViewConfigurationBuilder<TModel> formViewConfigurationBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaSettings{TModel}"/> class.
        /// </summary>
        public EmPageSchemaSettings()
        {
            this.indexViewConfigurationBuilder = new IndexViewConfigurationBuilder<TModel>();
            this.detailsViewConfigurationBuilder = new DetailsViewConfigurationBuilder<TModel>();
            this.formViewConfigurationBuilder = new FormViewConfigurationBuilder<TModel>();

            this.ModelActions = new List<EmPageAction>();
        }

        /// <summary>
        /// Model route used for identification (normally in in plural format). Example: 'dogs'.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Title of the model in plural format.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Flag that indicates whether the schema is used with separate context or it is a feature of other parent schema.
        /// </summary>
        public bool UseAsFeature { get; set; }

        /// <summary>
        /// Defines model actions that can be executed.
        /// </summary>
        /// <returns></returns>
        public IList<EmPageAction> ModelActions { get; }

        /// <summary>
        /// Set defaults breadcrumbs of the current schema. It must be executed as a last method of the schema because it is
        /// using the already defined setup.
        /// </summary>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ApplyDefaultBreadcrumbs(Action<EmPageBuilderDefaultBreadcrumbsOptions> optionsAction = null)
        {
            var defaultOptions = new EmPageBuilderDefaultBreadcrumbsOptions();
            optionsAction?.Invoke(defaultOptions);

            string tableBreadcrumb = defaultOptions.TableBreadcrumbTitle ?? this.Title;

            if (!this.UseAsFeature)
            {
                this.indexViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
                {
                    Title = tableBreadcrumb,
                });

                this.detailsViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
                {
                    Title = tableBreadcrumb,
                    IsActive = true,
                    Href = $"/admin/{this.Route}",
                });

                this.formViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
                {
                    Title = tableBreadcrumb,
                    IsActive = true,
                    Href = $"/admin/{this.Route}",
                });
            }

            this.detailsViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
            {
                Title = defaultOptions.DetailsBreadcrumbTitle,
                Order = 1,
                IsActive = false,
            });

            var formCurrentBreadcrumb = new EmPageBreadcrumb
            {
                Title = defaultOptions.CurrentBreadcrumbTitle,
                Order = 1,
                IsActive = true,
                Href = $"/admin/{this.Route}/{this.GetModelPlaceholder(x => x.Id)}",
                HideContextually = true,
            };

            this.formViewConfigurationBuilder.Breadcrumbs.Add(formCurrentBreadcrumb);

            this.formViewConfigurationBuilder.Breadcrumbs.Add(new EmPageBreadcrumb
            {
                Title = defaultOptions.FormBreadcrumbTitle,
                Order = 2,
                IsActive = false,
            });

            return this;
        }

        /// <summary>
        /// Set defaults actions of the current schema. It must be executed as a last method of the schema because it is
        /// using the already defined setup.
        /// </summary>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ApplyDefaultActions()
        {
            this.ModelActions.Add(new EmPageAction()
            {
                Order = 0,
                Name = "Details",
                RelativeUrlFormat = $"/{this.GetModelPlaceholder(x => x.Id)}",
            });

            this.ModelActions.Add(new EmPageAction()
            {
                Order = 10,
                Name = "Edit",
                RelativeUrlFormat = $"/{this.GetModelPlaceholder(x => x.Id)}/edit",
            });

            this.ModelActions.Add(new EmPageAction()
            {
                Order = 20,
                Name = "Delete",
                RelativeUrlFormat = $"/{this.GetModelPlaceholder(x => x.Id)}",
                Method = HttpMethod.Delete,
                ConfirmationMessage = "Are you sure you want to delete this entity?",
            });

            if (this.formViewConfigurationBuilder.ViewItems.Any(x => x.Type == FormViewItemType.CreateEdit || x.Type == FormViewItemType.EditOnly))
            {
                this.detailsViewConfigurationBuilder.PageActions.Add(new EmPageAction
                {
                    Order = 1,
                    Name = "Edit",
                    RelativeUrlFormat = $"/{this.GetModelPlaceholder(x => x.Id)}/edit",
                });
            }

            return this;
        }

        /// <summary>
        /// Table view configuration builder action.
        /// </summary>
        /// <param name="configurationBuilderAction"></param>
        /// <returns></returns>
        public EmPageSchemaSettings<TModel> ConfigureIndexView(
            Action<IndexViewConfigurationBuilder<TModel>> configurationBuilderAction)
        {
            configurationBuilderAction.Invoke(this.indexViewConfigurationBuilder);
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

        /// <inheritdoc/>
        public EmPageSchemaDescription BuildDescription(IEnumerable<Assembly> targetAssemblies)
        {
            var dataManagerType = AssemblyHelpers
                .GetClassesThatImplements<IEmPageDataManager>(targetAssemblies)
                .FirstOrDefault(x =>
                    !x.IsAbstract &&
                    x.BaseType != null &&
                    x.BaseType?.GetGenericArguments().ElementAt(0) == typeof(TModel));

            var description = new EmPageSchemaDescription()
            {
                Route = this.Route,
                Title = this.Title,
                UseAsFeature = this.UseAsFeature,
                ModelType = typeof(TModel),
                DataManagerType = dataManagerType,
                ModelActions = this.ModelActions,
                IndexView = new IndexViewDescription
                {
                    ViewItems = this.indexViewConfigurationBuilder.ViewItems,
                    PageActions = this.indexViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.indexViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                },
                DetailsView = new DetailsViewDescription
                {
                    ViewItems = this.detailsViewConfigurationBuilder.ViewItems,
                    PageActions = this.detailsViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.detailsViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                    Features = this.detailsViewConfigurationBuilder.Features.Select(x => x.ToDescription()).ToList(),
                },
                FormView = new FormViewDescription
                {
                    ViewItems = this.formViewConfigurationBuilder.ViewItems,
                    PageActions = this.formViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                    Breadcrumbs = this.formViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                },
            };

            description.FormView.SetModelValidatorAction(this.formViewConfigurationBuilder.ModelValidatorAction);

            foreach (var feature in description.DetailsView.Features)
            {
                feature.ParentViewDescription = description.DetailsView;
            }

            return description;
        }

        /// <summary>
        /// Gets model property placeholder.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public string GetModelPlaceholder(Expression<Func<TModel, object>> property)
        {
            return EmPagesPlaceholders.GetModelPlaceholder(this.Route, property);
        }
    }
}