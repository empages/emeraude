using System.Linq;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    /// <summary>
    /// Validator of change password command.
    /// </summary>
    public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordCommandValidator"/> class.
        /// </summary>
        public ChangePasswordCommandValidator()
        {
            this.RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage(Messages.CurrentPasswordIsARequiredField);

            this.RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField);

            this.RuleFor(x => x.NewPassword)
                .MinimumLength(EmIdentityConstants.PasswordRequiredLength)
                .WithMessage(string.Format(Messages.PasswordMustBeAtLeastSymbols, EmIdentityConstants.PasswordRequiredLength))
                .Must(x => x.Any(y => char.IsLetter(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Letter)
                .Must(x => x.Any(y => char.IsDigit(y)))
                .WithMessage(Messages.PasswordHaveToContainsAtLeast1Digit)
                .When(x => !string.IsNullOrEmpty(x.NewPassword));

            this.RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.NewPassword)
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.NewPassword));
        }
    }
}
