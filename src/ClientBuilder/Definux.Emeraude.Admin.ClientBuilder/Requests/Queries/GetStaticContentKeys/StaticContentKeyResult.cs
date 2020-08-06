using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Domain.Localization;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKeys
{
    public class StaticContentKeyResult : IMapFrom<ContentKey>
    {
        public int Id { get; set; }

        public string Key { get; set; }
    }
}
