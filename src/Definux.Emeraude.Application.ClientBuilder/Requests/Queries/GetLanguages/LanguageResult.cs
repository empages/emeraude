using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Definux.Emeraude.Application.ClientBuilder.Requests.Queries.GetLanguages
{
    /// <summary>
    /// Result of get languages query.
    /// </summary>
    public class LanguageResult : IMapFrom<Language>
    {
        /// <inheritdoc cref="Language.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="Language.Code"/>
        public string Code { get; set; }

        /// <inheritdoc cref="Language.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Language.NativeName"/>
        public string NativeName { get; set; }

        /// <inheritdoc cref="Language.IsDefault"/>
        public bool IsDefault { get; set; }
    }
}
