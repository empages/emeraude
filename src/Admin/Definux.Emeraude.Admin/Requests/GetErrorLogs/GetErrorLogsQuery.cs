using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.UI.ViewModels.System;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Identity.Entities;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.GetErrorLogs
{
    public class GetErrorLogsQuery : IRequest<ErrorLogsViewModel>
    {
        public int Page { get; set; } = 1;

        public string SearchQuery { get; set; }

        public class GetErrorLogsQueryHandler : IRequestHandler<GetErrorLogsQuery, ErrorLogsViewModel>
        {
            private readonly ILoggerContext loggerContext;
            private readonly IEmContext entityContext;
            private readonly IMapper mapper;

            public GetErrorLogsQueryHandler(ILoggerContext loggerContext, IEmContext entityContext, IMapper mapper)
            {
                this.loggerContext = loggerContext;
                this.entityContext = entityContext;
                this.mapper = mapper;
            }

            public async Task<ErrorLogsViewModel> Handle(GetErrorLogsQuery request, CancellationToken cancellationToken)
            {
                ErrorLogsViewModel result = new ErrorLogsViewModel();
                result.SearchQuery = request.SearchQuery;

                int pageSize = 20;
                var searchQueryExpression = BuildSearchQueryExpression(request.SearchQuery);

                result.AllItemsCount = this.loggerContext
                    .ErrorLogs
                    .AsQueryable()
                    .Where(searchQueryExpression.Compile())
                    .Count();

                result.CurrentPage = request.Page;
                result.PageSize = pageSize;

                var errorLogs = this.loggerContext
                    .ErrorLogs
                    .AsQueryable()
                    .OrderByDescending(x => x.CreatedOn)
                    .Where(searchQueryExpression.Compile())
                    .Skip(result.StartRow)
                    .Take(pageSize)
                    .AsQueryable()
                    .ProjectTo<ErrorLogViewModel>(this.mapper.ConfigurationProvider)
                    .ToList();

                var involvedUsersIds = errorLogs
                    .Where(x => !string.IsNullOrEmpty(x.CreatedBy))
                    .Select(x => x.CreatedBy)
                    .ToList()
                    .Distinct();

                var involvedUsers = this.entityContext
                    .Set<User>()
                    .AsQueryable()
                    .Where(x => involvedUsersIds.Contains(x.Id.ToString()))
                    .ToList();

                int errorLogsCount = errorLogs.Count();
                for (int i = 0; i < errorLogsCount; i++)
                {
                    Guid userId = Guid.Empty;
                    if (Guid.TryParse(errorLogs[i].CreatedBy?.ToString(), out userId))
                    {
                        var involvedUser = involvedUsers.FirstOrDefault(x => x.Id == userId);
                        if (involvedUser != null)
                        {
                            errorLogs[i].InvolvedUser = new ErrorLogUser
                            {
                                Email = involvedUser.Email,
                                Name = involvedUser.Name
                            };
                        }
                    }
                }
                
                result.Items = errorLogs;

                return result;
            }

            private Expression<Func<ErrorLog, bool>> BuildSearchQueryExpression(string searchQuery)
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    return x => true;
                }

                return x =>
                    x.Source.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    x.Message.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    x.Method.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    x.StackTrace.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    x.Class.Contains(searchQuery, StringComparison.OrdinalIgnoreCase);
            }
        }
    }

}
