namespace Definux.Emeraude.Tests.Abstractions
{
    public class AntiForgeryTokenMeta
    {
        public string CookieName { get; set; }

        public string CookieValue { get; set; }

        public string InputName { get; set; }

        public string InputValue { get; set; }
    }
}