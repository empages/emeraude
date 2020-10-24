using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKey
{
    /// <summary>
    /// Query that get static content key with its referenced static content items.
    /// </summary>
    public class GetStaticContentKeyQuery : IRequest<StaticContentKeyResult>
    {
        /// <summary>
        /// Id of the key.
        /// </summary>
        public int KeyId { get; set; }

        /// <inheritdoc/>
        public class GetStaticContentKeyQueryHandler : IRequestHandler<GetStaticContentKeyQuery, StaticContentKeyResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetStaticContentKeyQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public GetStaticContentKeyQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
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
