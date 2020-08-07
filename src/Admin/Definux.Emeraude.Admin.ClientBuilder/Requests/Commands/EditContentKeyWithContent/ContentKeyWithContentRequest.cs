using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Domain.Localization;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent
{
    public class ContentKeyWithContentRequest : IMapFrom<ContentKey>
    {
        public string Key { get; set; }

        public IEnumerable<ContentKeyContent> StaticContentList { get; set; }
    }

    public class ContentKeyContent : IMapFrom<StaticContent>
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public string Content { get; set; }
    }
}
