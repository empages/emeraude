using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Domain.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Query that returns the all translation keys and values into grid format.
    /// </summary>
    public class GetTranslationGridDataQuery : IRequest<TranslationsGridDataResult>
    {
        /// <summary>
        /// Search query for filtration.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Filtration page number.
        /// </summary>
        public int Page { get; set; }

        /// <inheritdoc/>
        public class GetTranslationGridDataQueryHandler : IRequestHandler<GetTranslationGridDataQuery, TranslationsGridDataResult>
        {
            private const int DefaultPageSize = 50;

            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetTranslationGridDataQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public GetTranslationGridDataQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<TranslationsGridDataResult> Handle(GetTranslationGridDataQuery request, CancellationToken cancellationToken)
            {
                string searchQuery = request.SearchQuery?.Trim().ToUpperInvariant() ?? string.Empty;
                TranslationsGridDataResult resultData = new TranslationsGridDataResult();

                Expression<Func<TranslationKey, bool>> filterExpression = x => true;
                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var idsByValues = await this.context
                        .Values
                        .Where(x => EF.Functions.Like(x.NormalizedValue, $"%{searchQuery}%"))
                        .Select(x => x.TranslationKeyId)
                        .Distinct()
                        .ToListAsync(cancellationToken);

                    filterExpression = x =>
                        EF.Functions.Like(x.Key, $"%{searchQuery}%") || idsByValues.Contains(x.Id);
                }

                var translationsKeysQuery = this
                    .context
                    .Keys
                    .Where(filterExpression);

                resultData.AllItemsCount = await translationsKeysQuery.CountAsync(cancellationToken);
                resultData.PageSize = DefaultPageSize;
                resultData.CurrentPage = request.Page > 0 ? request.Page : 1;

                var translationsKeys = await translationsKeysQuery
                    .OrderBy(x => x.Key)
                    .Skip(resultData.StartRow)
                    .Take(DefaultPageSize)
                    .Include(x => x.Translations)
                    .ToListAsync(cancellationToken);

                var languages = await this.context
                    .Languages
                    .OrderByDescending(x => x.IsDefault)
                    .ToListAsync(cancellationToken);

                var items = new List<TranslationsGridItem>();

                foreach (var key in translationsKeys)
                {
                    var currentDataItem = new TranslationsGridItem
                    {
                        KeyId = key.Id,
                        Key = key.Key,
                    };

                    foreach (var language in languages)
                    {
                        var currentTranslation = key
                            .Translations
                            .FirstOrDefault(x => x.LanguageId == language.Id);

                        var languageValue = new TranslationsLanguageValue
                        {
                            LanguageCode = language.Code,
                            Value = currentTranslation?.Value,
                            Id = currentTranslation?.Id ?? -1,
                        };

                        currentDataItem.LanguageValues.Add(languageValue);
                    }

                    items.Add(currentDataItem);
                }

                resultData.Items = items;

                return resultData;
            }
        }
    }
}
