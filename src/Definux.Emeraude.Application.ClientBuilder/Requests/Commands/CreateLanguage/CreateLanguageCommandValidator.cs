using Definux.Emeraude.Infrastructure.Localization.Persistence;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.ClientBuilder.Requests.Commands.CreateLanguage
{
    /// <summary>
    /// Command validator for <see cref="CreateLanguageCommand"/>.
    /// </summary>
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLanguageCommandValidator"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CreateLanguageCommandValidator(ILocalizationContext context)
        {
            this.RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Language code is required.")
                .MustAsync(async (x, c) =>
                {
                    var languageCode = x.Trim().ToLowerInvariant();
                    return !await context
                        .Languages
                        .AnyAsync(y => y.Code == languageCode, c);
                })
                .WithMessage("Language with that code already exists.");

            this.RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Language name is required.");

            this.RuleFor(x => x.NativeName)
                .NotEmpty()
                .WithMessage("Language native name is required.");
        }
    }
}