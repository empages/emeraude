using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslationKey
{
    public class EditTranslationKeyCommand : IRequest<SimpleResult>
    {
        public int KeyId { get; set; }

        public string NewValue { get; set; }

        public class EditTranslationKeyCommandHandler : IRequestHandler<EditTranslationKeyCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public EditTranslationKeyCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

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
