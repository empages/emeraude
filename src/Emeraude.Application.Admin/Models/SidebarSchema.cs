using System.Collections.Generic;

namespace Emeraude.Application.Admin.Models
{
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
            this.EssentialLinks = new List<SidebarEssentialLink>();
        }

        /// <summary>
        /// List of all sidebar sections from the admin menu.
        /// </summary>
        public IList<SidebarMenuSection> Sections { get; set; }

        /// <summary>
        /// List of all insight items from the admin menu.
        /// </summary>
        public IList<SidebarEssentialLink> EssentialLinks { get; set; }
    }
}
