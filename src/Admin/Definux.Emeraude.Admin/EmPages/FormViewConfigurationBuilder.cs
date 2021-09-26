using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Domain.Entities;
using FluentValidation;

namespace Definux.Emeraude.Admin.EmPages
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
        /// <summary>
        /// Initializes a new instance of the <see cref="FormViewConfigurationBuilder{TEntity, TModel}"/> class.
        /// </summary>
        public FormViewConfigurationBuilder()
        {
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<FormViewItem> ViewItems { get; }

        /// <inheritdoc/>
        public IList<EmPageAction> PageActions { get; }

        /// <inheritdoc/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <summary>
        /// Create command validator action.
        /// </summary>
        public Action<AbstractValidator<CreateCommand<TEntity, TModel>>> CreateCommandValidator { get; private set; }

        /// <summary>
        /// Edit command validator action.
        /// </summary>
        public Action<AbstractValidator<EditCommand<TEntity, TModel>>> EditCommandValidator { get; private set; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<FormViewItem, TEntity, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<FormViewItem> viewItemAction)
        {
            return this;
        }

        /// <summary>
        /// Configures create command validation rules
        /// </summary>
        /// <param name="validationAction"></param>
        /// <typeparam name="TEntity">Domain entity mapped to the EmPage model.</typeparam>
        public void ConfigureCreateCommandValidator(Action<AbstractValidator<CreateCommand<TEntity, TModel>>> validationAction)
        {
            this.CreateCommandValidator = validationAction;
        }

        /// <summary>
        /// Configures edit command validation rules
        /// </summary>
        /// <param name="validationAction"></param>
        /// <typeparam name="TEntity">Domain entity mapped to the EmPage model.</typeparam>
        public void ConfigureEditCommandValidator(Action<AbstractValidator<EditCommand<TEntity, TModel>>> validationAction)
        {
            this.EditCommandValidator = validationAction;
        }
    }
}