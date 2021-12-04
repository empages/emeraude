using System.Threading;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.DeleteKey;

/// <summary>
/// Command that deletes a specified translation keys and its related translations.
/// </summary>
public class DeleteKeyCommand : IRequest<SimpleResult>
{
    /// <summary>
    /// Id of the key.
    /// </summary>
    public int KeyId { get; set; }

    /// <inheritdoc/>
    public class DeleteKeyCommandHandler : IRequestHandler<DeleteKeyCommand, SimpleResult>
    {
        private readonly ILocalizationContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteKeyCommandHandler"/> class.
        /// </summary>
        /// <param name="context"></param>
        public DeleteKeyCommandHandler(ILocalizationContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public async Task<SimpleResult> Handle(DeleteKeyCommand request, CancellationToken cancellationToken)
        {
            var keyToRemove = await this.context
                .Keys
                .FirstOrDefaultAsync(x => x.Id == request.KeyId, cancellationToken);

            if (keyToRemove == null)
            {
                throw new EntityNotFoundException("Translation key", request.KeyId);
            }

            this.context.Keys.Remove(keyToRemove);
            await this.context.SaveChangesAsync(cancellationToken);

            return new SimpleResult(true);
        }
    }
}