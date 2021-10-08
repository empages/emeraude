using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.EmPages.Data.Requests;
using Definux.Emeraude.Domain.Entities;
using FluentValidation;

namespace Definux.Emeraude.Admin.EmPages.Schema.FormView
{
    /// <summary>
    /// Form view description.
    /// </summary>
    public class FormViewDescription : ViewDescription<FormViewItem>
    {
        private object modelValidatorAction;

        /// <summary>
        /// View items of the create form view.
        /// </summary>
        public IEnumerable<FormViewItem> CreateFormViewItems
            => this
                .ViewItems
                .Where(x => x.Type == FormViewItemType.CreateEdit || x.Type == FormViewItemType.CreateOnly)
                .OrderBy(x => x.Order);

        /// <summary>
        /// View items of the edit form view.
        /// </summary>
        public IEnumerable<FormViewItem> EditFormViewItems
            => this
                .ViewItems
                .Where(x => x.Type == FormViewItemType.CreateEdit || x.Type == FormViewItemType.EditOnly)
                .OrderBy(x => x.Order);

        /// <summary>
        /// Indicates whether the create form view is active or not.
        /// </summary>
        public bool IsCreateFormActive => this.CreateFormViewItems != null && this.CreateFormViewItems.Any();

        /// <summary>
        /// Indicates whether the edit form view is active or not.
        /// </summary>
        public bool IsEditFormActive => this.EditFormViewItems != null && this.EditFormViewItems.Any();

        /// <summary>
        /// Validates EmPage mutational request.
        /// </summary>
        /// <param name="type">Type of the mutational request.</param>
        /// <param name="validator">Target validator.</param>
        /// <typeparam name="TModel">EmPage model.</typeparam>
        public void ApplyModelValidationRules<TModel>(
            EmPageMutationalRequestType type,
            EmPageModelValidator<TModel> validator)
            where TModel : class, IEmPageModel, new()
        {
            if (validator == null)
            {
                return;
            }

            if (this.modelValidatorAction is Action<EmPageMutationalRequestType, EmPageModelValidator<TModel>> validatorAction)
            {
                validatorAction.Invoke(type, validator);
            }
        }

        /// <summary>
        /// Set EmPage mutational request in schema description.
        /// </summary>
        /// <param name="validatorAction"></param>
        /// <typeparam name="TModel">EmPage model.</typeparam>
        public void SetModelValidatorAction<TModel>(Action<EmPageMutationalRequestType, EmPageModelValidator<TModel>> validatorAction)
            where TModel : class, IEmPageModel, new()
        {
            this.modelValidatorAction = validatorAction;
        }
    }
}