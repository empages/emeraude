namespace Definux.Emeraude.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    /// <summary>
    /// Content key content for a specified language.
    /// </summary>
    public class NewContentKeyContent
    {
        /// <summary>
        /// Language id of the static content.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Content text of the static content.
        /// </summary>
        public string Content { get; set; }
    }
}
