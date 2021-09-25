using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Definux.Emeraude.Admin.EmPages
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
        public IReadOnlyList<TViewItem> ViewItems { get; }

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