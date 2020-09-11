using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Resources;
using Definux.Utilities.Objects;
using EmDoggoDev.Application.Common.Interfaces.Persistance;
using EmDoggoDev.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmDoggoDev.Application.Requests.Commands.AddDog
{
    public class AddDogCommand : AddDogRequest, IRequest<CreatedResult>
    {
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
