using System;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Localization.Attributes;
using Emeraude.Presentation.Controllers;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <summary>
    /// Execution result abstract controller.
    /// </summary>
    public abstract class ExecutionResultController : PublicController
    {
        private const string ResultRoute = "/execution/result";
        private const string HandleRoute = "/execution/handle";

        private const string TempDataExecutionResultTitle = "TempDataExecutionResultTitle";
        private const string TempDataExecutionResultMessage = "TempDataExecutionResultMessage";
        private const string TempDataExecutionResultSucceeded = "TempDataExecutionResultSucceeded";

        /// <summary>
        /// Handle the invocation for execution result page then redirect to page.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="succeeded"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        [Route(HandleRoute)]
        [LanguageRoute(HandleRoute)]
        public async Task<IActionResult> Handle(
            [FromQuery]string title,
            [FromQuery]string message,
            [FromQuery]bool succeeded,
            [FromQuery]string reference)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(message))
            {
                return this.NotFound();
            }

            this.TempData[TempDataExecutionResultTitle] = title;
            this.TempData[TempDataExecutionResultMessage] = message;
            this.TempData[TempDataExecutionResultSucceeded] = succeeded;

            return await this.LanguageLocalRedirectAsync($"{ResultRoute}?reference={reference}");
        }

        /// <summary>
        /// Main action for the execution result page.
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        [Route(ResultRoute)]
        [LanguageRoute(ResultRoute)]
        public virtual IActionResult Index([FromQuery(Name = "reference")]string reference)
        {
            try
            {
                var model = new ExecutionResultViewModel()
                {
                    Title = this.TempData[TempDataExecutionResultTitle].ToString(),
                    Message = this.TempData[TempDataExecutionResultMessage].ToString(),
                    Succeeded = Convert.ToBoolean(this.TempData[TempDataExecutionResultSucceeded]),
                    Reference = reference,
                };

                return this.View(model);
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }
    }
}