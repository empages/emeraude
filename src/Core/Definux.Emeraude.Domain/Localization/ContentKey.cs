using System.Collections.Generic;

namespace Definux.Emeraude.Domain.Localization
{
    public class ContentKey
    {
        public ContentKey()
        {
            StaticContentList = new HashSet<StaticContent>();
        }

        public int Id { get; set; }

        public string Key { get; set; }

        public ICollection<StaticContent> StaticContentList { get; set; }
    }
}
