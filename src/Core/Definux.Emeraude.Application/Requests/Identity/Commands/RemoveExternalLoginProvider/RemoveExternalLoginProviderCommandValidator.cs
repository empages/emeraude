using System;
using System.Linq;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Resources;
using FluentValidation;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider
{
    /// <summary>
    /// Validator of remove external login provider command.
    /// </summary>
    public class RemoveExternalLoginProviderCommandValidator : AbstractValidator<RemoveExternalLoginProviderCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveExternalLoginProviderCommandValidator"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public RemoveExternalLoginProviderCommandValidator(IUserManager userManager)
        {
            this.RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(Messages.PasswordIsARequiredField);

            this.RuleFor(x => x.Provider)
                .NotEmpty()
                .WithMessage(Messages.ExternalLoginProviderIsRequired);
        }
    }
}