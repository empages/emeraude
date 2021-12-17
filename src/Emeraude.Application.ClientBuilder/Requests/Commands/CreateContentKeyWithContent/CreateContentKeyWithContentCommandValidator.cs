using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

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
        this.RuleFor(x => x.Key)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Content key is a required field")
            .MustAsync(async (x, c) =>
            {
                var key = x?.Trim().ToUpperInvariant();
                return !await context
                    .ContentKeys
                    .AnyAsync(y => y.Key == key, c);
            })
            .WithMessage("Content key already exists");
    }
}