using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditTranslationKeyWithValues;

/// <summary>
/// Command validator for <see cref="EditTranslationKeyWithValuesCommand"/>.
/// </summary>
public class EditTranslationKeyWithValuesCommandValidator : AbstractValidator<EditTranslationKeyWithValuesCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditTranslationKeyWithValuesCommandValidator"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EditTranslationKeyWithValuesCommandValidator(ILocalizationContext context)
    {
        this.RuleFor(x => x.Key)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Key is a required field");

        this.RuleFor(x => x)
            .MustAsync(async (x, c) =>
            {
                var key = x.Key?.Trim().ToUpperInvariant();
                return !await context
                    .Keys
                    .AnyAsync(y => y.Id != x.Id && y.Key == key, c);
            })
            .WithMessage("Key already exists");
    }
}