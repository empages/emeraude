using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Infrastructure.Localization.Persistence;
using Definux.Emeraude.Infrastructure.Localization.Persistence.Entities;
using Definux.Emeraude.Infrastructure.Localization.Services;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.ClientBuilder.Requests.Commands.CreateLanguage
{
    /// <summary>
    /// Command that create a language.
    /// </summary>
    public class CreateLanguageCommand : CreateLanguageRequest, IRequest<MutationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLanguageCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public CreateLanguageCommand(CreateLanguageRequest request)
        {
            this.Name = request.Name;
            this.NativeName = request.NativeName;
            this.Code = request.Code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLanguageCommand"/> class.
        /// </summary>
        public CreateLanguageCommand()
        {
        }

        /// <inheritdoc/>
        public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, MutationResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateLanguageCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public CreateLanguageCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<MutationResult> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
            {
                var language = this.mapper.Map<Language>(request);
                language.Code = language
                    .Code
                    .Trim()
                    .ToLowerInvariant();

                var keys = await this
                    .context
                    .Keys
                    .ToListAsync(cancellationToken);

                foreach (var key in keys)
                {
                    language.Translations.Add(new TranslationValue
                    {
                        TranslationKeyId = key.Id,
                    });
                }

                this.context.Languages.Add(language);
                await this.context.SaveChangesAsync(cancellationToken);

                return new MutationResult(language.Id.ToString());
            }
        }
    }
}
