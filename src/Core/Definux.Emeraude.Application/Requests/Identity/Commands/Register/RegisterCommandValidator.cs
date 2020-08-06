using FluentValidation;
using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator(IUserManager userManager)
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
                        .MustAsync(async (x, c) => await userManager.FindUserByEmailAsync(x.Email) == null)
                        .WithMessage(Messages.UserCannotBeRegistered);
                });
                

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(Messages.NameIsARequiedField);

            RuleFor(x => x.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField)
                .MinimumLength(EmIdentityConstants.PasswordRequiredLength)
                .WithMessage(string.Format(Messages.PasswordMustBeAtLeastSymbols, EmIdentityConstants.PasswordRequiredLength))
                .Must(x => x.Any(y => char.IsLetter(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Letter)
                .Must(x => x.Any(y => char.IsDigit(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Digit);

            RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.Password)
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.Password));
        }
    }
}
