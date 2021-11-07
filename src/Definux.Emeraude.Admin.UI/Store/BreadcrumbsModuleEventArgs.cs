using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Store
{
    /// <summary>
    /// Breadcrumbs module event args built on page change.
    /// </summary>
    public class BreadcrumbsModuleEventArgs : EventArgs
    {
        private readonly IEnumerable<BreadcrumbItemModel> breadcrumbs;

        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbsModuleEventArgs"/> class.
        /// </summary>
        /// <param name="breadcrumbs"></param>
        public BreadcrumbsModuleEventArgs(IEnumerable<BreadcrumbItemModel> breadcrumbs)
        {
            this.breadcrumbs = breadcrumbs;
        }

        /// <summary>
        /// Breadcrumbs of the current page.
        /// </summary>
        public IReadOnlyList<BreadcrumbItemModel> Breadcrumbs => this.breadcrumbs?.ToList();
    }
}