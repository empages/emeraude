using System.Collections.Generic;

namespace Definux.Emeraude.Domain.Localization
{
    public class TranslationKey
    {
        public TranslationKey()
        {
            Translations = new HashSet<TranslationValue>();
        }

        public int Id { get; set; }

        public string Key { get; set; }

        public ICollection<TranslationValue> Translations { get; set; }
    }
}
