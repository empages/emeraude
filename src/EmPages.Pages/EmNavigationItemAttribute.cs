using System;
using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// Decorates an EmPage in case the page must be used as layout item.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class EmNavigationItemAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmNavigationItemAttribute"/> class.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="title"></param>
    /// <param name="permissions"></param>
    public EmNavigationItemAttribute(
        int order,
        string title,
        params string[] permissions)
    {
        this.Order = order;
        this.Title = title;
        this.Permissions = permissions;
    }

    /// <summary>
    /// Order of the layout item that is represented by current context.
    /// </summary>
    public int Order { get; init; }

    /// <summary>
    /// Route of the layout item that is represented by current context.
    /// </summary>
    public string Route { get; init; }

    /// <summary>
    /// Title of the layout item that is represented by current context.
    /// </summary>
    public string Title { get; init; }

    /// <summary>
    /// Permissions of the layout item that will restrict visibility based on the user permissions.
    /// </summary>
    public IEnumerable<string> Permissions { get; init; }
}