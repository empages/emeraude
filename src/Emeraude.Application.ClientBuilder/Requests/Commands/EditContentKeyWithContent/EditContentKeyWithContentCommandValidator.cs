using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditContentKeyWithContent;

/// <summary>
/// Command validator for <see cref="EditContentKeyWithContentCommandValidator"/>.
/// </summary>
public class EditContentKeyWithContentCommandValidator : AbstractValidator<EditContentKeyWithContentCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditContentKeyWithContentCommandValidator"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EditContentKeyWithContentCommandValidator(ILocalizationContext context)
    {
        this.RuleFor(x => x.Key)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Content key is a required field");

        this.RuleFor(x => x)
            .MustAsync(async (x, c) =>
            {
                var key = x.Key?.Trim().ToUpperInvariant();
                return !await context
                    .ContentKeys
                    .AnyAsync(y => y.Id != x.KeyId && y.Key == key, c);
            })
            .WithMessage("Content key already exists");
    }
}