using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetLanguages
{
    public class GetLanguagesQuery : IRequest<IEnumerable<LanguageResult>>
    {
        public class GetLanguagesQueryHandler : IRequestHandler<GetLanguagesQuery, IEnumerable<LanguageResult>>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public GetLanguagesQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<IEnumerable<LanguageResult>> Handle(GetLanguagesQuery request, CancellationToken cancellationToken)
            {
                return await this.context
                    .Languages
                    .AsQueryable()
                    .ProjectTo<LanguageResult>(this.mapper.ConfigurationProvider)
                    .ToListAsync();
            }
        }
    }
}
