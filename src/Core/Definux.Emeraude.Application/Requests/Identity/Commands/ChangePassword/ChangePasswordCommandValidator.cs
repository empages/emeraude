using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using FluentValidation;
using System.Linq;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        public ChangePasswordCommandValidator()
        {
            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage(Messages.CurrentPasswordIsARequiredField);

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField);

            RuleFor(x => x.NewPassword)
                .MinimumLength(EmIdentityConstants.PasswordRequiredLength)
                .WithMessage(string.Format(Messages.PasswordMustBeAtLeastSymbols, EmIdentityConstants.PasswordRequiredLength))
                .Must(x => x.Any(y => char.IsLetter(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Letter)
                .Must(x => x.Any(y => char.IsDigit(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Digit)
                .When(x => !string.IsNullOrEmpty(x.NewPassword));

            RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.NewPassword)
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.NewPassword));
        }
    }
}
