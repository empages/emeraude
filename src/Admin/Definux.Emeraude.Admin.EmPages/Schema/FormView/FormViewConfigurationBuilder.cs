using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.Data.Requests;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Utilities.Extensions;
using FluentValidation;

namespace Definux.Emeraude.Admin.EmPages.Schema.FormView
{
    /// <summary>
    /// Form implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{ViewItem, Entity, Model}"/>.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class FormViewConfigurationBuilder<TEntity, TModel> : IEmPageSchemaViewConfigurationBuilder<FormViewItem, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly List<FormViewItem> viewItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormViewConfigurationBuilder{TEntity, TModel}"/> class.
        /// </summary>
        public FormViewConfigurationBuilder()
        {
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
            this.viewItems = new List<FormViewItem>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<FormViewItem> ViewItems => this.viewItems;

        /// <inheritdoc/>
        public IList<EmPageAction> PageActions { get; }

        /// <inheritdoc/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <summary>
        /// Model validator action.
        /// </summary>
        public Action<EmPageMutationalRequestType, EmPageModelValidator<TModel>> ModelValidatorAction { get; private set; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<FormViewItem, TEntity, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<FormViewItem> viewItemAction)
        {
            var memberInfo = ReflectionHelpers.GetCorrectPropertyMember(property);
            FormViewItem viewItem = new FormViewItem();
            viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
            viewItemAction.Invoke(viewItem);

            var compatibleTypes = new[] { viewItem.Type, FormViewItemType.CreateEdit };
            if (this.ViewItems.Any(x => x.SourceName == viewItem.SourceName && compatibleTypes.Contains(x.Type)))
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

        /// <summary>
        /// Configures model validation rules
        /// </summary>
        /// <param name="validatorAction"></param>
        public void ConfigureModelValidatorValidator(Action<EmPageMutationalRequestType, EmPageModelValidator<TModel>> validatorAction)
        {
            this.ModelValidatorAction = validatorAction;
        }
    }
}