using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Emeraude.Pages;

/// <summary>
/// Contract for page view context strategy.
/// </summary>
public interface IEmPageViewContextStrategy
{
    /// <summary>
    /// List of all view items registered by the builder.
    /// </summary>
    IReadOnlyList<IEmPageViewItem> ViewItems { get; }

    /// <summary>
    /// Type of the view model related to that view context.
    /// </summary>
    Type ViewItemType { get; }
}

/// <summary>
/// Contract for page view context strategy.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public interface IEmPageViewContextStrategy<TModel> : IEmPageViewContextStrategy
    where TModel : class, IEmPageModel, new()
{
}

/// <inheritdoc />
public interface IEmPageViewContextStrategy<out TViewItem, TModel> : IEmPageViewContextStrategy<TModel>
    where TViewItem : class, IEmPageViewItem, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Register model property as a view item of the current schema setup.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="viewItemAction"></param>
    /// <returns></returns>
    IEmPageViewContextStrategy<TViewItem, TModel> Configure(
        Expression<Func<TModel, object>> property,
        Action<TViewItem> viewItemAction);

    /// <summary>
    /// Exclude a model property from the current schema setup.
    /// </summary>
    /// <param name="property"></param>
    /// <returns></returns>
    IEmPageViewContextStrategy<TViewItem, TModel> Exclude(Expression<Func<TModel, object>> property);
}