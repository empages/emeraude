using Emeraude.Application.Identity.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Emeraude.Application.Identity.Requests.Commands.ChangePassword
{
    /// <summary>
    /// Validator of change password command.
    /// </summary>
    public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordCommandValidator"/> class.
        /// </summary>
        /// <param name="identityOptionsAccessor"></param>
        public ChangePasswordCommandValidator(IOptions<IdentityOptions> identityOptionsAccessor)
        {
            var identityOptions = identityOptionsAccessor.Value;

            this.RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage(Strings.CurrentPasswordIsRequired);

            this.RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(Strings.PasswordIsRequired);

            this.RuleFor(x => x.NewPassword)
                .ValidatePassword(identityOptions.Password);

            this.RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.NewPassword)
                .WithMessage(Strings.ConfirmedPasswordDoesNotMatchThePassword)
                .When(x => !string.IsNullOrEmpty(x.NewPassword));
        }
    }
}
