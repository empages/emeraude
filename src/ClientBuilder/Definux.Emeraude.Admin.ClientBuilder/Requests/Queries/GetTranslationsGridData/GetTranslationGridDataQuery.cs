using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    public class GetTranslationGridDataQuery : IRequest<TranslationsGridDataResult>
    {
        public class GetTranslationGridDataQueryHandler : IRequestHandler<GetTranslationGridDataQuery, TranslationsGridDataResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public GetTranslationGridDataQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<TranslationsGridDataResult> Handle(GetTranslationGridDataQuery request, CancellationToken cancellationToken)
            {
                TranslationsGridDataResult resultData = new TranslationsGridDataResult();
                var languagesData = await this.context.Languages.Include(x => x.Translations).ToListAsync();
                var translationsKeys = await this.context.Keys.AsQueryable().OrderBy(x => x.Key).ToListAsync();
                foreach (var key in translationsKeys)
                {
                    var currentDataItem = new TranslationsGridItem
                    {
                        KeyId = key.Id,
                        Key = key.Key
                    };

                    foreach (var languagesDataItem in languagesData)
                    {
                        var currentTranslation = languagesDataItem
                            .Translations
                            .AsQueryable()
                            .Include(x => x.TranslationKey)
                            .FirstOrDefault(x => x.TranslationKey.Key == key.Key);

                        TranslationsLanguageValue languageValue = new TranslationsLanguageValue
                        {
                            LanguageCode = languagesDataItem.Code,
                            Value = currentTranslation?.Value,
                            Id = currentTranslation.Id,
                        };

                        currentDataItem.LanguageValues.Add(languageValue);
                    }

                    resultData.Items.Add(currentDataItem);
                }

                return resultData;
            }
        }
    }
}
