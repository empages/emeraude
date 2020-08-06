namespace Definux.Emeraude.Domain.Localization
{
    public class StaticContent
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int ContentKeyId { get; set; }

        public ContentKey ContentKey { get; set; }

        public string Content { get; set; }
    }
}
