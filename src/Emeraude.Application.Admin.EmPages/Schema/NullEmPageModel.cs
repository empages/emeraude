namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// EmPage model defined to be used for custom views without any model relation.
/// </summary>
public sealed class NullEmPageModel : IEmPageModel
{
    /// <inheritdoc/>
    public string Id { get; set; }
}