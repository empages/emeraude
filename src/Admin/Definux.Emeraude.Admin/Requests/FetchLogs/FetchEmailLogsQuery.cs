using System;
using System.Linq.Expressions;
using AutoMapper;
using Definux.Emeraude.Admin.UI.ViewModels.Logging;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
    /// <summary>
    /// Fetch activity logs.
    /// </summary>
    public class FetchEmailLogsQuery : FetchLogsQuery<EmailsLogsViewModel>
    {
        /// <inheritdoc />
        public class FetchEmailLogsQueryHandler : FetchLogsQueryHandler<FetchEmailLogsQuery, EmailsLogsViewModel, EmailLog, EmailLogViewModel>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="FetchEmailLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public FetchEmailLogsQueryHandler(
                ILoggerContext loggerContext,
                IEmContext entityContext,
                IMapper mapper)
                : base(loggerContext, entityContext, mapper)
            {
            }

            /// <inheritdoc />
            protected override Expression<Func<EmailLog, bool>> BuildSearchQueryExpression(string searchQuery)
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    return x => true;
                }

                string normalizedSearchQuery = searchQuery.ToLower();
                int.TryParse(normalizedSearchQuery, out int parsedId);
                return x =>
                    x.Id == parsedId ||
                    x.EmailAddress.ToLower().Contains(normalizedSearchQuery) ||
                    x.Subject.ToLower().Contains(normalizedSearchQuery) ||
                    x.Receiver.ToLower().Contains(normalizedSearchQuery) ||
                    x.Body.ToLower().Contains(normalizedSearchQuery);
            }
        }
    }
}