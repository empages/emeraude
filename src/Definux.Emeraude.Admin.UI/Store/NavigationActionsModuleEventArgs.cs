using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Store
{
    /// <summary>
    /// Navigation actions module event args built on page change.
    /// </summary>
    public class NavigationActionsModuleEventArgs : EventArgs
    {
        private readonly IEnumerable<ActionModel> navigationActions;

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationActionsModuleEventArgs"/> class.
        /// </summary>
        /// <param name="navigationActions"></param>
        public NavigationActionsModuleEventArgs(IEnumerable<ActionModel> navigationActions)
        {
            this.navigationActions = navigationActions;
        }

        /// <summary>
        /// Navigation actions of the current page.
        /// </summary>
        public IReadOnlyList<ActionModel> NavigationActions => this.navigationActions?.ToList();
    }
}