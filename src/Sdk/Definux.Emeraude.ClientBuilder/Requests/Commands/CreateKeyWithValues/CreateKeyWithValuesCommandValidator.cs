using Definux.Emeraude.Localization;
using FluentValidation;

namespace Definux.Emeraude.ClientBuilder.Requests.Commands.CreateKeyWithValues
{
    /// <summary>
    /// Command validator for <see cref="CreateKeyWithValuesCommand"/>.
    /// </summary>
    public class CreateKeyWithValuesCommandValidator : AbstractValidator<CreateKeyWithValuesCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyWithValuesCommandValidator"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CreateKeyWithValuesCommandValidator(LocalizationContext context)
        {
        }
    }
}