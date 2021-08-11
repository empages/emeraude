using System.Collections.Generic;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.ClientBuilder.Requests.Queries.GetStaticContentKey
{
    /// <summary>
    /// Result of static content key with its related contents - result of <see cref="GetStaticContentKeyQuery"/>.
    /// </summary>
    public class StaticContentKeyResult : IMapFrom<ContentKey>
    {
        /// <inheritdoc cref="ContentKey.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="ContentKey.Key"/>
        public string Key { get; set; }

        /// <summary>
        /// List of all static content keys with content implemented by <see cref="ContentKeyContentResult"/>.
        /// </summary>
        public IEnumerable<ContentKeyContentResult> StaticContentList { get; set; }
    }
}
