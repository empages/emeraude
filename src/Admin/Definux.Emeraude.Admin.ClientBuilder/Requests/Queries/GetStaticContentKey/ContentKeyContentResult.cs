using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKey
{
    /// <summary>
    /// Result of static content key with content.
    /// </summary>
    public class ContentKeyContentResult : IMapFrom<StaticContent>
    {
        /// <inheritdoc cref="StaticContent.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="StaticContent.LanguageId"/>
        public int LanguageId { get; set; }

        /// <inheritdoc cref="StaticContent.Content"/>
        public string Content { get; set; }
    }
}
