using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteKey
{
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
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId);

                this.context.Keys.Remove(keyToRemove);

                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
