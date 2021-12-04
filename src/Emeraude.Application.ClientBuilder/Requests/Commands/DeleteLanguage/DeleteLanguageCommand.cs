using System.Threading;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.DeleteLanguage;

/// <summary>
/// Command that delete specified language and all resources related to it. If there other languages, the first selected will become default.
/// </summary>
public class DeleteLanguageCommand : IRequest<SimpleResult>
{
    /// <summary>
    /// Id of the language.
    /// </summary>
    public int LanguageId { get; set; }

    /// <inheritdoc/>
    public class CommandHandler : IRequestHandler<DeleteLanguageCommand, SimpleResult>
    {
        private readonly ILocalizationContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandHandler"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CommandHandler(ILocalizationContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public async Task<SimpleResult> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
        {
            var language = await this.context
                .Languages
                .FirstOrDefaultAsync(x => x.Id == request.LanguageId, cancellationToken);

            if (language == null)
            {
                throw new EntityNotFoundException("Language", request.LanguageId);
            }

            if (language.IsDefault)
            {
                var firstFoundLanguage = await this.context
                    .Languages
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id != request.LanguageId, cancellationToken);

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