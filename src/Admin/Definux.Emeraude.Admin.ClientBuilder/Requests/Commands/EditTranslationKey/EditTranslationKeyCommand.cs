using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Localization;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslationKey
{
    /// <summary>
    /// Command that edit a translation key.
    /// </summary>
    public class EditTranslationKeyCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the key.
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// New value of the translation key.
        /// </summary>
        public string NewValue { get; set; }

        /// <inheritdoc/>
        public class EditTranslationKeyCommandHandler : IRequestHandler<EditTranslationKeyCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="EditTranslationKeyCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public EditTranslationKeyCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(EditTranslationKeyCommand request, CancellationToken cancellationToken)
            {
                var keyEntity = this.context
                    .Keys
                    .AsQueryable()
                    .Where(x => x.Id == request.KeyId)
                    .FirstOrDefault();

                keyEntity.Key = request.NewValue;

                this.context.Keys.Update(keyEntity);
                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
