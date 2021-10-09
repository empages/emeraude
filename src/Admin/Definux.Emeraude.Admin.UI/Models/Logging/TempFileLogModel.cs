using Definux.Utilities.Enumerations;

namespace Definux.Emeraude.Admin.UI.Models.Logging
{
    /// <summary>
    /// Model that encapsulate temp file log.
    /// </summary>
    public class TempFileLogModel : LogEntityModel
    {
        /// <summary>
        /// Name of the file (without extension).
        /// </summary>
        public string Name { get; set; }

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