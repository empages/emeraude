namespace Emeraude.Application.ClientBuilder.DataTransferObjects;

/// <summary>
/// Request for module generation.
/// </summary>
public class ScaffoldGenerateByIdRequest
{
    /// <summary>
    /// Target module Id.
    /// </summary>
    public string ModuleId { get; set; }
}