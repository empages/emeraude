using Emeraude.Application.Mapping;
using Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditContentKeyWithContent
{
    /// <summary>
    /// Content of static content key.
    /// </summary>
    public class ContentKeyContent : IMapFrom<StaticContent>
    {
        /// <inheritdoc cref="StaticContent.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="StaticContent.LanguageId"/>
        public int LanguageId { get; set; }

        /// <inheritdoc cref="StaticContent.Content"/>
        public string Content { get; set; }
    }
}