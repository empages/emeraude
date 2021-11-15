using Emeraude.Application.Identity.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Emeraude.Application.Identity.Requests.Commands.ResetPassword
{
    /// <summary>
    /// Validator of reset password command.
    /// </summary>
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordCommandValidator"/> class.
        /// </summary>
        /// <param name="identityOptionsAccessor"></param>
        public ResetPasswordCommandValidator(IOptions<IdentityOptions> identityOptionsAccessor)
        {
            var identityOptions = identityOptionsAccessor.Value;

            this.RuleFor(x => x.Email)
                .ValidateEmailAddress();

            this.RuleFor(x => x.Password)
                .ValidatePassword(identityOptions.Password);

            this.RuleFor(x => x.ConfirmedPassword)
                .Equal(x => x.Password)
                .WithMessage(Strings.ConfirmedPasswordDoesNotMatchThePassword);
        }
    }
}
