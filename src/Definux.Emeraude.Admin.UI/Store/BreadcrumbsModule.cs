using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Store
{
    /// <summary>
    /// Breadcrumbs store module.
    /// </summary>
    public class BreadcrumbsModule : IStoreModule
    {
        /// <summary>
        /// Event handler that handle the change of breadcrumbs.
        /// </summary>
        public event EventHandler<BreadcrumbsModuleEventArgs> BreadcrumbsChanged;

        /// <summary>
        /// Apply breadcrumbs to the state;
        /// </summary>
        /// <param name="breadcrumbs"></param>
        public void ApplyBreadcrumbs(IEnumerable<BreadcrumbItemModel> breadcrumbs)
        {
            this.OnBreadcrumbsChanged(new BreadcrumbsModuleEventArgs(breadcrumbs));
        }

        /// <summary>
        /// Reset breadcrumbs from the state.
        /// </summary>
        public void ResetBreadcrumbs()
        {
            this.OnBreadcrumbsChanged(new BreadcrumbsModuleEventArgs(new List<BreadcrumbItemModel>()));
        }

        /// <summary>
        /// Invokes <see cref="BreadcrumbsChanged"/>.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnBreadcrumbsChanged(BreadcrumbsModuleEventArgs e)
        {
            this.BreadcrumbsChanged?.Invoke(this, e);
        }
    }
}