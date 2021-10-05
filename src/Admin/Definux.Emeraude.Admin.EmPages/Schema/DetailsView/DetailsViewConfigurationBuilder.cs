using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// Details implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{ViewItem, Entity, Model}"/>.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class DetailsViewConfigurationBuilder<TEntity, TModel> : IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly List<DetailsViewItem> viewItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewConfigurationBuilder{TEntity, TModel}"/> class.
        /// </summary>
        public DetailsViewConfigurationBuilder()
        {
            this.viewItems = new List<DetailsViewItem>();
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<DetailsViewItem> ViewItems => this.viewItems;

        /// <inheritdoc/>
        public IList<EmPageAction> PageActions { get; }

        /// <inheritdoc/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TEntity, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<DetailsViewItem> viewItemAction)
        {
            var memberInfo = ReflectionHelpers.GetCorrectPropertyMember(property);
            DetailsViewItem viewItem = new DetailsViewItem();
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
                viewItem.Order = this.ViewItems.Count;
            }

            this.viewItems.Add(viewItem);

            return this;
        }
    }
}