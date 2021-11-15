using Emeraude.Application.Identity.Extensions;
using Emeraude.Infrastructure.Identity.Services;
using FluentValidation;

namespace Emeraude.Application.Identity.Requests.Commands.RequestChangeEmail
{
    /// <summary>
    /// Validator for <see cref="RequestChangeEmailCommand"/>.
    /// </summary>
    public class RequestChangeEmailCommandValidator : AbstractValidator<RequestChangeEmailCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestChangeEmailCommandValidator"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public RequestChangeEmailCommandValidator(IUserManager userManager)
        {
            this.RuleFor(x => x.NewEmail)
                .ValidateEmailAddress()
                .MustAsync(async (x, c) => await userManager.FindUserByEmailAsync(x) == null)
                .WithMessage(Strings.UserWithThatEmailAddressExists);
        }
    }
}