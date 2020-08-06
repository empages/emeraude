using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetLanguages
{
    public class LanguageResult : IMapFrom<Language>
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }

        public bool IsDefault { get; set; }
    }
}
