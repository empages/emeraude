using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Schema.DetailsView;
using Emeraude.Application.Admin.EmPages.Schema.FormView;
using Emeraude.Application.Admin.EmPages.Schema.IndexView;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Essentials.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace Emeraude.Application.Admin.EmPages.Schema;

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

    private readonly IDictionary<EmPageOperation, IList<IAuthorizationRequirement>> operationsAuthorizationRequirements;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageSchemaSettings{TModel}"/> class.
    /// </summary>
    public EmPageSchemaSettings()
    {
        this.indexViewConfigurationBuilder = new IndexViewConfigurationBuilder<TModel>();
        this.detailsViewConfigurationBuilder = new DetailsViewConfigurationBuilder<TModel>();
        this.formViewConfigurationBuilder = new FormViewConfigurationBuilder<TModel>();

        this.ModelActions = new List<EmPageAction>();
        this.operationsAuthorizationRequirements = new Dictionary<EmPageOperation, IList<IAuthorizationRequirement>>();
    }

    /// <summary>
    /// Model route used for identification (normally in in plural format). Example: 'dogs'.
    /// </summary>
    public string Route { get; set; }

    /// <summary>
    /// Title of the page. Example: for a dog model expected title would be 'Dog'.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Description of the page and its purpose and application.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Priority index of the current EmPage. The purpose of that property is related to the rendering order
    /// on the client side. The default value is 0.
    /// </summary>
    public int PriorityIndex { get; set; }

    /// <summary>
    /// Flag that indicates whether the schema is used with separate context or it is a feature of other parent schema.
    /// </summary>
    public bool UseAsFeature { get; set; }

    /// <summary>
    /// Defines model actions that can be executed.
    /// </summary>
    /// <returns></returns>
    public IList<EmPageAction> ModelActions { get; }

    /// <inheritdoc cref="IndexViewConfigurationBuilder{TModel}"/>
    public IndexViewConfigurationBuilder<TModel> IndexViewConfigurationBuilder =>
        this.indexViewConfigurationBuilder;

    /// <inheritdoc cref="DetailsViewConfigurationBuilder{TModel}"/>
    public DetailsViewConfigurationBuilder<TModel> DetailsViewConfigurationBuilder =>
        this.detailsViewConfigurationBuilder;

    /// <inheritdoc cref="FormViewConfigurationBuilder{TModel}"/>
    public FormViewConfigurationBuilder<TModel> FormViewConfigurationBuilder =>
        this.formViewConfigurationBuilder;

    /// <summary>
    /// Add an authorization requirement to the specified operation.
    /// If you need more requirements - invoke the method few times.
    /// </summary>
    /// <param name="operation"></param>
    /// <param name="requirement"></param>
    public void AddAuthorizationRequirement(EmPageOperation operation, IAuthorizationRequirement requirement)
    {
        if (!this.operationsAuthorizationRequirements.ContainsKey(operation))
        {
            this.operationsAuthorizationRequirements[operation] = new List<IAuthorizationRequirement>();
        }

        this.operationsAuthorizationRequirements[operation].Add(requirement);
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
            Description = this.Description,
            PriorityIndex = this.PriorityIndex,
            UseAsFeature = this.UseAsFeature,
            ModelType = typeof(TModel),
            DataManagerType = dataManagerType,
            ModelActions = this.ModelActions,
            OperationsAuthorizationRequirements = this.operationsAuthorizationRequirements.ToDictionary(k => k.Key, v => v.Value.AsEnumerable()),
            IndexView = new IndexViewDescription
            {
                ViewItems = this.indexViewConfigurationBuilder.ViewItems,
                PageActions = this.indexViewConfigurationBuilder.PageActions.OrderBy(x => x.Order).ToList(),
                Breadcrumbs = this.indexViewConfigurationBuilder.Breadcrumbs.OrderBy(x => x.Order).ToList(),
                CustomViewComponent = this.indexViewConfigurationBuilder.CustomViewComponent,
                OrderProperties = this.indexViewConfigurationBuilder.OrderProperties,
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
}