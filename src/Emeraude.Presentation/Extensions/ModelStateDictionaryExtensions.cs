using System.Collections.Generic;
using System.Linq;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Emeraude.Presentation.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ModelStateDictionary"/>.
    /// </summary>
    public static class ModelStateDictionaryExtensions
    {
        /// <summary>
        /// Apply validation exceptions to current model state.
        /// </summary>
        /// <param name="modelState"></param>
        /// <param name="exception"></param>
        /// <param name="skipTranslationKey"></param>
        public static void ApplyValidationException(this ModelStateDictionary modelState, ValidationException exception, bool skipTranslationKey = false)
        {
            if (exception != null && exception.Failures != null && exception.Failures.Count > 0)
            {
                foreach (var failure in exception.Failures)
                {
                    foreach (var failureValue in failure.Value)
                    {
                        if (!skipTranslationKey)
                        {
                            modelState.AddModelError(failure.Key, failureValue);
                        }
                        else
                        {
                            modelState.AddModelError(failure.Key, failureValue?.Replace("_", " ").ToLower().ToFirstUpper() + ".");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Get list of validation errors.
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static Dictionary<string, IEnumerable<string>> GetValidationErrors(this ModelStateDictionary modelState)
        {
            return modelState.ToDictionary(k => k.Key, v => v.Value.Errors.Select(x => x.ErrorMessage));
        }
    }
}
