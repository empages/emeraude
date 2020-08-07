using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteContentKey
{
    public class DeleteContentKeyCommand : IRequest<SimpleResult>
    {
        public int KeyId { get; set; }

        public class DeleteContentKeyCommandHandler : IRequestHandler<DeleteContentKeyCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public DeleteContentKeyCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<SimpleResult> Handle(DeleteContentKeyCommand request, CancellationToken cancellationToken)
            {
                var keyToRemove = await this.context
                    .ContentKeys
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId);

                this.context.ContentKeys.Remove(keyToRemove);

                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
