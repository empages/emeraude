using System.Linq;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    /// <summary>
    /// Validator of reset password command.
    /// </summary>
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordCommandValidator"/> class.
        /// </summary>
        public ResetPasswordCommandValidator()
        {
            this.RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat);

            this.RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField)
                .MinimumLength(EmIdentityConstants.PasswordRequiredLength)
                .WithMessage(string.Format(Messages.PasswordMustBeAtLeastSymbols, EmIdentityConstants.PasswordRequiredLength))
                .Must(x => x.Any(y => char.IsLetter(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Letter)
                .Must(x => x.Any(y => char.IsDigit(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Digit);

            this.RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.Password)
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword);
        }
    }
}
