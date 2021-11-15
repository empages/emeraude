using FluentValidation;

namespace Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication
{
    /// <summary>
    /// Validator for login with two factor authentication command.
    /// </summary>
    public class LoginWithTwoFactorAuthenticationCommandValidator : AbstractValidator<LoginWithTwoFactorAuthenticationCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWithTwoFactorAuthenticationCommandValidator"/> class.
        /// </summary>
        public LoginWithTwoFactorAuthenticationCommandValidator()
        {
            this.RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Code is a required field.");
        }
    }
}
