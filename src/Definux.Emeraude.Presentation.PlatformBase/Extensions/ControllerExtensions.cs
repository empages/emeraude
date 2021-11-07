using System.Threading.Tasks;
using Definux.Emeraude.Application.General.Models;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.PlatformBase.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PlatformBase.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ControllerBase"/>.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Action result based on upload result.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static IActionResult UploadFileResponse(this ControllerBase controller, UploadResult result)
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
        /// Redirects to execution result page.
        /// To use this extension method you need to have an instance of <see cref="ExecutionResultController"/>.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="succeeded"></param>
        /// <param name="successTitle"></param>
        /// <param name="failedTitle"></param>
        /// <param name="successMessage"></param>
        /// <param name="failedMessage"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static async Task<IActionResult> RedirectToExecutionResultAsync(
            this PublicController controller,
            bool succeeded,
            string successTitle,
            string failedTitle,
            string successMessage,
            string failedMessage,
            string reference)
        {
            string title = succeeded ? successTitle : failedTitle;
            string message = succeeded ? successMessage : failedMessage;
            string redirectUrl = await controller.GetLanguageRouteAsync($"/execution/handle?title={title}&message={message}&succeeded={succeeded}&reference={reference}");
            return controller.LocalRedirect(redirectUrl);
        }

        /// <summary>
        /// Redirects to succeeded execution result page.
        /// To use this extension method you need to have an instance of <see cref="ExecutionResultController"/>.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static async Task<IActionResult> RedirectToSucceededExecutionResultAsync(
            this PublicController controller,
            string title,
            string message,
            string reference)
        {
            return await controller.RedirectToExecutionResultAsync(true, title, null, message, null, reference);
        }
    }
}
