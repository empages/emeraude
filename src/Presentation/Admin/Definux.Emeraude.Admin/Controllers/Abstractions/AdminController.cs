using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Utilities.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Definux.Emeraude.Admin.UI.Extensions;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Configuration.Authorization;
using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Domain.Entities;
using System;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    [Area(AdminAreaName)]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public abstract class AdminController : Controller
    {
        protected const string AdminAreaName = "Admin";

        private ILogger logger;
        private UrlEncoder urlEncoder;
        private IMediator mediator;
        private ICurrentUserProvider currentUserProvider;

        public AdminController()
        {
            ControllerRoute = this.GetType().GetAttribute<RouteAttribute>()?.Template;
        }

        protected ILogger Logger
        {
            get
            {
                if (this.logger is null)
                {
                    this.logger = this.HttpContext.RequestServices.GetService<ILogger>();
                }

                return this.logger;
            }
        }

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

        public bool DisableActivityLog { get; set; }

        public bool HideActivityLogParameters { get; set; }

        [ViewData]
        public string AreaName => HttpContext.Request.RouteValues["Area"]?.ToString();

        [ViewData]
        public string ControllerName => HttpContext.Request.RouteValues["Controller"]?.ToString();

        [ViewData]
        public string ActionName => HttpContext.Request.RouteValues["Action"]?.ToString();

        public string ControllerRoute { get; protected set; }

        public string BuildControllerRoute(string route)
        {
            string correctedRoute = route;
            if (correctedRoute.StartsWith("/"))
            {
                correctedRoute = correctedRoute.Substring(1);
            }

            string basePart = ControllerRoute;
            if (!basePart.EndsWith("/"))
            {
                basePart = basePart + "/";
            }

            return $"{basePart}{correctedRoute}";
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!DisableActivityLog)
            {
                Logger.LogActivity(context, HideActivityLogParameters);
            }

            base.OnActionExecuting(context);
        }

        protected void InitializeNavigationActions(IEnumerable<NavigationActionViewModel> actions)
        {
            ViewData.InitializeNavigationActions(actions);
        }

        /// <summary>
        /// Add success notificaiton message in entities table view.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ShowSuccessNotification(string message)
        {
            TempData["SuccessStatusMessage"] = message;
        }

        /// <summary>
        /// Add error notification message in entities table view.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ShowErrorNotification(string message)
        {
            TempData["ErrorStatusMessage"] = message;
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
                ShowSuccessNotification(successMessage);
            }
            else
            {
                ShowErrorNotification(errorMessage);
            }
        }
    }
}
