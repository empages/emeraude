using System;
using System.Threading.Tasks;
using Definux.Emeraude.Client.Attributes;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Client.UI.ViewModels.ExecutionResult;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Client controller for MVC execution results.
    /// </summary>
    public class ClientExecutionResultController : PublicController
    {
        private const string ResultRoute = "/execution/result";
        private const string HandleRoute = "/execution/handle";
        private const string MainViewName = "ExecutionResult/Index";

        private const string TempDataExecutionResultTitle = "TempDataExecutionResultTitle";
        private const string TempDataExecutionResultMessage = "TempDataExecutionResultMessage";
        private const string TempDataExecutionResultSucceeded = "TempDataExecutionResultSucceeded";

        private const string ExecutionResultTitle = "EXECUTION_RESULT_PAGE_TITLE";
        private const string ExecutionResultDescription = "EXECUTION_RESULT_PAGE_DESCRIPTION";

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
        [MetaTag(MainMetaTags.Title, ExecutionResultTitle, true)]
        [MetaTag(MainMetaTags.Description, ExecutionResultDescription, true)]
        [Canonical]
        public async Task<IActionResult> Handle(
            [FromQuery(Name = "title")]string title,
            [FromQuery(Name = "message")]string message,
            [FromQuery(Name = "succeeded")]bool succeeded,
            [FromQuery(Name = "reference")]string reference)
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
        [MetaTag(MainMetaTags.Title, ExecutionResultTitle, true)]
        [MetaTag(MainMetaTags.Description, ExecutionResultDescription, true)]
        [Canonical]
        public async Task<IActionResult> Index([FromQuery(Name = "reference")]string reference)
        {
            try
            {
                var model = new IndexViewModel
                {
                    Title = this.TempData[TempDataExecutionResultTitle].ToString(),
                    Message = this.TempData[TempDataExecutionResultMessage].ToString(),
                    Succeeded = Convert.ToBoolean(this.TempData[TempDataExecutionResultSucceeded]),
                    Reference = reference,
                };

                return this.View(MainViewName, model);
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }
    }
}