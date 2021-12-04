namespace Emeraude.Infrastructure.FileStorage.Services;

/// <summary>
/// Service that builds paths for roots.
/// </summary>
public interface IRootsService
{
    /// <summary>
    /// Get public root directory.
    /// </summary>
    public string PublicRootDirectory { get; }

    /// <summary>
    /// Get private root directory.
    /// </summary>
    public string PrivateRootDirectory { get; }

    /// <summary>
    /// Get path from public root by path.
    /// </summary>
    /// <param name="paths"></param>
    /// <returns></returns>
    public string GetPathFromPublicRoot(params string[] paths);

    /// <summary>
    /// Get path from private root by path.
    /// </summary>
    /// <param name="paths"></param>
    /// <returns></returns>
    public string GetPathFromPrivateRoot(params string[] paths);
}