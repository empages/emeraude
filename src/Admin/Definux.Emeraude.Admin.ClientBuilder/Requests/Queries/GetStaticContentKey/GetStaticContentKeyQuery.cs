using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKey
{
    public class GetStaticContentKeyQuery : IRequest<StaticContentKeyResult>
    {
        public int KeyId { get; set; }

        public class GetStaticContentKeyQueryHandler : IRequestHandler<GetStaticContentKeyQuery, StaticContentKeyResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public GetStaticContentKeyQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<StaticContentKeyResult> Handle(GetStaticContentKeyQuery request, CancellationToken cancellationToken)
            {
                var key = await this.context
                    .ContentKeys
                    .AsQueryable()
                    .Include(x => x.StaticContentList)
                    .ProjectTo<StaticContentKeyResult>(this.mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId);

                return key;
            }
        }
    }
}
