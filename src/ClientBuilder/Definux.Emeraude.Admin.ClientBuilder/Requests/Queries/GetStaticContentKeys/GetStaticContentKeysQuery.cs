using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKeys
{
    public class GetStaticContentKeysQuery : IRequest<IEnumerable<StaticContentKeyResult>>
    {
        public class GetStaticContentKeysQueryHandler : IRequestHandler<GetStaticContentKeysQuery, IEnumerable<StaticContentKeyResult>>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public GetStaticContentKeysQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<IEnumerable<StaticContentKeyResult>> Handle(GetStaticContentKeysQuery request, CancellationToken cancellationToken)
            {
                return await this.context
                    .ContentKeys
                    .AsQueryable()
                    .ProjectTo<StaticContentKeyResult>(this.mapper.ConfigurationProvider)
                    .ToListAsync();
            }
        }
    }
}
