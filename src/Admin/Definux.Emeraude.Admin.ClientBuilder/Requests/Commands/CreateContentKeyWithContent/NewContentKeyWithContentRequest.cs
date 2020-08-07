using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateContentKeyWithContent
{
    public class NewContentKeyWithContentRequest
    {
        public string Key { get; set; }

        public IEnumerable<NewContentKeyContent> StaticContentList { get; set; }
    }

    public class NewContentKeyContent
    {
        public int LanguageId { get; set; }

        public string Content { get; set; }
    }
}
