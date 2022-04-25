using Emeraude.Pages.Components.Mutators;

namespace Emeraude.Pages.Views;

/// <summary>
/// Form view item.
/// </summary>
public class EmFormViewItem : EmPageViewItem
{
    /// <summary>
    /// Flag that represents whether the item is required or not.
    /// </summary>
    public bool Required { get; set; }

    /// <inheritdoc/>
    public override EmComponent DefaultComponent => new TextMutator();
}