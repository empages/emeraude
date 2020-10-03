using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKeys
{
    /// <summary>
    /// Query that returns collection of all static content keys.
    /// </summary>
    public class GetStaticContentKeysQuery : IRequest<IEnumerable<StaticContentKeyResult>>
    {
        /// <inheritdoc/>
        public class GetStaticContentKeysQueryHandler : IRequestHandler<GetStaticContentKeysQuery, IEnumerable<StaticContentKeyResult>>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetStaticContentKeysQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public GetStaticContentKeysQueryHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
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
