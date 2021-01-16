using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.UI.ViewModels.System;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Identity.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.GetErrorLogs
{
    /// <summary>
    /// Get errors logs with optional page and search query.
    /// </summary>
    public class GetErrorLogsQuery : IRequest<ErrorLogsViewModel>
    {
        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Search query string.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <inheritdoc/>
        public class GetErrorLogsQueryHandler : IRequestHandler<GetErrorLogsQuery, ErrorLogsViewModel>
        {
            private readonly ILoggerContext loggerContext;
            private readonly IEmContext entityContext;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetErrorLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public GetErrorLogsQueryHandler(ILoggerContext loggerContext, IEmContext entityContext, IMapper mapper)
            {
                this.loggerContext = loggerContext;
                this.entityContext = entityContext;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<ErrorLogsViewModel> Handle(GetErrorLogsQuery request, CancellationToken cancellationToken)
            {
                ErrorLogsViewModel result = new ErrorLogsViewModel();
                result.SearchQuery = request.SearchQuery;

                int pageSize = 20;
                var searchQueryExpression = this.BuildSearchQueryExpression(request.SearchQuery);

                result.AllItemsCount = this.loggerContext
                    .ErrorLogs
                    .Where(searchQueryExpression)
                    .Count();

                result.CurrentPage = request.Page;
                result.PageSize = pageSize;

                var errorLogs = this.loggerContext
                    .ErrorLogs
                    .OrderByDescending(x => x.CreatedOn)
                    .Where(searchQueryExpression)
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
                            errorLogs[i].InvolvedUser = new ErrorLogViewModel.ErrorLogUser
                            {
                                Email = involvedUser.Email,
                                Name = involvedUser.Name,
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

                string normalizedSearchQuery = searchQuery.ToLower();
                return x =>
                    x.Source.ToLower().Contains(normalizedSearchQuery) ||
                    x.Message.ToLower().Contains(normalizedSearchQuery) ||
                    x.Method.ToLower().Contains(normalizedSearchQuery) ||
                    x.StackTrace.ToLower().Contains(normalizedSearchQuery);
            }
        }
    }
}
