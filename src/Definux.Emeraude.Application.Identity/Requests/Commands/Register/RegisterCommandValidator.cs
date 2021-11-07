using Definux.Emeraude.Application.Identity.Extensions;
using Definux.Emeraude.Infrastructure.Identity.Services;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Application.Identity.Requests.Commands.Register
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
        /// <param name="identityOptionsAccessor"></param>
        public RegisterCommandValidator(IUserManager userManager, IOptions<IdentityOptions> identityOptionsAccessor)
        {
            var identityOptions = identityOptionsAccessor.Value;

            this.RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .ValidateEmailAddress()
                .DependentRules(() =>
                {
                    this.RuleFor(x => x)
                        .Cascade(CascadeMode.Stop)
                        .MustAsync(async (x, c) => await userManager.FindUserByEmailAsync(x.Email) == null)
                        .WithMessage(Strings.UserCannotBeRegistered);
                });

            this.RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(Strings.NameIsRequired);

            this.RuleFor(x => x.Password)
                .Cascade(CascadeMode.Stop)
                .ValidatePassword(identityOptions.Password);

            this.RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.Password)
                .WithMessage(Strings.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.Password));
        }
    }
}
