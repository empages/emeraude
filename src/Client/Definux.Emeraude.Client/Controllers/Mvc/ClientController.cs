using System.Threading.Tasks;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Simple extended controller of <see cref="PublicController"/>.
    /// </summary>
    public abstract class ClientController : PublicController
    {
        /// <summary>
        /// Redirects to execution result page.
        /// </summary>
        /// <param name="succeeded"></param>
        /// <param name="successTitle"></param>
        /// <param name="failedTitle"></param>
        /// <param name="successMessage"></param>
        /// <param name="failedMessage"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        protected async Task<IActionResult> RedirectToExecutionResultAsync(
            bool succeeded,
            string successTitle,
            string failedTitle,
            string successMessage,
            string failedMessage,
            string reference)
        {
            string title = succeeded ? successTitle : failedTitle;
            string message = succeeded ? successMessage : failedMessage;
            string redirectUrl = await this.GetLanguageRouteAsync($"/execution/handle?title={title}&message={message}&succeeded={succeeded}&reference={reference}");
            return this.LocalRedirect(redirectUrl);
        }

        /// <summary>
        /// Redirects to succeeded execution result page.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        protected async Task<IActionResult> RedirectToSucceededExecutionResultAsync(string title, string message, string reference)
        {
            return await this.RedirectToExecutionResultAsync(true, title, null, message, null, reference);
        }
    }
}