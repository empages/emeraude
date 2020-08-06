using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateKeyWithValues
{
    public class CreateKeyWithValuesCommand : NewKeyWithValuesRequest, IRequest<CreatedResult>
    {
        public CreateKeyWithValuesCommand(NewKeyWithValuesRequest request)
        {
            Key = request.Key;
            Values = request.Values;
        }

        public CreateKeyWithValuesCommand()
        {

        }

        public class CreateKeyWithValuesCommandHandler : IRequestHandler<CreateKeyWithValuesCommand, CreatedResult>
        {
            private readonly ILocalizationContext context;

            public CreateKeyWithValuesCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<CreatedResult> Handle(CreateKeyWithValuesCommand request, CancellationToken cancellationToken)
            {
                var key = new TranslationKey
                {
                    Key = request.Key,
                };

                foreach (var value in request.Values)
                {
                    key.Translations.Add(new TranslationValue
                    {
                        LanguageId = value.LanguageId,
                        Value = value.Value
                    });
                }

                this.context.Keys.Add(key);

                await this.context.SaveChangesAsync();

                return new CreatedResult(key.Id);
            }
        }
    }
}
