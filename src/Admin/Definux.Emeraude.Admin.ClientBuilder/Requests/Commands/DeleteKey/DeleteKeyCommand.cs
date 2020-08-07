using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteKey
{
    public class DeleteKeyCommand : IRequest<SimpleResult>
    {
        public int KeyId { get; set; }

        public class DeleteKeyCommandHandler : IRequestHandler<DeleteKeyCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public DeleteKeyCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<SimpleResult> Handle(DeleteKeyCommand request, CancellationToken cancellationToken)
            {
                var keyToRemove = await this.context
                    .Keys
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId);

                this.context.Keys.Remove(keyToRemove);

                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
