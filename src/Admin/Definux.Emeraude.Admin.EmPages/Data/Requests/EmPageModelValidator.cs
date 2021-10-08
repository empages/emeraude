using Definux.Emeraude.Admin.EmPages.Schema;
using FluentValidation;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// EmPage model validator.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageModelValidator<TModel> : AbstractValidator<TModel>
        where TModel : class, IEmPageModel, new()
    {
    }
}