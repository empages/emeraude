using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError
{
    /// <summary>
    /// Command for log front-end error.
    /// </summary>
    public class LogFrontEndErrorCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Stack trace of the error.
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// Error source.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// The method where the error occured.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Message of the error.
        /// </summary>
        public string Message { get; set; }

        /// <inheritdoc/>
        public class LogFrontEndErrorCommandHandler : IRequestHandler<LogFrontEndErrorCommand, SimpleResult>
        {
            private readonly IEmLogger logger;
            private readonly ILoggerContext loggerContext;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="LogFrontEndErrorCommandHandler"/> class.
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="loggerContext"></param>
            /// <param name="mapper"></param>
            public LogFrontEndErrorCommandHandler(IEmLogger logger, ILoggerContext loggerContext, IMapper mapper)
            {
                this.logger = logger;
                this.loggerContext = loggerContext;
                this.mapper = mapper;
            }

            public async Task<SimpleResult> Handle(LogFrontEndErrorCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    var errorLog = this.mapper.Map<ErrorLog>(request);
                    this.loggerContext.ErrorLogs.Add(errorLog);
                    await this.loggerContext.SaveChangesAsync(cancellationToken);
                    return SimpleResult.SuccessfulResult;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return SimpleResult.UnsuccessfulResult;
                }
            }
        }
    }
}