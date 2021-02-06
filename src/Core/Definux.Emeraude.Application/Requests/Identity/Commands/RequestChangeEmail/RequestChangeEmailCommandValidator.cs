using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Resources;
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
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat)
                .MustAsync(async (x, c) => await userManager.FindUserByEmailAsync(x) == null)
                .WithMessage(Messages.UserWithThatEmailExists);
        }
    }
}