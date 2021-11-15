using Emeraude.Application.Mapping;
using Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKey
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
