using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword
{
    /// <summary>
    /// Validator for client forgot password command.
    /// </summary>
    public class ForgotPasswordCommandValidator : AbstractValidator<ForgotPasswordCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordCommandValidator"/> class.
        /// </summary>
        public ForgotPasswordCommandValidator()
        {
            this.RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage(Messages.EmailIsARequiredField)
                .EmailAddress()
                .WithMessage(Messages.EnteredEmailIsInTheWrongFormat);
        }
    }
}