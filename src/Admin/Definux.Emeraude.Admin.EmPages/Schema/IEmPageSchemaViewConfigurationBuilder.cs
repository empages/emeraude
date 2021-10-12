using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Contract for configuration builder of schema view implementation.
    /// </summary>
    /// <typeparam name="TViewItem">View item.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageSchemaViewConfigurationBuilder<out TViewItem, TModel>
        where TViewItem : class, IViewItem, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// List of all view items registered by the builder.
        /// </summary>
        IReadOnlyList<TViewItem> ViewItems { get; }

        /// <summary>
        /// List of all page actions for the current EmPage.
        /// </summary>
        IList<EmPageAction> PageActions { get; }

        /// <summary>
        /// List of all page breadcrumbs for the current EmPage.
        /// </summary>
        IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <summary>
        /// Register model property as a view item of the current schema configuration.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="viewItemAction"></param>
        /// <returns></returns>
        IEmPageSchemaViewConfigurationBuilder<TViewItem, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<TViewItem> viewItemAction);
    }
}