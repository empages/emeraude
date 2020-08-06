using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication
{
    public class LoginWithTwoFactorAuthenticationCommandValidator : AbstractValidator<LoginWithTwoFactorAuthenticationCommand>
    {
        public LoginWithTwoFactorAuthenticationCommandValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Code is a required field.");
        }
    }
}
