using System.IO;

namespace Emeraude.Infrastructure.FileStorage.Models;

/// <summary>
/// Result of the file for reading purposes.
/// </summary>
public class SystemFileResult
{
    /// <summary>
    /// File stream of the file.
    /// </summary>
    public Stream Stream { get; set; }

    /// <summary>
    /// Content type of the file.
    /// </summary>
    public string ContentType { get; set; }
}