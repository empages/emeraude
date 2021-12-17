using Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditLanguage;

/// <summary>
/// Command validator for <see cref="EditLanguageCommand"/>.
/// </summary>
public class EditLanguageCommandValidator : AbstractValidator<EditLanguageCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditLanguageCommandValidator"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EditLanguageCommandValidator(ILocalizationContext context)
    {
        this.RuleFor(x => x.Code)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Language code is a required")
            .Must(x => x.Length == 2)
            .WithMessage("Language code must be 2-symbols long");

        this.RuleFor(x => x)
            .MustAsync(async (x, c) =>
            {
                var languageCode = x.Code?.Trim().ToLowerInvariant();
                return !await context
                    .Languages
                    .AnyAsync(y => y.Id != x.Id && y.Code == languageCode, c);
            })
            .WithMessage("Language with that code already exists");

        this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Language name is required");

        this.RuleFor(x => x.NativeName)
            .NotEmpty()
            .WithMessage("Language native name is required");
    }
}