using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslation
{
    public class EditTranslationCommand : IRequest<SimpleResult>
    {
        public int TranslationId { get; set; }

        public string NewValue { get; set; }

        public class EditTranslationCommandHandler : IRequestHandler<EditTranslationCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public EditTranslationCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

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
