using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Logger;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetVisitedUniqueRoutes
{
    /// <summary>
    /// Query that returns all visited unique routes of the application.
    /// </summary>
    public class GetVisitedUniqueRoutesQuery : IRequest<IEnumerable<string>>
    {
        /// <inheritdoc/>
        public class GetVisitedUniqueRoutesQueryHandler : IRequestHandler<GetVisitedUniqueRoutesQuery, IEnumerable<string>>
        {
            private readonly ILoggerContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetVisitedUniqueRoutesQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public GetVisitedUniqueRoutesQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<IEnumerable<string>> Handle(GetVisitedUniqueRoutesQuery request, CancellationToken cancellationToken)
            {
                return await this.context
                    .ActivityLogs
                    .AsQueryable()
                    .Select(x => x.Route.ToLower())
                    .Distinct()
                    .ToListAsync();
            }
        }
    }
}
