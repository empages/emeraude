using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    /// <summary>
    /// Validator for login command.
    /// </summary>
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCommandValidator"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public LoginCommandValidator(IUserManager userManager)
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
                        .MustAsync(async (x, c) => await userManager.CheckPasswordAsync(x.Email, x.Password))
                        .WithMessage(Messages.YourEmailOrPasswordIsIncorrect)
                        .MustAsync(async (x, c) => await userManager.IsEmailConfirmedAsync(x.Email))
                        .WithMessage(Messages.YourProfileEmailIsNotConfirmed)
                        .When(x => !string.IsNullOrEmpty(x.Password));
                });

            this.RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField);
        }
    }
}