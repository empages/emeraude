using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Presentation.Extensions
{
    public static class ModelStateDictionaryExtensions
    {
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

        public static Dictionary<string, IEnumerable<string>> GetValidationErrors(this ModelStateDictionary modelState)
        {
            return modelState.ToDictionary(k => k.Key, v => v.Value.Errors.Select(x => x.ErrorMessage));
        }
    }
}
