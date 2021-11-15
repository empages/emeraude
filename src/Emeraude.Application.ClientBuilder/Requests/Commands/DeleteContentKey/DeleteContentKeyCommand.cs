using System.Threading;
using System.Threading.Tasks;
using Definux.Utilities.Objects;
using Emeraude.Application.Exceptions;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.DeleteContentKey
{
    /// <summary>
    /// Command that deletes a specified static content key and its related static content items.
    /// </summary>
    public class DeleteContentKeyCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the static content key.
        /// </summary>
        public int KeyId { get; set; }

        /// <inheritdoc/>
        public class DeleteContentKeyCommandHandler : IRequestHandler<DeleteContentKeyCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteContentKeyCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public DeleteContentKeyCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(DeleteContentKeyCommand request, CancellationToken cancellationToken)
            {
                var keyToRemove = await this.context
                    .ContentKeys
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId, cancellationToken);

                if (keyToRemove == null)
                {
                    throw new EntityNotFoundException("Content key", request.KeyId);
                }

                this.context.ContentKeys.Remove(keyToRemove);
                await this.context.SaveChangesAsync(cancellationToken);

                return new SimpleResult(true);
            }
        }
    }
}
