using Definux.Utilities.Enumerations;

namespace Definux.Emeraude.Domain.Logging
{
    /// <summary>
    /// Log that represent uploaded files - mainly the temp files.
    /// </summary>
    public class TempFileLog : LoggerEntity
    {
        /// <summary>
        /// Name of the file (without extension).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the file with its extension.
        /// </summary>
        public string NameWithExtension => $"{this.Name}.{this.FileExtension.ToString().Substring(1).ToLower()}";

        /// <summary>
        /// Relative path of the file.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Type of the file.
        /// </summary>
        public FileTypes FileType { get; set; }

        /// <summary>
        /// Extension type of the file.
        /// </summary>
        public FileExtensions FileExtension { get; set; }

        /// <summary>
        /// Flag that indicates whether the file is applied or it is just a temp file and it is not already used.
        /// </summary>
        public bool Applied { get; set; }
    }
}
