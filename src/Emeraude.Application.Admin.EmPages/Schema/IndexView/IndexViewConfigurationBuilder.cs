using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Application.Admin.EmPages.Schema.IndexView;

/// <summary>
/// Index implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{TViewItem,TModel}"/>.
/// </summary>
/// <typeparam name="TModel">EmPage model.</typeparam>
public class IndexViewConfigurationBuilder<TModel> : IEmPageSchemaViewConfigurationBuilder<IndexViewItem, TModel>
    where TModel : class, IEmPageModel, new()
{
    private readonly List<IndexViewItem> viewItems;

    /// <summary>
    /// Initializes a new instance of the <see cref="IndexViewConfigurationBuilder{TModel}"/> class.
    /// </summary>
    public IndexViewConfigurationBuilder()
    {
        this.viewItems = new List<IndexViewItem>();
        this.PageActions = new List<EmPageAction>
        {
            new ()
            {
                Name = "Create",
                RelativeUrlFormat = "/create",
            },
        };

        this.Breadcrumbs = new List<EmPageBreadcrumb>();
    }

    /// <inheritdoc/>
    public IReadOnlyList<IndexViewItem> ViewItems => this.viewItems;

    /// <inheritdoc/>
    public IList<EmPageAction> PageActions { get; }

    /// <inheritdoc/>
    public IList<EmPageBreadcrumb> Breadcrumbs { get; }

    /// <inheritdoc/>
    public IEmPageSchemaViewConfigurationBuilder<IndexViewItem, TModel> Use(
        Expression<Func<TModel, object>> property,
        Action<IndexViewItem> viewItemAction)
    {
        var memberInfo = ReflectionHelpers.GetCorrectPropertyMember(property);
        IndexViewItem viewItem = new IndexViewItem();
        viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
        viewItemAction.Invoke(viewItem);

        if (this.ViewItems.Any(x => x.SourceName == viewItem.SourceName))
        {
            throw new ArgumentException($"Property {viewItem.SourceName} cannot be registered more than once.");
        }

        if (string.IsNullOrWhiteSpace(viewItem.Title))
        {
            viewItem.Title = StringUtilities.SplitWordsByCapitalLetters(viewItem.SourceName);
        }

        if (viewItem.Order == -1)
        {
            viewItem.Order = this.ViewItems.Count;
        }

        this.viewItems.Add(viewItem);

        return this;
    }
}