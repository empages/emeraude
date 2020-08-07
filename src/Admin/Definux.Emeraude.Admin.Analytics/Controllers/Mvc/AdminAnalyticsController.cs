using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Analytics.Controllers.Mvc
{
    [Area("Admin")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class AdminAnalyticsController : Controller
    {
        [HttpGet]
        [Route("/admin/analytics")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
