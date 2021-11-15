using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Utilities.Extensions;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// Details implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{ViewItem, Model}"/>.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class DetailsViewConfigurationBuilder<TModel> : IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TModel>
        where TModel : class, IEmPageModel, new()
    {
        private readonly List<DetailsViewItem> viewItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewConfigurationBuilder{TModel}"/> class.
        /// </summary>
        public DetailsViewConfigurationBuilder()
        {
            this.viewItems = new List<DetailsViewItem>();
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
            this.Features = new List<EmPageFeature<TModel>>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<DetailsViewItem> ViewItems => this.viewItems;

        /// <inheritdoc/>
        public IList<EmPageAction> PageActions { get; }

        /// <inheritdoc/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <summary>
        /// List of all features for specified details view.
        /// </summary>
        public IList<EmPageFeature<TModel>> Features { get; }

        /// <summary>
        /// Includes feature
        /// </summary>
        /// <param name="featureAction"></param>
        /// <returns></returns>
        public DetailsViewConfigurationBuilder<TModel> IncludeFeature(Action<EmPageFeature<TModel>> featureAction)
        {
            var feature = new EmPageFeature<TModel>();
            featureAction.Invoke(feature);
            this.Features.Add(feature);

            return this;
        }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<DetailsViewItem, TModel> Use(
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