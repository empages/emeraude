using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Identity;
using EmDoggo.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmDoggo.Application.Requests.InitialStates.Dogs
{
    public class DogsInitialStateQuery : IRequest<DogsViewModel>
    {
        public class DogsInitialStateQueryHandler : IRequestHandler<DogsInitialStateQuery, DogsViewModel>
        {
            private readonly IEntityContext context;
            private readonly IMapper mapper;
            private readonly ICurrentUserProvider currentUserProvider;

            public DogsInitialStateQueryHandler(IEntityContext context, IMapper mapper, ICurrentUserProvider currentUserProvider)
            {
                this.context = context;
                this.mapper = mapper;
                this.currentUserProvider = currentUserProvider;
            }

            public async Task<DogsViewModel> Handle(DogsInitialStateQuery request, CancellationToken cancellationToken)
            {
                var resultData = new DogsViewModel();
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                resultData.Dogs = await this.context
                    .Dogs
                    .Where(x => x.Owner.UserId == currentUser.Id)
                    .ProjectTo<DogModel>(this.mapper.ConfigurationProvider)
                    .ToListAsync();

                return resultData;
            }
        }
    }
}