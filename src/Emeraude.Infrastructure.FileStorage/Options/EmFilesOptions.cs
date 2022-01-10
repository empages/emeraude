using System.Collections.Generic;
using Emeraude.Configuration.Options;

namespace Emeraude.Infrastructure.FileStorage.Options;

/// <summary>
/// Options for files infrastructure of Emeraude.
/// </summary>
public class EmFilesOptions : IEmOptions
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmFilesOptions"/> class.
    /// </summary>
    public EmFilesOptions()
    {
        this.InitFolders = new List<string[]>();
    }

    /// <summary>
    /// Maximum allowed upload file size. The default value is 20971520 bytes (~20MB).
    /// </summary>
    public int MaxAllowedFileSize { get; set; } = 20971520;

    /// <summary>
    /// Maximum allowed upload image size. The default value is 10485760 bytes (~10MB).
    /// </summary>
    public int MaxAllowedImageFileSize { get; set; } = 10485760;

    /// <summary>
    /// List of all folders that must be initialized on the application start.
    /// </summary>
    public List<string[]> InitFolders { get; }

    /// <summary>
    /// Defines init folders by folder names only.
    /// </summary>
    /// <param name="folders"></param>
    public void AddInitFolders(params string[] folders) => this.InitFolders.Add(folders);

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public void Validate()
    {
    }
}