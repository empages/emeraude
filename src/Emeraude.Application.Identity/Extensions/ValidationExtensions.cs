using System.Linq;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Extensions
{
    /// <summary>
    /// Extensions for fluent validators.
    /// </summary>
    public static class ValidationExtensions
    {
        /// <summary>
        /// Applies email validation.
        /// </summary>
        /// <param name="builder"></param>
        /// <typeparam name="T">Target model.</typeparam>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, string> ValidateEmailAddress<T>(this IRuleBuilderInitial<T, string> builder) =>
            builder
                .NotEmpty()
                .WithMessage(Strings.EmailAddressIsRequired)
                .EmailAddress()
                .WithMessage(Strings.EmailAddressIsInAnInvalidFormat);

        /// <summary>
        /// Applies the application password validation rules.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        /// <typeparam name="T">Target model.</typeparam>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, string> ValidatePassword<T>(
            this IRuleBuilderInitial<T, string> builder,
            PasswordOptions options)
        {
            var builderOption = builder
                .NotEmpty()
                .WithMessage(Strings.PasswordIsRequired)
                .MinimumLength(options.RequiredLength)
                .WithMessage(string.Format(Strings.PasswordMustContainsAtLeastNCharacters, options.RequiredLength))
                .Must(x => x.Distinct().Count() >= options.RequiredUniqueChars)
                .WithMessage(string.Format(Strings.PasswordMustContainsAtLeastNUniqueCharacters, options.RequiredUniqueChars))
                .Must(x => x.Any(char.IsLetter))
                .WithMessage(Strings.PasswordMustContainsAtLeastOneLetter);

            if (options.RequireDigit)
            {
                builderOption
                    .Must(x => x.Any(char.IsDigit))
                    .WithMessage(Strings.PasswordMustContainsAtLeastOneDigit);
            }

            if (options.RequireUppercase)
            {
                builderOption
                    .Must(x => x.Any(char.IsUpper))
                    .WithMessage(Strings.PasswordMustContainsAtLeastOneUpperCaseLetter);
            }

            if (options.RequireLowercase)
            {
                builderOption
                    .Must(x => x.Any(char.IsLower))
                    .WithMessage(Strings.PasswordMustContainsAtLeastOneLowerCaseLetter);
            }

            if (options.RequireNonAlphanumeric)
            {
                builderOption
                    .Must(x => !x.Any(char.IsLetterOrDigit))
                    .WithMessage(Strings.PasswordMustContainsAtLeastOneNonAlphanumericSymbol);
            }

            return builderOption;
        }
    }
}