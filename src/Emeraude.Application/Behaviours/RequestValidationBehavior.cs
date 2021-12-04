using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using ValidationException = Emeraude.Application.Exceptions.ValidationException;

namespace Emeraude.Application.Behaviours;

/// <summary>
/// Pipeline behavior that handles the validation errors of the executed requests.
/// </summary>
/// <typeparam name="TRequest">Request.</typeparam>
/// <typeparam name="TResponse">Response.</typeparam>
public class RequestValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> validators;

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestValidationBehavior{TRequest, TResponse}"/> class.
    /// </summary>
    /// <param name="validators"></param>
    public RequestValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        this.validators = validators;
    }

    /// <inheritdoc/>
    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        var context = new ValidationContext<TRequest>(request);

        var failures = this.validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .ToList();

        if (failures.Count != 0)
        {
            throw new Exceptions.ValidationException(failures);
        }

        return next();
    }
}