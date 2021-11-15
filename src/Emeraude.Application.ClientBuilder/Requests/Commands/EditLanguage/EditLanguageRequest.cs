using Emeraude.Application.Mapping;
using Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditLanguage
{
    /// <summary>
    /// Request for edit new language.
    /// </summary>
    public class EditLanguageRequest : IMapFrom<Language>
    {
        /// <inheritdoc cref="Language.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="Language.Code"/>
        public string Code { get; set; }

        /// <inheritdoc cref="Language.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Language.NativeName"/>
        public string NativeName { get; set; }
    }
}
