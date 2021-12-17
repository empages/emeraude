using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.Extensions;

/// <summary>
/// Extensions for <see cref="Controller"/>.
/// </summary>
public static class ControllerExtensions
{
    /// <summary>
    /// Bad request with model errors as response.
    /// </summary>
    /// <param name="controller"></param>
    /// <returns></returns>
    public static IActionResult BadRequestWithModelErrors(this Controller controller)
    {
        return controller.BadRequest(controller.ModelState.GetValidationErrors());
    }

    /// <summary>
    /// Gets route with applied language code on the beginning.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="route"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    public static string GetRouteWithAppliedLanguage(this Controller controller, string route, Language language)
    {
        if (language != null && !language.IsDefault)
        {
            if (route.StartsWith("/"))
            {
                route = route.Substring(1);
            }

            return $"/{language.Code}/{route}";
        }

        return route;
    }
}