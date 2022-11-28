using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// Representation of type in a way to represent a list of items or enumerations.
/// </summary>
public class EmTypeDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTypeDescription"/> class.
    /// </summary>
    public EmTypeDescription()
    {
        this.Items = new HashSet<EmTypeDescriptionItem>();
    }

    /// <summary>
    /// Name of the type.
    /// </summary>
    public string TypeId { get; set; }

    /// <summary>
    /// Collection of all possible items that are allowed.
    /// </summary>
    public ICollection<EmTypeDescriptionItem> Items { get; set; }
}