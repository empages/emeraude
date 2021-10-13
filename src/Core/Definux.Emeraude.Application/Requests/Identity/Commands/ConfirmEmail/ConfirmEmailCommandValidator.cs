using Definux.Emeraude.Application.Extensions;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail
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
