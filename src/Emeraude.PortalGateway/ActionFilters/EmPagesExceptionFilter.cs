using System;
using System.Collections.Generic;
using System.Linq;
using Emeraude.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Emeraude.PortalGateway.ActionFilters;

/// <summary>
/// Filter for catching specific exceptions during EmPages-related executions.
/// </summary>
public class EmPagesExceptionFilter : ExceptionFilterAttribute
{
    private readonly IEnumerable<Type> exceptionList;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPagesExceptionFilter"/> class.
    /// </summary>
    public EmPagesExceptionFilter()
    {
        this.exceptionList = new List<Type>
        {
            typeof(EmModelNotFoundException),
            typeof(EmPageNotFoundException),
            typeof(EmSetupException),
            typeof(EmValidationException),
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
        if (this.exceptionList.Contains(type))
        {
            this.HandleEmPageException(context);
        }
    }

    private void HandleEmPageException(ExceptionContext context)
    {
        var exception = context.Exception;

        var details = new ProblemDetails()
        {
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
            Title = "EmPage Error",
            Detail = exception.Message,
        };

        context.Result = new BadRequestObjectResult(details);

        context.ExceptionHandled = true;
    }
}