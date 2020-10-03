using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent
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