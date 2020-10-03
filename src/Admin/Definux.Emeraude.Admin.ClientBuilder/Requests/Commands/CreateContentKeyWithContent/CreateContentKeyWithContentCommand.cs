using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    /// <summary>
    /// Command that create a content key with its static contents for each language.
    /// </summary>
    public class CreateContentKeyWithContentCommand : NewContentKeyWithContentRequest, IRequest<CreatedResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContentKeyWithContentCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public CreateContentKeyWithContentCommand(NewContentKeyWithContentRequest request)
        {
            this.Key = request.Key;
            this.StaticContentList = request.StaticContentList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContentKeyWithContentCommand"/> class.
        /// </summary>
        public CreateContentKeyWithContentCommand()
        {
        }

        /// <inheritdoc/>
        public class CreateContentKeyWithValuesCommandHandler : IRequestHandler<CreateContentKeyWithContentCommand, CreatedResult>
        {
            private readonly ILocalizationContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateContentKeyWithValuesCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public CreateContentKeyWithValuesCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
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
                        Content = value.Content,
                    });
                }

                this.context.ContentKeys.Add(key);

                await this.context.SaveChangesAsync();

                return new CreatedResult(key.Id);
            }
        }
    }
}
