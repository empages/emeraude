using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Analytics.Controllers.Mvc
{
    /// <summary>
    /// Controller that load the admin analytics as a sub-application.
    /// </summary>
    [Area("Admin")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public sealed class AdminAnalyticsController : Controller
    {
        /// <summary>
        /// Index action of the controller.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/admin/analytics")]
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
