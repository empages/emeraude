using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Utilities.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    /// <summary>
    /// Abstract admin controller that provides all required services and methods you need in the administration panel.
    /// </summary>
    [Area(AdminAreaName)]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public abstract class AdminController : Controller
    {
        /// <summary>
        /// Admin area name.
        /// </summary>
        protected const string AdminAreaName = "Admin";

        private IEmLogger logger;
        private UrlEncoder urlEncoder;
        private IMediator mediator;
        private ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        public AdminController()
        {
            this.ControllerRoute = this.GetType().GetAttribute<RouteAttribute>()?.Template;
        }

        /// <summary>
        /// Name of the area of the controller.
        /// </summary>
        [ViewData]
        public string AreaName => this.HttpContext.Request.RouteValues["Area"]?.ToString();

        /// <summary>
        /// Name of the controller.
        /// </summary>
        [ViewData]
        public string ControllerName => this.HttpContext.Request.RouteValues["Controller"]?.ToString();

        /// <summary>
        /// Name of the action.
        /// </summary>
        [ViewData]
        public string ActionName => this.HttpContext.Request.RouteValues["Action"]?.ToString();

        /// <summary>
        /// Route of the controller.
        /// </summary>
        public string ControllerRoute { get; protected set; }

        /// <inheritdoc cref="IEmLogger"/>
        protected IEmLogger Logger
        {
            get
            {
                if (this.logger is null)
                {
                    this.logger = this.HttpContext.RequestServices.GetService<IEmLogger>();
                }

                return this.logger;
            }
        }

        /// <inheritdoc cref="IMediator"/>
        protected IMediator Mediator
        {
            get
            {
                if (this.mediator is null)
                {
                    this.mediator = this.HttpContext?.RequestServices?.GetService<IMediator>();
                }

                return this.mediator;
            }
        }

        /// <inheritdoc cref="System.Text.Encodings.Web.UrlEncoder"/>
        protected UrlEncoder UrlEncoder
        {
            get
            {
                if (this.urlEncoder is null)
                {
                    this.urlEncoder = this.HttpContext.RequestServices.GetService<UrlEncoder>();
                }

                return this.urlEncoder;
            }
        }

        /// <inheritdoc cref="ICurrentUserProvider"/>
        protected ICurrentUserProvider CurrentUserProvider
        {
            get
            {
                if (this.currentUserProvider is null)
                {
                    this.currentUserProvider = this.HttpContext.RequestServices.GetService<ICurrentUserProvider>();
                }

                return this.currentUserProvider;
            }
        }

        /// <summary>
        /// Flag that activate and disable activity logging by Emeraude logger.
        /// </summary>
        protected bool DisableActivityLog { get; set; }

        /// <summary>
        /// Flag that hide or show the request params in activity log.
        /// </summary>
        protected bool HideActivityLogParameters { get; set; }

        /// <inheritdoc cref="OnActionExecuting(ActionExecutingContext)"/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!this.DisableActivityLog)
            {
                this.Logger.LogActivity(context, this.HideActivityLogParameters);
            }

            base.OnActionExecuting(context);
        }

        /// <summary>
        /// Build controller route for current controller.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        protected string BuildControllerRoute(string route)
        {
            string correctedRoute = route;
            if (correctedRoute.StartsWith("/"))
            {
                correctedRoute = correctedRoute.Substring(1);
            }

            string basePart = this.ControllerRoute;
            if (!basePart.EndsWith("/"))
            {
                basePart = basePart + "/";
            }

            return $"{basePart}{correctedRoute}";
        }

        /// <summary>
        /// Initialize navigation actions for the navbar of the admin panel.
        /// </summary>
        /// <param name="actions"></param>
        protected void InitializeNavigationActions(IEnumerable<NavigationActionViewModel> actions)
        {
            this.ViewData.InitializeNavigationActions(actions);
        }

        /// <summary>
        /// Add success notificaiton message in entities table view.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ShowSuccessNotification(string message)
        {
            this.TempData["SuccessStatusMessage"] = message;
        }

        /// <summary>
        /// Add error notification message in entities table view.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ShowErrorNotification(string message)
        {
            this.TempData["ErrorStatusMessage"] = message;
        }

        /// <summary>
        /// Add notification message based on computation result.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="successMessage"></param>
        /// <param name="errorMessage"></param>
        protected virtual void ShowComputationNotification(bool success, string successMessage, string errorMessage)
        {
            if (success)
            {
                this.ShowSuccessNotification(successMessage);
            }
            else
            {
                this.ShowErrorNotification(errorMessage);
            }
        }
    }
}
