using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Essentials.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Definux.Emeraude.Application.Behaviours
{
    /// <summary>
    /// Pipeline behavior that logs the request.
    /// </summary>
    /// <typeparam name="TRequest">Request.</typeparam>
    /// <typeparam name="TResponse">Response.</typeparam>
    public class RequestLoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<TRequest> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLoggingBehavior{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="logger"></param>
        // ReSharper disable once ContextualLoggerProblem
        public RequestLoggingBehavior(ILogger<TRequest> logger)
        {
            this.logger = logger;
        }

        /// <inheritdoc/>
        public Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                this.logger.LogInformation(
                    "[EM] Executed request of type {Request} with instance of {RequestInstance}",
                    typeof(TRequest),
                    request?.ToLoggingString());
            }
            catch (Exception)
            {
                this.logger.LogInformation(
                    "[EM] Executed request of type {Request}",
                    typeof(TRequest));
            }

            return next();
        }
    }
}