using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateLanguage
{
    /// <summary>
    /// Request for create new language.
    /// </summary>
    public class CreateLanguageRequest : IMapFrom<Language>
    {
        /// <inheritdoc cref="Language.Code"/>
        public string Code { get; set; }

        /// <inheritdoc cref="Language.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Language.NativeName"/>
        public string NativeName { get; set; }
    }
}
