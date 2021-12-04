using System;

namespace Emeraude.Essentials.Attributes;

/// <summary>
/// Attribute that add additional name information to enumeration.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class EnumNameAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EnumNameAttribute"/> class.
    /// </summary>
    /// <param name="key"></param>
    public EnumNameAttribute(string key)
    {
        this.Name = key;
    }

    /// <summary>
    /// Name of the enumeration.
    /// </summary>
    public string Name { get; }
}