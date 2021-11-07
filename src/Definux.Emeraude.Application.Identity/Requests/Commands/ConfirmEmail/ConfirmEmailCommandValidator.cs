using Definux.Emeraude.Application.Identity.Extensions;
using FluentValidation;

namespace Definux.Emeraude.Application.Identity.Requests.Commands.ConfirmEmail
{
    /// <summary>
    /// Validator for confirm email command.
    /// </summary>
    public class ConfirmEmailCommandValidator : AbstractValidator<ConfirmEmailCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmEmailCommandValidator"/> class.
        /// </summary>
        public ConfirmEmailCommandValidator()
        {
            this.RuleFor(x => x.Email)
                .ValidateEmailAddress();
        }
    }
}
