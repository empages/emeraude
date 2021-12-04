using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.CreateContentKeyWithContent;

/// <summary>
/// Command validator for <see cref="CreateContentKeyWithContentCommand"/>.
/// </summary>
public class CreateContentKeyWithContentCommandValidator : AbstractValidator<CreateContentKeyWithContentCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateContentKeyWithContentCommandValidator"/> class.
    /// </summary>
    /// <param name="context"></param>
    public CreateContentKeyWithContentCommandValidator(ILocalizationContext context)
    {
    }
}