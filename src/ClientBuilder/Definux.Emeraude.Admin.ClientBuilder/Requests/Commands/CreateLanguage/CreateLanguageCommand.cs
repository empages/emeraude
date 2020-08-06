using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateLanguage
{
    public class CreateLanguageCommand : CreateLanguageRequest, IRequest<CreatedResult>
    {
        public CreateLanguageCommand(CreateLanguageRequest request)
        {
            Name = request.Name;
            NativeName = request.NativeName;
            Code = request.Code;
        }

        public CreateLanguageCommand()
        {

        }

        public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, CreatedResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            public CreateLanguageCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<CreatedResult> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
            {
                var language = this.mapper.Map<Language>(request);
                var keys = await this.context.Keys.AsQueryable().ToListAsync();
                foreach (var key in keys)
                {
                    language.Translations.Add(new TranslationValue
                    {
                        TranslationKeyId = key.Id,
                    });
                }

                this.context.Languages.Add(language);
                await this.context.SaveChangesAsync();

                return new CreatedResult(language.Id);
            }
        }
    }

}
