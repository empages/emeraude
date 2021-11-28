using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditTranslationKeyWithValues
{
    /// <summary>
    /// Command that edit a translation key.
    /// </summary>
    public class EditTranslationKeyWithValuesCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// New value of the translation key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Translation values.
        /// </summary>
        public IEnumerable<TranslationKeyValue> Values { get; set; }

        /// <inheritdoc/>
        public class EditTranslationKeyWithValuesCommandHandler : IRequestHandler<EditTranslationKeyWithValuesCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="EditTranslationKeyWithValuesCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public EditTranslationKeyWithValuesCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(EditTranslationKeyWithValuesCommand request, CancellationToken cancellationToken)
            {
                var keyEntity = await this.context
                    .Keys
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

                if (keyEntity == null)
                {
                    throw new EntityNotFoundException("Translation key", request.Id);
                }

                keyEntity.Key = request.Key;
                this.context.Keys.Update(keyEntity);
                foreach (var translationValue in request.Values)
                {
                    await this.UpdateTranslationAsync(translationValue, cancellationToken);
                }

                await this.context.SaveChangesAsync(cancellationToken);

                return new SimpleResult(true);
            }

            private async Task UpdateTranslationAsync(TranslationKeyValue value, CancellationToken cancellationToken)
            {
                var translationEntity = await this.context
                    .Values
                    .FirstOrDefaultAsync(x => x.Id == value.Id, cancellationToken);

                if (translationEntity == null)
                {
                    throw new EntityNotFoundException("Translation value", value.Id);
                }

                translationEntity.Value = value.Value;

                this.context.Values.Update(translationEntity);
            }
        }
    }
}
