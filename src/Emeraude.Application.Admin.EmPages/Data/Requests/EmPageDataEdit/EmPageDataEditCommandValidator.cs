using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Contracts;
using FluentValidation;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <summary>
    /// Validator for <see cref="EmPageDataEditCommand{TEntity,TModel}"/>
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageDataEditCommandValidator<TEntity, TModel> : AbstractValidator<EmPageDataEditCommand<TEntity, TModel>>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataEditCommandValidator{TEntity, TModel}"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        public EmPageDataEditCommandValidator(IEmPageService emPageService)
        {
            var currentSchema = emPageService.FindSchemaDescriptionByContract(typeof(TModel));
            var modelValidator = new EmPageModelValidator<TModel>();
            currentSchema.FormView.ApplyModelValidationRules(EmPageMutationalRequestType.Edit, modelValidator);
            this.RuleFor(x => x.Model)
                .SetValidator(modelValidator);
        }
    }
}