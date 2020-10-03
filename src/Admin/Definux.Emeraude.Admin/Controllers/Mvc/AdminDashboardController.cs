using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    /// <summary>
    /// Admin dashboard controller used for index view of the administration.
    /// </summary>
    [Route("/admin/")]
    public sealed class AdminDashboardController : AdminController
    {
        private readonly EmOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDashboardController"/> class.
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public AdminDashboardController(IOptions<EmOptions> optionsAccessor)
        {
            this.options = optionsAccessor.Value;
        }

        /// <summary>
        /// Index action of the controller.
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return this.LocalRedirect(this.options.AdminDashboardIndexRedirectRoute);
        }
    }
}
