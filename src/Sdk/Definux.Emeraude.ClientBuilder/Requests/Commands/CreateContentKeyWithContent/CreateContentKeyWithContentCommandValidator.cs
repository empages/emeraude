using Definux.Emeraude.Localization;
using FluentValidation;

namespace Definux.Emeraude.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    /// <summary>
    /// Command validator for <see cref="CreateContentKeyWithContentCommand"/>.
    /// </summary>
    public class CreateContentKeyWithContentCommandValidator : AbstractValidator<CreateContentKeyWithContentCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContentKeyWithContentCommandValidator"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CreateContentKeyWithContentCommandValidator(LocalizationContext context)
        {
        }
    }
}