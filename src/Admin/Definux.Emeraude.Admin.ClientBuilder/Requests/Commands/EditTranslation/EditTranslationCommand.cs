using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Localization;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslation
{
    /// <summary>
    /// Command that edit translation value.
    /// </summary>
    public class EditTranslationCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the translation.
        /// </summary>
        public int TranslationId { get; set; }

        /// <summary>
        /// The new value of the translation.
        /// </summary>
        public string NewValue { get; set; }

        /// <inheritdoc/>
        public class EditTranslationCommandHandler : IRequestHandler<EditTranslationCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="EditTranslationCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public EditTranslationCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(EditTranslationCommand request, CancellationToken cancellationToken)
            {
                var translationEntity = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Id == request.TranslationId)
                    .FirstOrDefault();

                translationEntity.Value = request.NewValue;

                this.context.Values.Update(translationEntity);
                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
