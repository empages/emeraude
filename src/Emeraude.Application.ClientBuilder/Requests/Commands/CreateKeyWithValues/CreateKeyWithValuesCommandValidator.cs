using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.CreateKeyWithValues;

/// <summary>
/// Command validator for <see cref="CreateKeyWithValuesCommand"/>.
/// </summary>
public class CreateKeyWithValuesCommandValidator : AbstractValidator<CreateKeyWithValuesCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateKeyWithValuesCommandValidator"/> class.
    /// </summary>
    /// <param name="context"></param>
    public CreateKeyWithValuesCommandValidator(ILocalizationContext context)
    {
    }
}