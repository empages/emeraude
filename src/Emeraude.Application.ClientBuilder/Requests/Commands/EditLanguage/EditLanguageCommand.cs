using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditLanguage
{
    /// <summary>
    /// Command that edit a language.
    /// </summary>
    public class EditLanguageCommand : EditLanguageRequest, IRequest<MutationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditLanguageCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public EditLanguageCommand(EditLanguageRequest request)
        {
            this.Id = request.Id;
            this.Name = request.Name;
            this.NativeName = request.NativeName;
            this.Code = request.Code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditLanguageCommand"/> class.
        /// </summary>
        public EditLanguageCommand()
        {
        }

        /// <inheritdoc/>
        public class EditLanguageCommandHandler : IRequestHandler<EditLanguageCommand, MutationResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="EditLanguageCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public EditLanguageCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<MutationResult> Handle(EditLanguageCommand request, CancellationToken cancellationToken)
            {
                var currentLanguageEntity = await this.context.Languages.FindAsync(request.Id);
                if (currentLanguageEntity == null)
                {
                    throw new EntityNotFoundException("Language", request.Id);
                }

                this.mapper.Map(request, currentLanguageEntity);

                this.context.Languages.Update(currentLanguageEntity);
                await this.context.SaveChangesAsync(cancellationToken);

                return new MutationResult(currentLanguageEntity.Id.ToString());
            }
        }
    }
}
