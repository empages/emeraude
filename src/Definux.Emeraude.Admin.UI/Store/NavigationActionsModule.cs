using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Store
{
    /// <summary>
    /// Navigation actions store module.
    /// </summary>
    public class NavigationActionsModule : IStoreModule
    {
        /// <summary>
        /// Event handler that handle the change of navigation actions.
        /// </summary>
        public event EventHandler<NavigationActionsModuleEventArgs> NavigationActionsChanged;

        /// <summary>
        /// Apply navigation actions to the state;
        /// </summary>
        /// <param name="actionModels"></param>
        public void ApplyActions(IEnumerable<ActionModel> actionModels)
        {
            this.OnNavigationActionsChanged(new NavigationActionsModuleEventArgs(actionModels));
        }

        /// <summary>
        /// Reset navigation actions from the state.
        /// </summary>
        public void ResetActions()
        {
            this.OnNavigationActionsChanged(new NavigationActionsModuleEventArgs(new List<ActionModel>()));
        }

        /// <summary>
        /// Invokes <see cref="NavigationActionsChanged"/>.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnNavigationActionsChanged(NavigationActionsModuleEventArgs e)
        {
            this.NavigationActionsChanged?.Invoke(this, e);
        }
    }
}