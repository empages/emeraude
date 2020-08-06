using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken
{
    public class RefreshAccessTokenCommandValidator : AbstractValidator<RefreshAccessTokenCommand>
    {
        public RefreshAccessTokenCommandValidator()
        {
            RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .WithMessage(Messages.RefreshTokenIsRequiredField);
        }
    }
}
