using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Essentials.Functions;

namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of page view context strategy.
/// </summary>
/// <typeparam name="TViewItem">View item type.</typeparam>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmPageViewContextStrategy<TViewItem, TModel> : IEmPageViewContextStrategy<TViewItem, TModel>
    where TViewItem : class, IEmPageViewItem, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly List<TViewItem> viewItems;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageViewContextStrategy{TViewItem, TModel}"/> class.
    /// </summary>
    protected EmPageViewContextStrategy()
    {
        this.viewItems = new List<TViewItem>();
    }

    /// <inheritdoc/>
    public IReadOnlyList<IEmPageViewItem> ViewItems => this.viewItems;

    /// <inheritdoc/>
    public Type ViewItemType => typeof(TViewItem);

    /// <inheritdoc/>
    public virtual IEmPageViewContextStrategy<TViewItem, TModel> Configure(
        Expression<Func<TModel, object>> property,
        Action<TViewItem> viewItemAction)
    {
        var memberInfo = ReflectionFunctions.GetCorrectPropertyMember(property);
        var viewItem = this.viewItems.FirstOrDefault(x => x.SourceName == memberInfo?.Name) ?? new TViewItem();

        viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
        viewItemAction.Invoke(viewItem);

        if (string.IsNullOrWhiteSpace(viewItem.Label))
        {
            viewItem.Label = StringFunctions.SplitStringByCapitalLetters(viewItem.SourceName);
        }

        if (viewItem.Order == -1)
        {
            viewItem.Order = this.ViewItems.Count;
        }

        if (this.viewItems.All(x => x.SourceName != viewItem.SourceName))
        {
            this.viewItems.Add(viewItem);
        }

        return this;
    }

    /// <inheritdoc/>
    public IEmPageViewContextStrategy<TViewItem, TModel> Exclude(Expression<Func<TModel, object>> property)
    {
        var memberInfo = ReflectionFunctions.GetCorrectPropertyMember(property) as PropertyInfo;
        this.viewItems.RemoveAll(x => x.SourceName == memberInfo?.Name);

        return this;
    }

    /// <summary>
    /// Configure all properties of the model with the defaults set during the startup setup.
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    internal IEmPageViewContextStrategy<TViewItem, TModel> ConfigureAll(IEmPagesOptions options)
    {
        var modelProperties = typeof(TModel).GetProperties();
        foreach (var propertyInfo in modelProperties)
        {
            var viewItem = this.viewItems.FirstOrDefault(x => x.SourceName == propertyInfo.Name) ?? new TViewItem();
            viewItem.LoadSourceInfo(propertyInfo);
            viewItem.SetDefaultComponent(options);

            if (string.IsNullOrWhiteSpace(viewItem.Label))
            {
                viewItem.Label = StringFunctions.SplitStringByCapitalLetters(viewItem.SourceName);
            }

            if (viewItem.Order == -1)
            {
                viewItem.Order = this.ViewItems.Count;
            }

            if (this.viewItems.All(x => x.SourceName != viewItem.SourceName))
            {
                this.viewItems.Add(viewItem);
            }
        }

        return this;
    }
}