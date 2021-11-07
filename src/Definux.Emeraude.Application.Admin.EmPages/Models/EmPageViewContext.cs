using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Main context of EmPage view.
    /// </summary>
    public class EmPageViewContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageViewContext"/> class.
        /// </summary>
        public EmPageViewContext()
        {
            this.NavbarActions = new List<ActionModel>();
            this.Breadcrumbs = new List<BreadcrumbItemModel>();
        }

        /// <summary>
        /// Route of the EmPage.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Title of the EmPage.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Actions placed in the navbar.
        /// </summary>
        public IList<ActionModel> NavbarActions { get; }

        /// <summary>
        /// Breadcrumbs list.
        /// </summary>
        public IList<BreadcrumbItemModel> Breadcrumbs { get; set; }
    }
}