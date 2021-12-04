using Emeraude.Application.Identity.Extensions;
using Emeraude.Infrastructure.Identity.Services;
using FluentValidation;

namespace Emeraude.Application.Identity.Requests.Commands.Login;

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
            .ValidateEmailAddress()
            .DependentRules(() =>
            {
                this.RuleFor(x => x)
                    .Cascade(CascadeMode.Stop)
                    .MustAsync(async (x, c) => await userManager.IsEmailConfirmedAsync(x.Email))
                    .WithMessage(Strings.YourProfileEmailAddressIsNotConfirmed)
                    .When(x => !string.IsNullOrEmpty(x.Password))
                    .WhenAsync(async (x, c) => await userManager.CheckPasswordAsync(x.Email, x.Password));
            });

        this.RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage(Strings.PasswordIsRequired);
    }
}