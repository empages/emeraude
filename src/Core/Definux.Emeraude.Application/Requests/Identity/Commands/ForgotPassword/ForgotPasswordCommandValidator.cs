using Definux.Emeraude.Application.Extensions;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword
{
    /// <summary>
    /// Validator for client forgot password command.
    /// </summary>
    public class ForgotPasswordCommandValidator : AbstractValidator<ForgotPasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordCommandValidator"/> class.
        /// </summary>
        public ForgotPasswordCommandValidator()
        {
            this.RuleFor(x => x.Email)
                .ValidateEmailAddress();
        }
    }
}