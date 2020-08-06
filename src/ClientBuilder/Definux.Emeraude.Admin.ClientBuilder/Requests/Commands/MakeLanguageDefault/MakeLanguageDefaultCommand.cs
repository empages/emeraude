using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.MakeLanguageDefault
{
    public class MakeLanguageDefaultCommand : IRequest<SimpleResult>
    {
        public int LanguageId { get; set; }

        public class MakeLanguageDefaultCommandHandler : IRequestHandler<MakeLanguageDefaultCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public MakeLanguageDefaultCommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<SimpleResult> Handle(MakeLanguageDefaultCommand request, CancellationToken cancellationToken)
            {
                var languages = await this.context
                    .Languages
                    .AsQueryable()
                    .ToListAsync();

                foreach (var language in languages)
                {
                    language.IsDefault = false;
                    if (language.Id == request.LanguageId)
                    {
                        language.IsDefault = true;
                    }
                }

                if (languages.Any(x => x.IsDefault))
                {
                    this.context.Languages.UpdateRange(languages);
                    await this.context.SaveChangesAsync();

                    return new SimpleResult(true);
                }

                return new SimpleResult(false);
            }
        }
    }

}
