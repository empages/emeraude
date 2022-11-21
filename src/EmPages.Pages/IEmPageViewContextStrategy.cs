using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EmPages.Pages;

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

    /// <summary>
    /// Gets page actions.
    /// </summary>
    /// <param name="models"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    IEnumerable<EmAction> GetPageActions(IEnumerable<IEmPageModel> models, EmPageRequest request);
}

/// <summary>
/// Contract for page view context strategy.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public interface IEmPageViewContextStrategy<TModel> : IEmPageViewContextStrategy
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Adds action builder for the view context.
    /// </summary>
    /// <param name="actionBuilder"></param>
    void AddAction(Func<IEnumerable<TModel>, EmPageRequest, EmAction> actionBuilder);
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