using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Definux.Emeraude.Presentation.ActionFilters
{
    /// <summary>
    /// Filter for catching specific exceptions during request execution.
    /// </summary>
    public class RequestExceptionFilter : ExceptionFilterAttribute
    {
        private readonly IDictionary<Type, Action<ExceptionContext>> exceptionHandlers;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExceptionFilter"/> class.
        /// </summary>
        public RequestExceptionFilter()
        {
            this.exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>
            {
                { typeof(ValidationException), this.HandleValidationException },
                { typeof(PageNotFoundException), this.HandlePageNotFoundException },
                { typeof(EntityNotFoundException), this.HandleEntityNotFoundException },
            };
        }

        /// <inheritdoc/>
        public override void OnException(ExceptionContext context)
        {
            this.TryHandleException(context);
            base.OnException(context);
        }

        private void TryHandleException(ExceptionContext context)
        {
            Type type = context.Exception.GetType();
            if (this.exceptionHandlers.ContainsKey(type))
            {
                this.exceptionHandlers[type].Invoke(context);
            }
        }

        private void HandleValidationException(ExceptionContext context)
        {
            var exception = context.Exception as ValidationException;

            var errorTitle = "One or more validation errors occurred.";
            if (exception?.Failures.Any() ?? false)
            {
                errorTitle = exception
                    ?.Failures
                    .Values
                    .FirstOrDefault()
                    ?.FirstOrDefault();
            }

            var details = new ValidationProblemDetails(exception?.Failures)
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = errorTitle,
            };

            context.Result = new BadRequestObjectResult(details);

            context.ExceptionHandled = true;
        }

        private void HandlePageNotFoundException(ExceptionContext context)
        {
            var exception = context.Exception as PageNotFoundException;

            context.Result = new NotFoundResult();

            context.ExceptionHandled = true;
        }

        private void HandleEntityNotFoundException(ExceptionContext context)
        {
            var exception = context.Exception as EntityNotFoundException;

            var details = new ProblemDetails()
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                Title = "The specified resource was not found.",
                Detail = exception?.Message,
            };

            context.Result = new NotFoundObjectResult(details);

            context.ExceptionHandled = true;
        }
    }
}