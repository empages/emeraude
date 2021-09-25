using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Form implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{TViewItem, Model}"/>.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class FormViewConfigurationBuilder<TModel> : IEmPageSchemaViewConfigurationBuilder<FormViewItem, TModel>
        where TModel : class, IEmPageModel, new()
    {
        /// <inheritdoc/>
        public IReadOnlyList<FormViewItem> ViewItems { get; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<FormViewItem, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<FormViewItem> viewItemAction)
        {
            throw new NotImplementedException();
        }
    }
}