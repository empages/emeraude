using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Generic error controller which is triggered by the error interceptor.
    /// </summary>
    public sealed class ErrorController : PublicController
    {
        /// <summary>
        /// Error index action that returns a status code result if there no defined error view or the view placed on 'Views/Client/Error/Index.cshtml'.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="compositeViewEngine"></param>
        /// <returns></returns>
        [HttpGet("/error/{statusCode}")]
        public IActionResult Index(int statusCode, [FromServices]ICompositeViewEngine compositeViewEngine)
        {
            var reExecute = this.HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            if (compositeViewEngine.FindView(this.ControllerContext, "Index", false).Success)
            {
                // ReSharper disable once Mvc.ViewNotResolved
                return this.View(statusCode);
            }

            return this.StatusCode(statusCode);
        }
    }
}
