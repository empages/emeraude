using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication
{
    /// <summary>
    /// Validator for activate two factor authentication command.
    /// </summary>
    public class ActivateTwoFactorAuthenticationCommandValidator : AbstractValidator<ActivateTwoFactorAuthenticationCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateTwoFactorAuthenticationCommandValidator"/> class.
        /// </summary>
        public ActivateTwoFactorAuthenticationCommandValidator()
        {
            this.RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Code is a required field.")
                .Length(6)
                .WithMessage("Code length must be 6 symbols.");
        }
    }
}
