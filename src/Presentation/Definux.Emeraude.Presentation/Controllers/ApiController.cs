using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Presentation.Controllers
{
    [ApiController]
    public class ApiController : Controller
    {
        private ILogger logger;
        private IMediator mediator;

        protected ILogger Logger
        {
            get
            {
                if (this.logger is null)
                {
                    this.logger = this.HttpContext?.RequestServices?.GetService<ILogger>();
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

        public bool DisableActivityLog { get; set; }

        public bool HideActivityLogParameters { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!DisableActivityLog)
            {
                Logger.LogActivity(context, HideActivityLogParameters);
            }



            base.OnActionExecuting(context);
        }

        protected IActionResult GetSuccessResponse(bool success)
        {
            if (success)
            {
                return Ok();
            }

            return BadRequest();
        }

        protected IActionResult GetSimpleResponse(bool success)
        {
            return Ok(new SimpleResult(success));
        }
    }
}
