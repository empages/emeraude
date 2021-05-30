using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.UI.ViewModels.Logging;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Identity.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
        /// <summary>
        /// Abstract definition for Logger query handler.
        /// </summary>
        /// <typeparam name="TRequest">Target request.</typeparam>
        /// <typeparam name="TResult">Request result.</typeparam>
        /// <typeparam name="TLoggerEntity">Target logger entity.</typeparam>
        /// <typeparam name="TLoggerEntityViewModel">Target logger entity view model.</typeparam>
        public abstract class FetchLogsQueryHandler<TRequest, TResult, TLoggerEntity, TLoggerEntityViewModel> : IRequestHandler<TRequest, TResult>
            where TRequest : FetchLogsQuery<TResult>
            where TResult : LogEntitiesViewModel<TLoggerEntityViewModel>, new()
            where TLoggerEntity : class, ILoggerEntity
            where TLoggerEntityViewModel : LogEntityViewModel
        {
            private readonly ILoggerContext loggerContext;
            private readonly IEmContext entityContext;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="FetchLogsQueryHandler{TRequest, TResult, TLoggerEntity, TLoggerEntityViewModel}"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public FetchLogsQueryHandler(ILoggerContext loggerContext, IEmContext entityContext, IMapper mapper)
            {
                this.loggerContext = loggerContext;
                this.entityContext = entityContext;
                this.mapper = mapper;
            }

            /// <inheritdoc />
            public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
            {
                var result = new TResult
                {
                    SearchQuery = request.SearchQuery,
                    FromDate = request.FromDate,
                    ToDate = request.ToDate,
                };

                int pageSize = 20;
                var searchQueryExpression = this.BuildSearchQueryExpression(request.SearchQuery);

                Expression<Func<TLoggerEntity, bool>> startDateFilterExpression = x => true;
                if (request.FromDate.HasValue)
                {
                    startDateFilterExpression = x => x.CreatedOn >= request.FromDate.Value;
                }

                Expression<Func<TLoggerEntity, bool>> endDateFilterExpression = x => true;
                if (request.ToDate.HasValue)
                {
                    endDateFilterExpression = x => x.CreatedOn < request.ToDate.Value.AddDays(1);
                }

                Expression<Func<TLoggerEntity, bool>> userFilterExpression = x => true;
                if (!string.IsNullOrWhiteSpace(request.User))
                {
                    userFilterExpression = x => x.CreatedBy == request.User.Trim();
                }

                result.AllItemsCount = this.loggerContext
                    .Set<TLoggerEntity>()
                    .Where(searchQueryExpression)
                    .Where(startDateFilterExpression)
                    .Where(endDateFilterExpression)
                    .Where(userFilterExpression)
                    .Count();

                result.CurrentPage = request.Page;
                result.PageSize = pageSize;

                var logs = this.loggerContext
                    .Set<TLoggerEntity>()
                    .OrderByDescending(x => x.CreatedOn)
                    .Where(searchQueryExpression)
                    .Where(startDateFilterExpression)
                    .Where(endDateFilterExpression)
                    .Where(userFilterExpression)
                    .Skip(result.StartRow)
                    .Take(pageSize)
                    .ProjectTo<TLoggerEntityViewModel>(this.mapper.ConfigurationProvider)
                    .ToList();

                var involvedUsersIds = logs
                    .Where(x => !string.IsNullOrEmpty(x.CreatedBy))
                    .Select(x => x.CreatedBy)
                    .ToList()
                    .Distinct();

                var involvedUsers = this.entityContext
                    .Set<User>()
                    .Where(x => involvedUsersIds.Contains(x.Id.ToString()))
                    .ToList();

                int logsCount = logs.Count();
                for (int i = 0; i < logsCount; i++)
                {
                    if (Guid.TryParse(logs[i].CreatedBy, out var userId))
                    {
                        var involvedUser = involvedUsers.FirstOrDefault(x => x.Id == userId);
                        if (involvedUser != null)
                        {
                            logs[i].InvolvedUser = new LogUserViewModel
                            {
                                Id = involvedUser.Id,
                                Email = involvedUser.Email,
                                Name = involvedUser.Name,
                            };
                        }
                    }
                }

                result.Items = logs;

                return result;
            }

            /// <summary>
            /// Defines search query expression.
            /// </summary>
            /// <param name="searchQuery"></param>
            /// <returns></returns>
            protected abstract Expression<Func<TLoggerEntity, bool>> BuildSearchQueryExpression(string searchQuery);
        }
}