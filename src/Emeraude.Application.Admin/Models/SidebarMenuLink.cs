using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Application.Admin.Models;

/// <summary>
/// Model that defines sidebar link part of the sidebar section <see cref="SidebarMenuSection"/>.
/// </summary>
public class SidebarMenuLink
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SidebarMenuLink"/> class.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="routes"></param>
    public SidebarMenuLink(string title, params string[] routes)
    {
        this.Title = title;
        this.Routes = routes.ToList();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SidebarMenuLink"/> class.
    /// </summary>
    public SidebarMenuLink()
    {
    }

    /// <summary>
    /// Title of the link item.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Route of the link item.
    /// </summary>
    public List<string> Routes { get; set; }

    /// <summary>
    /// Default route of the link item.
    /// </summary>
    public string DefaultRoute => this.Routes?.FirstOrDefault() ?? "#";

    /// <summary>
    /// Flag that indicates the active state of the link item.
    /// </summary>
    public bool IsActive { get; protected set; }
}