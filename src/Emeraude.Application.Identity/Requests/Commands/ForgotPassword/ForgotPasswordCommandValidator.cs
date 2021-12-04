using Emeraude.Application.Identity.Extensions;
using FluentValidation;

namespace Emeraude.Application.Identity.Requests.Commands.ForgotPassword;

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
            .ValidateEmailAddress();
    }
}