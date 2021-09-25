using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Details implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{TViewItem, Model}"/>.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class DetailsViewConfigurationBuilder<TModel> : IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TModel>
        where TModel : class, IEmPageModel, new()
    {
        /// <inheritdoc/>
        public IReadOnlyList<DetailsViewItem> ViewItems { get; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<DetailsViewItem> viewItemAction)
        {
            return this;
        }
    }
}