using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication
{
    public class ActivateTwoFactorAuthenticationCommandValidator : AbstractValidator<ActivateTwoFactorAuthenticationCommand>
    {
        public ActivateTwoFactorAuthenticationCommandValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Code is a required field.")
                .Length(6)
                .WithMessage("Code length must be 6 symbols.");
        }
    }
}
