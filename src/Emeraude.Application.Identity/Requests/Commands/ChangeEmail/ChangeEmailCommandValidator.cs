using Emeraude.Application.Identity.Extensions;
using FluentValidation;

namespace Emeraude.Application.Identity.Requests.Commands.ChangeEmail
{
    /// <summary>
    /// Validator for <see cref="ChangeEmailCommand"/>.
    /// </summary>
    public class ChangeEmailCommandValidator : AbstractValidator<ChangeEmailCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeEmailCommandValidator"/> class.
        /// </summary>
        public ChangeEmailCommandValidator()
        {
            this.RuleFor(x => x.NewEmail)
                .ValidateEmailAddress();
        }
    }
}