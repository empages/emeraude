using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteLanguage
{
    public class DeleteLanguageCommand : IRequest<SimpleResult>
    {
        public int LanguageId { get; set; }

        public class CommandHandler : IRequestHandler<DeleteLanguageCommand, SimpleResult>
        {
            private readonly ILocalizationContext context;

            public CommandHandler(ILocalizationContext context)
            {
                this.context = context;
            }

            public async Task<SimpleResult> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
            {
                var language = await this.context
                        .Languages
                        .AsQueryable()
                        .FirstOrDefaultAsync(x => x.Id == request.LanguageId);

                if (language.IsDefault)
                {
                    var firstFoundLanguage = await this.context
                        .Languages
                        .AsQueryable()
                        .FirstOrDefaultAsync(x => x.Id != request.LanguageId);

                    if (firstFoundLanguage != null)
                    {
                        firstFoundLanguage.IsDefault = true;
                        this.context.Languages.Update(firstFoundLanguage);
                    }
                }

                this.context.Languages.Remove(language);

                await this.context.SaveChangesAsync();

                return new SimpleResult(true);
            }
        }
    }

}
