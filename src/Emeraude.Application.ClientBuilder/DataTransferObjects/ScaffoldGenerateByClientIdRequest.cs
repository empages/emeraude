namespace Emeraude.Application.ClientBuilder.DataTransferObjects;

/// <summary>
/// Request for module generation.
/// </summary>
public class ScaffoldGenerateByClientIdRequest
{
    /// <summary>
    /// Target client Id.
    /// </summary>
    public string ClientId { get; set; }
}