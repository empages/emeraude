using Emeraude.Essentials.Helpers;

namespace Emeraude.Essentials.Models;

/// <summary>
/// Implementation of enumeration that describe the enumeration item with its name and value, and helper key.
/// </summary>
public class EnumValueItem
{
    /// <summary>
    /// Name of the enumeration item.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Original name of the enumeration item.
    /// </summary>
    public string OriginalName { get; set; }

    /// <summary>
    /// Value of the enumeration item.
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// The additional key of the enumeration item.
    /// </summary>
    public string Key { get; set; }
}