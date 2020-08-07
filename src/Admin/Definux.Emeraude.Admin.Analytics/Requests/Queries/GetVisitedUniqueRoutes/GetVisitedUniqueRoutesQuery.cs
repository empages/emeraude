using Definux.Emeraude.Application.Common.Interfaces.Logging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetVisitedUniqueRoutes
{
    public class GetVisitedUniqueRoutesQuery : IRequest<IEnumerable<string>>
    {
        public class GetVisitedUniqueRoutesQueryHandler : IRequestHandler<GetVisitedUniqueRoutesQuery, IEnumerable<string>>
        {
            private readonly ILoggerContext context;

            public GetVisitedUniqueRoutesQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

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
