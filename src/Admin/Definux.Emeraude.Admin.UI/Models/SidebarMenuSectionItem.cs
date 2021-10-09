using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Model that defines sidebar section of the admin menu.
    /// </summary>
    public class SidebarMenuSectionItem
    {
        /// <summary>
        /// Event that is triggered when section's state changed.
        /// </summary>
        public event EventHandler StateChanged;

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
        public List<SidebarNavigationLinkItem> Children { get; set; }

        /// <summary>
        /// Flag that indicates whether the section has behavior of dropdown or not.
        /// </summary>
        public bool Dropdown { get; set; }

        /// <summary>
        /// Computed flag that return true when there is just one sub-item in the section.
        /// </summary>
        public bool IsSingle => this.Children != null && this.Children.Count == 1;

        /// <summary>
        /// Computed property that return the single link item if the section is single.
        /// </summary>
        public SidebarNavigationLinkItem SingleLinkItem => this.IsSingle ? this.Children.FirstOrDefault() : null;

        /// <summary>
        /// Flag that indicates the active state of the section for the current request.
        /// </summary>
        public bool IsActive => this.Children.Any(x => x.IsActive);

        /// <summary>
        /// Method that apply current route to the state of the section.
        /// </summary>
        /// <param name="currentRoute"></param>
        public virtual void BuildState(string currentRoute)
        {
            if (this.Children != null && this.Children.Count > 0)
            {
                foreach (var child in this.Children)
                {
                    child.BuildState(currentRoute);
                }

                if (this.Children.Count > 1)
                {
                    this.Dropdown = true;
                }

                this.OnStateChanged();
            }
        }

        /// <summary>
        /// <see cref="StateChanged"/> event invocator.
        /// </summary>
        protected virtual void OnStateChanged()
        {
            this.StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
