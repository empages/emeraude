using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmDoggo.Application.Interfaces;
using EmDoggo.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EmDoggo.Application.Requests.InitialStates.Shops
{
    public class ShopsInitialStateQuery : IRequest<ShopsViewModel>
    {
        public class ShopsInitialStateQueryHandler : IRequestHandler<ShopsInitialStateQuery, ShopsViewModel>
        {
            private readonly IEntityContext context;
            private readonly IMapper mapper;

            public ShopsInitialStateQueryHandler(IEntityContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<ShopsViewModel> Handle(ShopsInitialStateQuery request, CancellationToken cancellationToken)
            {
                var resultData = new ShopsViewModel();
                resultData.Shops = await this.context
                    .Shops
                    .Include(x => x.Foods)
                    .ThenInclude(x => ((ShopFood)x).Food)
                    .ProjectTo<ShopModel>(this.mapper.ConfigurationProvider)
                    .ToListAsync();

                return resultData;
            }
        }
    }
}