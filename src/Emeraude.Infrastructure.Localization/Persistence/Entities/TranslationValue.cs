namespace Emeraude.Infrastructure.Localization.Persistence.Entities
{
    /// <summary>
    /// Translation text based on translation key and language.
    /// </summary>
    public class TranslationValue
    {
        /// <summary>
        /// Id of the translation.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of the language of the translation.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Entity of the language of the translation.
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// Id of the key of the translation.
        /// </summary>
        public int TranslationKeyId { get; set; }

        /// <summary>
        /// Entity of the key of the translation.
        /// </summary>
        public TranslationKey TranslationKey { get; set; }

        /// <summary>
        /// Translation value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Normalized translation value.
        /// </summary>
        public string NormalizedValue { get; set; }
    }
}
