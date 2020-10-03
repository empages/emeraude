using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent
{
    /// <summary>
    /// Command that edit content key and its related static content items.
    /// </summary>
    public class EditContentKeyWithContentCommand : ContentKeyWithContentRequest, IRequest<SimpleResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditContentKeyWithContentCommand"/> class.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="request"></param>
        public EditContentKeyWithContentCommand(int keyId, ContentKeyWithContentRequest request)
        {
            this.KeyId = keyId;
            this.Key = request.Key;
            this.StaticContentList = request.StaticContentList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditContentKeyWithContentCommand"/> class.
        /// </summary>
        public EditContentKeyWithContentCommand()
        {
        }

        /// <summary>
        /// Id of the content key.
        /// </summary>
        public int KeyId { get; set; }

        /// <inheritdoc/>
        public class EditContentKeyWithContentCommandHandler : IRequestHandler<EditContentKeyWithContentCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="EditContentKeyWithContentCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public EditContentKeyWithContentCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(EditContentKeyWithContentCommand request, CancellationToken cancellationToken)
            {
                var keyToEdit = await this.context
                    .ContentKeys
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id == request.KeyId);

                this.mapper.Map(request, keyToEdit);

                keyToEdit.StaticContentList = null;
                this.context.ContentKeys.Update(keyToEdit);

                foreach (var staticContentListItem in request.StaticContentList)
                {
                    var currentContent = await this.context
                        .StaticContent
                        .FirstOrDefaultAsync(x => x.Id == staticContentListItem.Id);
                    this.mapper.Map(staticContentListItem, currentContent);
                    this.context.StaticContent.Update(currentContent);
                }

                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }
}
