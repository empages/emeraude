using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Table implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{TViewItem, Model}"/>
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class TableViewConfigurationBuilder<TModel> : IEmPageSchemaViewConfigurationBuilder<TableViewItem, TModel>
        where TModel : class, IEmPageModel, new()
    {
        private readonly List<TableViewItem> viewItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewConfigurationBuilder{TModel}"/> class.
        /// </summary>
        public TableViewConfigurationBuilder()
        {
            this.viewItems = new List<TableViewItem>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<TableViewItem> ViewItems => this.viewItems;

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<TableViewItem, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<TableViewItem> viewItemAction)
        {
            var memberInfo = this.GetCorrectPropertyMember(property);
            TableViewItem viewItem = new TableViewItem();
            viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
            viewItemAction.Invoke(viewItem);

            if (this.ViewItems.Any(x => x.SourceName == viewItem.SourceName))
            {
                throw new ArgumentException($"Property {viewItem.SourceName} cannot be registered more than once.");
            }

            if (string.IsNullOrWhiteSpace(viewItem.Title))
            {
                viewItem.Title = viewItem.SourceName.SplitWordsByCapitalLetters();
            }

            if (viewItem.Order == -1)
            {
                viewItem.Order = this.viewItems.IndexOf(viewItem);
            }

            this.viewItems.Add(viewItem);

            return this;
        }

        private MemberInfo GetCorrectPropertyMember<T>(Expression<Func<T, object>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member;
            }

            var operand = ((UnaryExpression)expression.Body).Operand;
            return ((MemberExpression)operand).Member;
        }
    }
}