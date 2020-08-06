namespace Definux.Emeraude.MobileSdk.Settings
{
    public class ApplicationLanguage
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }

        public bool IsDefault { get; set; }

        public override string ToString()
        {
            return Code;
        }
    }
}
