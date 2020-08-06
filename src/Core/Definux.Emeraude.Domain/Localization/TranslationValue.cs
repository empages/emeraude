namespace Definux.Emeraude.Domain.Localization
{
    public class TranslationValue
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int TranslationKeyId { get; set; }

        public TranslationKey TranslationKey { get; set; }

        public string Value { get; set; }
    }
}
