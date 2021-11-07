using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Admin.EmPages.Services;
using Definux.Emeraude.Application.Admin.EmPages.Shared;
using Definux.Emeraude.Contracts;
using FluentValidation;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <summary>
    /// Validator for <see cref="EmPageDataCreateCommand{TEntity,TModel}"/>
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageDataCreateCommandValidator<TEntity, TModel> : AbstractValidator<EmPageDataCreateCommand<TEntity, TModel>>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataCreateCommandValidator{TEntity, TModel}"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        public EmPageDataCreateCommandValidator(IEmPageService emPageService)
        {
            var currentSchema = emPageService.FindSchemaDescriptionByContract(typeof(TModel));
            var modelValidator = new EmPageModelValidator<TModel>();
            currentSchema.FormView.ApplyModelValidationRules(EmPageMutationalRequestType.Create, modelValidator);
            this.RuleFor(x => x.Model).SetValidator(modelValidator);
        }
    }
}