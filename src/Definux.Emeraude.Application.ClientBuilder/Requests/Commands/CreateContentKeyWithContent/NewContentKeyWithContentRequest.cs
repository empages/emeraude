using System.Collections.Generic;

namespace Definux.Emeraude.Application.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    /// <summary>
    /// Request model of static content key with its related contents by languages.
    /// </summary>
    public class NewContentKeyWithContentRequest
    {
        /// <summary>
        /// Key of the static content.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// List of all static content items for each language implemented by <see cref="NewContentKeyContent"/>.
        /// </summary>
        public IEnumerable<NewContentKeyContent> StaticContentList { get; set; }
    }
}
