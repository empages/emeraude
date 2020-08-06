using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateLanguage
{
    public class CreateLanguageRequest : IMapFrom<Language>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }
    }
}
