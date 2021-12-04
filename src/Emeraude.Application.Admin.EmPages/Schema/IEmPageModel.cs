namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// Contract for EmPages models.
/// </summary>
public interface IEmPageModel
{
    /// <summary>
    /// Identifier of the entity.
    /// </summary>
    string Id { get; set; }
}