using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Application.Admin.Models
{
    /// <summary>
    /// Model that defines a sidebar section.
    /// </summary>
    public class SidebarMenuSection
    {
        /// <summary>
        /// Title of the section.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Icon of the section.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// List of all sub-items of the section.
        /// </summary>
        public List<SidebarMenuLink> Children { get; set; }

        /// <summary>
        /// Flag that indicates whether the section has behavior of dropdown or not.
        /// </summary>
        public bool IsDropdown { get; set; }

        /// <summary>
        /// Computed flag that return true when there is just one sub-item in the section.
        /// </summary>
        public bool IsSingle => this.Children != null && this.Children.Count == 1;

        /// <summary>
        /// Computed property that return the single link item if the section is single.
        /// </summary>
        public SidebarMenuLink SingleLink => this.IsSingle ? this.Children.FirstOrDefault() : null;

        /// <summary>
        /// Flag that indicates the active state of the section for the current request.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
