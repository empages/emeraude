using System.Collections.Generic;

namespace Definux.Emeraude.Locales.ServiceObjects
{
    public class TranslationsGridData
    {
        public TranslationsGridData()
        {
            Items = new List<TranslationsGridItem>();
        }

        public List<TranslationsGridItem> Items { get; set; }
    }

    public class TranslationsGridItem
    {
        public TranslationsGridItem()
        {
            LanguageValues = new List<TranslationsLanguageValue>();
        }

        public int KeyId { get; set; }

        public string Key { get; set; }

        public List<TranslationsLanguageValue> LanguageValues { get; set; }
    }

    public class TranslationsLanguageValue
    {
        public string LanguageCode { get; set; }

        public int Id { get; set; }

        public string Value { get; set; }
    }
}
