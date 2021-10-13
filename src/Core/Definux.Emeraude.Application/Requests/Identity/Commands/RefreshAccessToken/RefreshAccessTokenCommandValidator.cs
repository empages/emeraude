using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken
{
    /// <summary>
    /// Validator for refresh access token command.
    /// </summary>
    public class RefreshAccessTokenCommandValidator : AbstractValidator<RefreshAccessTokenCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshAccessTokenCommandValidator"/> class.
        /// </summary>
        public RefreshAccessTokenCommandValidator()
        {
            this.RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .WithMessage(Strings.RefreshTokenIsRequired);
        }
    }
}
