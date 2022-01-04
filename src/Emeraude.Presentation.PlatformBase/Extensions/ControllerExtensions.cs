using System.Threading.Tasks;
using Emeraude.Presentation.Controllers;
using Emeraude.Presentation.PlatformBase.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Extensions;

/// <summary>
/// Extensions for <see cref="ControllerBase"/>.
/// </summary>
public static class ControllerExtensions
{
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
        this EmPublicController controller,
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
        this EmPublicController controller,
        string title,
        string message,
        string reference)
    {
        return await controller.RedirectToExecutionResultAsync(true, title, null, message, null, reference);
    }
}