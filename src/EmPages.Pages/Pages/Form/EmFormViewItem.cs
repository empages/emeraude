using EmPages.Pages.Components;
using EmPages.Pages.Components.Mutators;

namespace EmPages.Pages.Pages.Form;

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
    public override EmComponent DefaultComponent => new EmTextMutator();
}