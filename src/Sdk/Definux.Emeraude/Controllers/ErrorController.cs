using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Definux.Emeraude.Controllers
{
    public class ErrorController : PublicController
    {
        [HttpGet("/error/{statusCode}")]
        public IActionResult Index(int statusCode, [FromServices]ICompositeViewEngine compositeViewEngine)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            if (compositeViewEngine.FindView(ControllerContext, "Index", false).Success)
            {
                return View(statusCode);
            }
            
            return StatusCode(statusCode);
        }
    }
}
