using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.Extensions
{
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
    }
}
