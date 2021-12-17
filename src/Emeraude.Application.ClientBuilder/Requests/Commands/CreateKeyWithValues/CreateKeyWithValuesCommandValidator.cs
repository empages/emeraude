using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

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
        this.RuleFor(x => x.Key)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Key is a required field")
            .MustAsync(async (x, c) =>
            {
                var key = x?.Trim().ToUpperInvariant();
                return !await context
                    .Keys
                    .AnyAsync(y => y.Key == key, c);
            })
            .WithMessage("Key already exists");
    }
}