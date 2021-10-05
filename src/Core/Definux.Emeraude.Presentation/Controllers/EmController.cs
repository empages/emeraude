using System.Text.Encodings.Web;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Base Emeraude controller that provides all required services and base functionalities.
    /// </summary>
    public abstract class EmController : Controller
    {
        private IEmLogger logger;
        private UrlEncoder urlEncoder;
        private IMediator mediator;
        private ICurrentUserProvider currentUserProvider;
        private IEmOptionsProvider optionsProvider;

        /// <inheritdoc cref="IEmLogger"/>
        protected IEmLogger Logger => this.logger ??= this.HttpContext.RequestServices.GetService<IEmLogger>();

        /// <inheritdoc cref="IMediator"/>
        protected IMediator Mediator => this.mediator ??= this.HttpContext?.RequestServices?.GetService<IMediator>();

        /// <inheritdoc cref="System.Text.Encodings.Web.UrlEncoder"/>
        protected UrlEncoder UrlEncoder => this.urlEncoder ??= this.HttpContext.RequestServices.GetService<UrlEncoder>();

        /// <inheritdoc cref="ICurrentUserProvider"/>
        protected ICurrentUserProvider CurrentUserProvider =>
            this.currentUserProvider ??= this.HttpContext.RequestServices.GetService<ICurrentUserProvider>();

        /// <inheritdoc cref="IEmOptionsProvider"/>
        protected IEmOptionsProvider OptionsProvider =>
            this.optionsProvider ??= this.HttpContext.RequestServices.GetService<IEmOptionsProvider>();

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
    }
}