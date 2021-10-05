using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="NavigationManager"/>.
    /// </summary>
    public static class NavigationManagerExtensions
    {
        /// <summary>
        /// Navigates to default Emeraude 404 page.
        /// </summary>
        /// <param name="navigationManager"></param>
        public static void NavigateToNotFoundPage(this NavigationManager navigationManager)
        {
            navigationManager.NavigateTo("/error/404", true, true);
        }
    }
}