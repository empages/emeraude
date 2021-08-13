using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Interfaces.Services;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Abstract class for creating API controllers.
    /// </summary>
    [ApiController]
    public abstract class ApiController : Controller
    {
        private IEmLogger logger;
        private IMediator mediator;
        private IEmOptionsProvider optionsProvider;

        /// <inheritdoc cref="IEmOptionsProvider"/>
        protected IEmOptionsProvider OptionsProvider
        {
            get
            {
                if (this.optionsProvider is null)
                {
                    this.optionsProvider = this.HttpContext.RequestServices.GetService<IEmOptionsProvider>();
                }

                return this.optionsProvider;
            }
        }

        /// <inheritdoc cref="IEmLogger"/>
        protected IEmLogger Logger
        {
            get
            {
                if (this.logger is null)
                {
                    this.logger = this.HttpContext?.RequestServices?.GetService<IEmLogger>();
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

        /// <summary>
        /// Flag that activate and disable activity logging by Emeraude logger.
        /// </summary>
        protected bool DisableActivityLog { get; set; }

        /// <summary>
        /// Flag that hide or show the request params in activity log.
        /// </summary>
        protected bool HideActivityLogParameters { get; set; }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!this.DisableActivityLog)
            {
                this.Logger.LogActivity(context, this.HideActivityLogParameters);
            }

            base.OnActionExecuting(context);
        }

        /// <summary>
        /// Get HTTP default OK or Bad request response based on the passed flag.
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        protected IActionResult GetSuccessResponse(bool success)
        {
            if (success)
            {
                return this.Ok();
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Get HTTP OK response with <see cref="SimpleResult"/>.
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        protected IActionResult GetSimpleResponse(bool success)
        {
            return this.Ok(new SimpleResult(success));
        }
    }
}
