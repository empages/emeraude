using System.IO;

namespace Definux.Emeraude.Application.Files
{
    /// <summary>
    /// Result of the file for reading purposes.
    /// </summary>
    public class SystemFileResult
    {
        /// <summary>
        /// File stream of the file.
        /// </summary>
        public FileStream Stream { get; set; }

        /// <summary>
        /// Content type of the file.
        /// </summary>
        public string ContentType { get; set; }
    }
}