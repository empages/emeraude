using System;
using Emeraude.Infrastructure.FileStorage.Common;

namespace Emeraude.Infrastructure.FileStorage.Models;

/// <summary>
/// Encapsulated definition of system item.
/// </summary>
public class SystemItem
{
    /// <summary>
    /// Name of the item.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Type of the item.
    /// </summary>
    public FileSystemItemType Type { get; set; }

    /// <summary>
    /// Path of the item.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Relative path of the item.
    /// </summary>
    public string RelativePath { get; set; }

    /// <summary>
    /// File size of the item.
    /// </summary>
    public long FileSize { get; set; }

    /// <summary>
    /// Creation date of the item.
    /// </summary>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Last modification date of the item.
    /// </summary>
    public DateTime LastModifiedOn { get; set; }
}