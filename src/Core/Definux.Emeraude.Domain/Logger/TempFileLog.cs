using Definux.Utilities.Enumerations;

namespace Definux.Emeraude.Domain.Logging
{
    public class TempFileLog : LoggerEntity
    {
        public string Name { get; set; }

        public string NameWithExtension
        {
            get
            {
                return $"{Name}.{FileExtension.ToString().Substring(1).ToLower()}";
            }
        }

        public string Path { get; set; }

        public FileTypes FileType { get; set; }

        public FileExtensions FileExtension { get; set; }

        public bool Applied { get; set; }
    }
}
