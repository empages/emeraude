using System.Collections.Generic;

namespace Emeraude.Application.Admin.Models;

/// <summary>
/// Model that defines the sidebar schema.
/// </summary>
public class SidebarSchema
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SidebarSchema"/> class.
    /// </summary>
    public SidebarSchema()
    {
        this.Sections = new List<SidebarMenuSection>();
        this.ShortcutsLinks = new List<SidebarShortcutLink>();
    }

    /// <summary>
    /// List of all sidebar sections from the admin menu.
    /// </summary>
    public IList<SidebarMenuSection> Sections { get; set; }

    /// <summary>
    /// List of all shortcuts from the admin menu.
    /// </summary>
    public IList<SidebarShortcutLink> ShortcutsLinks { get; set; }
}