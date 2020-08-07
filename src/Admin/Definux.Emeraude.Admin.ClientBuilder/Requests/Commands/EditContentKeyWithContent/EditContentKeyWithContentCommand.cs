using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent
{
    public class EditContentKeyWithContentCommand : ContentKeyWithContentRequest, IRequest<SimpleResult>
    {
        public int KeyId { get; set; }

        public EditContentKeyWithContentCommand(int keyId, ContentKeyWithContentRequest request)
        {
            KeyId = keyId;

            Key = request.Key;
            StaticContentList = request.StaticContentList;
        }

        public EditContentKeyWithContentCommand()
        {

        }

        public class EditContentKeyWithContentCommandHandler : IRequestHandler<EditContentKeyWithContentCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public EditContentKeyWithContentCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

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
