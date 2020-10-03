using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    /// <summary>
    /// Validator for client registration command.
    /// </summary>
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterCommandValidator"/> class.
        /// </summary>
        /// <param name="userManager">User Manager provided from Emeraude Identity.</param>
        public RegisterCommandValidator(IUserManager userManager)
        {
            this.RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat)
                .DependentRules(() =>
                {
                    this.RuleFor(x => x)
                        .Cascade(CascadeMode.Stop)
                        .MustAsync(async (x, c) => await userManager.FindUserByEmailAsync(x.Email) == null)
                        .WithMessage(Messages.UserCannotBeRegistered);
                });

            this.RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(Messages.NameIsARequiedField);

            this.RuleFor(x => x.Password)
                .Cascade(CascadeMode.Stop)
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
                .WithMessage(Messages.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.Password));
        }
    }
}
