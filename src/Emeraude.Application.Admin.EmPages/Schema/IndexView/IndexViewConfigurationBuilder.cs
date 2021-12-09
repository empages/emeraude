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
        this.OrderProperties = new Dictionary<string, string>();
    }

    /// <inheritdoc/>
    public IReadOnlyList<IndexViewItem> ViewItems => this.viewItems;

    /// <inheritdoc/>
    public IList<EmPageAction> PageActions { get; }

    /// <inheritdoc/>
    public IList<EmPageBreadcrumb> Breadcrumbs { get; }

    /// <summary>
    /// Dictionary that contains possible order properties for the current view.
    /// Key represents the identifier of an expression that you can define in your data strategy.
    /// Value represents the text that will be visualized in the client side.
    /// </summary>
    public IDictionary<string, string> OrderProperties { get; }

    /// <summary>
    /// Instance of custom view component. In case the component is set to null the default table view will be used.
    /// Consider that custom view components requires additional component definition by using the runtime injection.
    /// </summary>
    public CustomIndexViewComponent CustomViewComponent { get; set; }

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