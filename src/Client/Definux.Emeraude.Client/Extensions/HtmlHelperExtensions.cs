using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IHtmlHelper"/>.
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Check for existance of model state errors related with no specific property.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static bool HasNonModelError(this IHtmlHelper htmlHelper)
        {
            return !string.IsNullOrEmpty(htmlHelper.NonModelError());
        }

        /// <summary>
        /// Gives the first model state error related with no specific property.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static string NonModelError(this IHtmlHelper htmlHelper)
        {
            string error = string.Empty;
            if (!htmlHelper.ViewContext.ModelState.IsValid)
            {
                foreach (var modelStateValue in htmlHelper.ViewContext.ModelState)
                {
                    if (modelStateValue.Key == string.Empty &&
                        modelStateValue.Value.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid &&
                        modelStateValue.Value.Errors.Count > 0)
                    {
                        error = modelStateValue.Value.Errors.FirstOrDefault()?.ErrorMessage ?? string.Empty;
                    }
                }
            }

            return error;
        }
    }
}
