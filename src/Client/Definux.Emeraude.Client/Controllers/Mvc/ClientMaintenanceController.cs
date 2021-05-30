using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Maintenance controller for the static page of maintenance mode of the application.
    /// </summary>
    public class ClientMaintenanceController : PublicController
    {
        private const string MaintenanceRoute = "/maintenance";
        private const string MaintenanceViewName = "Maintenance/Index";

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMaintenanceController"/> class.
        /// </summary>
        public ClientMaintenanceController()
        {
            this.IgnoreMaintenanceMode = true;
        }

        /// <summary>
        /// Index action of the maintenance controller.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(MaintenanceRoute)]
        [LanguageRoute(MaintenanceRoute)]
        public IActionResult Index()
        {
            if (!this.Options.MaintenanceMode)
            {
                return this.NotFound();
            }

            return this.View(MaintenanceViewName);
        }
    }
}
