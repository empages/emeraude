using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Requests;
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
        public async Task<IActionResult> Index()
        {
            object viewModel = null;
            if (this.options.AdminDashboardRequestType != null)
            {
                var dashboardRequestType = this.options.AdminDashboardRequestType;
                var dashboardRequestTypeInterfaces = dashboardRequestType.GetInterfaces();
                if (dashboardRequestTypeInterfaces.All(x => x.Name != "IDashboardRequest`1"))
                {
                    throw new InvalidCastException("AdminDashboardRequestType must be implementation of IDashboardRequest<TResponse>");
                }

                var request = Activator.CreateInstance(this.options.AdminDashboardRequestType);
                if (request != null)
                {
                    viewModel = await this.Mediator.Send(request);
                }
            }

            return this.View(viewModel);
        }
    }
}
