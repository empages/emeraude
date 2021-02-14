using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Logger;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.GetEmailBody
{
    /// <summary>
    /// Returns body from specified email log id.
    /// </summary>
    public class GetEmailBodyQuery : IRequest<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailBodyQuery"/> class.
        /// </summary>
        /// <param name="emailLogId"></param>
        public GetEmailBodyQuery(int emailLogId)
        {
            this.EmailLogId = emailLogId;
        }

        /// <summary>
        /// Id of the email log.
        /// </summary>
        public int EmailLogId { get; set; }

        /// <inheritdoc />
        public class GetEmailBodyQueryHandler : IRequestHandler<GetEmailBodyQuery, string>
        {
            private readonly ILoggerContext context;
            private readonly IEmLogger logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetEmailBodyQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="logger"></param>
            public GetEmailBodyQueryHandler(ILoggerContext context, IEmLogger logger)
            {
                this.context = context;
                this.logger = logger;
            }

            /// <inheritdoc />
            public async Task<string> Handle(GetEmailBodyQuery request, CancellationToken cancellationToken)
            {
                var emailLog = await this.context
                    .EmailLogs
                    .FirstOrDefaultAsync(x => x.Id == request.EmailLogId, cancellationToken);

                if (emailLog == null)
                {
                    throw new EntityNotFoundException("Email log", request.EmailLogId);
                }

                return emailLog.Body;
            }
        }
    }
}