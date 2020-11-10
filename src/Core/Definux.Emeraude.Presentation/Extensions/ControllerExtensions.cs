using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Controller"/>.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Action result based on upload result.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static IActionResult UploadFileResponse(this Controller controller, UploadResult result)
        {
            if (result.Success)
            {
                return controller.Ok(result);
            }
            else if (result.ValidationError)
            {
                return controller.StatusCode(StatusCodes.Status415UnsupportedMediaType, result.Message);
            }

            return controller.BadRequest();
        }

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
