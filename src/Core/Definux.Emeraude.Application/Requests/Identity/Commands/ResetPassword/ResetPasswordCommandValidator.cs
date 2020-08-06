using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using FluentValidation;
using System.Linq;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        public ResetPasswordCommandValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat);

            RuleFor(x => x.Password)
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
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword);
        }
    }
}
