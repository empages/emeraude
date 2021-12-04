using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Localization.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.MakeLanguageDefault;

/// <summary>
/// Command that make specified language a default one.
/// </summary>
public class MakeLanguageDefaultCommand : IRequest<SimpleResult>
{
    /// <summary>
    /// Id of the language.
    /// </summary>
    public int LanguageId { get; set; }

    /// <inheritdoc/>
    public class MakeLanguageDefaultCommandHandler : IRequestHandler<MakeLanguageDefaultCommand, SimpleResult>
    {
        private readonly ILocalizationContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeLanguageDefaultCommandHandler"/> class.
        /// </summary>
        /// <param name="context"></param>
        public MakeLanguageDefaultCommandHandler(ILocalizationContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public async Task<SimpleResult> Handle(MakeLanguageDefaultCommand request, CancellationToken cancellationToken)
        {
            var languages = await this.context
                .Languages
                .ToListAsync(cancellationToken);

            foreach (var language in languages)
            {
                language.IsDefault = language.Id == request.LanguageId;
            }

            if (!languages.Any(x => x.IsDefault))
            {
                return SimpleResult.UnsuccessfulResult;
            }

            this.context.Languages.UpdateRange(languages);
            await this.context.SaveChangesAsync(cancellationToken);

            return SimpleResult.SuccessfulResult;
        }
    }
}