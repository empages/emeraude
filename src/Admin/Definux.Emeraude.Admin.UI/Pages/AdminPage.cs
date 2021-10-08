using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Admin.UI.Store;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Definux.Emeraude.Admin.UI.Pages
{
    /// <summary>
    /// Abstract implementation of admin page.
    /// </summary>
    public abstract class AdminPage : ComponentBase, IDisposable
    {
        /// <inheritdoc cref="NavigationManager"/>
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        /// <inheritdoc cref="BreadcrumbsModule"/>
        [Inject]
        public BreadcrumbsModule BreadcrumbsModule { get; set; }

        /// <inheritdoc cref="NavigationActionsModule"/>
        [Inject]
        public NavigationActionsModule NavigationActionsModule { get; set; }

        /// <summary>
        /// Indicates whether the page is disposed or not.
        /// </summary>
        public bool Disposed { get; private set; }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.NavigationManager.LocationChanged -= this.OnLocationChanged;
            this.OnDestroy();
            this.Disposed = true;
        }

        /// <summary>
        /// Method that is called during page disposing.
        /// </summary>
        protected virtual void OnDestroy()
        {
        }

        /// <inheritdoc/>
        protected override async Task OnInitializedAsync()
        {
            this.NavigationManager.LocationChanged += this.OnLocationChanged;
            await base.OnInitializedAsync();
        }

        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            this.ReloadBreadcrumbs();
            this.ReloadNavigationActions();
        }

        /// <summary>
        /// Configure breadcrumbs for the current page.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<BreadcrumbItemModel> ConfigureBreadcrumbs()
        {
            return new List<BreadcrumbItemModel>();
        }

        /// <summary>
        /// Configure navigation actions for the current page.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<ActionModel> ConfigureNavigationActions()
        {
            return new List<ActionModel>();
        }

        /// <summary>
        /// Reload breadcrumbs in the state.
        /// </summary>
        protected void ReloadBreadcrumbs()
        {
            if (this.Disposed)
            {
                return;
            }

            var breadcrumbs = this.ConfigureBreadcrumbs()?.ToList();
            if (breadcrumbs != null && breadcrumbs.Any())
            {
                this.BreadcrumbsModule.ApplyBreadcrumbs(breadcrumbs);
            }
            else
            {
                this.BreadcrumbsModule.ResetBreadcrumbs();
            }
        }

        /// <summary>
        /// Reload navigation actions in the state.
        /// </summary>
        protected void ReloadNavigationActions()
        {
            if (this.Disposed)
            {
                return;
            }

            var navigationActions = this.ConfigureNavigationActions()?.ToList();
            if (navigationActions != null && navigationActions.Any())
            {
                this.NavigationActionsModule.ApplyActions(navigationActions);
            }
            else
            {
                this.NavigationActionsModule.ResetActions();
            }
        }

        /// <summary>
        /// Handler of navigation manager location changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
        }
    }
}