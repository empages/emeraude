using Definux.Emeraude.Application.Extensions;
using Definux.Emeraude.Application.Identity;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail
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