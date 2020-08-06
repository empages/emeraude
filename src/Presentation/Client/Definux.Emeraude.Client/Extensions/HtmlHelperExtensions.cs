using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Definux.Emeraude.Client.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static bool HasNonModelError(this IHtmlHelper htmlHelper)
        {
            return !string.IsNullOrEmpty(htmlHelper.NonModelError());
        }

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
