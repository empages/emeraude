using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator(IUserManager userManager)
        {
            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat)
                .DependentRules(() =>
                {
                    RuleFor(x => x)
                        .Cascade(CascadeMode.StopOnFirstFailure)
                        .MustAsync(async (x, c) => await userManager.CheckPasswordAsync(x.Email, x.Password))
                        .WithMessage(Messages.YourEmailOrPasswordIsIncorrect)
                        .MustAsync(async (x, c) => await userManager.IsEmailConfirmedAsync(x.Email))
                        .WithMessage(Messages.YourProfileEmailIsNotConfirmed)
                        .When(x => !string.IsNullOrEmpty(x.Password));
                });

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField);
        }
    }
}
