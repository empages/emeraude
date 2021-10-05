namespace Definux.Emeraude.Domain.Localization
{
    /// <summary>
    /// Static content for a key and language.
    /// </summary>
    public class StaticContent
    {
        /// <summary>
        /// Id of the static content.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of the language of the static content.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Entity of the language of the static content.
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// Id of the key of the static content.
        /// </summary>
        public int ContentKeyId { get; set; }

        /// <summary>
        /// Entity of the key of the static content.
        /// </summary>
        public ContentKey ContentKey { get; set; }

        /// <summary>
        /// Static content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Normalized static content.
        /// </summary>
        public string NormalizedContent { get; set; }
    }
}
