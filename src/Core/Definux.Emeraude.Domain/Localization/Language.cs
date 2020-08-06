using System.Collections.Generic;

namespace Definux.Emeraude.Domain.Localization
{
    public class Language
    {
        public Language()
        {
            Translations = new HashSet<TranslationValue>();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }

        public ICollection<TranslationValue> Translations { get; set; }

        public ICollection<StaticContent> StaticContentList { get; set; }

        public bool IsDefault { get; set; }
    }
}
