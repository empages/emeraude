using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.Extensions
{
    public static class ControllerExtensions
    {
        public static IActionResult UploadFileResponse(this Controller controller, UploadResult result)
        {
            if (result.Success)
            {
                return controller.Ok();
            }
            else if (result.ValidationError)
            {
                return controller.StatusCode(StatusCodes.Status415UnsupportedMediaType, result.Message);
            }

            return controller.BadRequest();
        }

        public static IActionResult BadRequestWithModelErrors(this Controller controller)
        {
            return controller.BadRequest(controller.ModelState.GetValidationErrors());
        }
    }
}
