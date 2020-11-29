using AutoMapper;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Mapping;
using Definux.Utilities.Objects;
using EmDoggo.Application.Common.Interfaces.Persistance;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EmDoggo.Application.Requests.Commands.AddDog
{
    public class AddDogCommand : IRequest<CreatedResult>, IMapFrom<Dog>
    {
        public string Name { get; set; }

        public DogType Type { get; set; }

        public DogBreed Breed { get; set; }

        public class AddDogCommandHandler : IRequestHandler<AddDogCommand, CreatedResult>
        {
            private readonly IEntityContext context;
            private readonly IMapper mapper;
            private readonly ICurrentUserProvider currentUserProvider;

            public AddDogCommandHandler(
                IEntityContext context, 
                IMapper mapper, 
                ICurrentUserProvider currentUserProvider)
            {
                this.context = context;
                this.mapper = mapper;
                this.currentUserProvider = currentUserProvider;
            }

            public async Task<CreatedResult> Handle(AddDogCommand request, CancellationToken cancellationToken)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                var dogEntity = this.mapper.Map<Dog>(request);
                var owner = await this.context.Owners.FirstOrDefaultAsync(x => x.UserId == currentUser.Id);
                dogEntity.OwnerId = owner.Id;

                this.context.Dogs.Add(dogEntity);
                await this.context.SaveChangesAsync();

                return new CreatedResult(dogEntity.Id);
            }
        }
    }

}
