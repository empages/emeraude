﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKeys;

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
                .ProjectTo<StaticContentKeyResult>(this.mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}