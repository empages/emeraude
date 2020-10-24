using System.Collections.Generic;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent
{
    /// <summary>
    /// Request model of <see cref="EditContentKeyWithContentCommand"/>.
    /// </summary>
    public class ContentKeyWithContentRequest : IMapFrom<ContentKey>
    {
        /// <inheritdoc cref="ContentKey.Key"/>
        public string Key { get; set; }

        /// <summary>
        /// List of all static content keys with content implemented by <see cref="ContentKeyContent"/>.
        /// </summary>
        public IEnumerable<ContentKeyContent> StaticContentList { get; set; }
    }
}
