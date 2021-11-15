using Emeraude.Application.Mapping;
using Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKeys
{
    /// <summary>
    /// Result of static content key.
    /// </summary>
    public class StaticContentKeyResult : IMapFrom<ContentKey>
    {
        /// <inheritdoc cref="ContentKey.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="ContentKey.Key"/>
        public string Key { get; set; }
    }
}
