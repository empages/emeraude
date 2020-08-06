using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{

    [Route("/admin/")]
    public class AdminDashboardController : AdminController
    {
        private readonly EmOptions options;
        public AdminDashboardController(IOptions<EmOptions> optionsAccessor)
        {
            this.options = optionsAccessor.Value;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return LocalRedirect(this.options.AdminDashboardIndexRedirectRoute);
        }
    }
}
