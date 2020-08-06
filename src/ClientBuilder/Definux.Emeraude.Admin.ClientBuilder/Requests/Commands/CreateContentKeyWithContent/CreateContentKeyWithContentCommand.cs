using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    public class CreateContentKeyWithContentCommand : NewContentKeyWithContentRequest, IRequest<CreatedResult>
    {
        public CreateContentKeyWithContentCommand(NewContentKeyWithContentRequest request)
        {
            Key = request.Key;
            StaticContentList = request.StaticContentList;
        }

        public CreateContentKeyWithContentCommand()
        {

        }

        public class CreateContentKeyWithValuesCommandHandler : IRequestHandler<CreateContentKeyWithContentCommand, CreatedResult>
        {
            private readonly ILocalizationContext context;

            public CreateContentKeyWithValuesCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<CreatedResult> Handle(CreateContentKeyWithContentCommand request, CancellationToken cancellationToken)
            {
                var key = new ContentKey
                {
                    Key = request.Key,
                };

                foreach (var value in request.StaticContentList)
                {
                    key.StaticContentList.Add(new StaticContent
                    {
                        LanguageId = value.LanguageId,
                        Content = value.Content
                    });
                }

                this.context.ContentKeys.Add(key);

                await this.context.SaveChangesAsync();

                return new CreatedResult(key.Id);
            }
        }
    }
}
