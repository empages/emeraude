using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.ClientBuilder.Requests.Commands.MakeLanguageDefault
{
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
                    .AsQueryable()
                    .ToListAsync(cancellationToken);

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
                    await this.context.SaveChangesAsync(cancellationToken);

                    return new SimpleResult(true);
                }

                return new SimpleResult(false);
            }
        }
    }
}
