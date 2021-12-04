using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKey;

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
                .Include(x => x.StaticContentList)
                .ProjectTo<StaticContentKeyResult>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == request.KeyId, cancellationToken);

            return key;
        }
    }
}