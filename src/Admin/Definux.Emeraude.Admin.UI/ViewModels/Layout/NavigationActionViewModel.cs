using System.Collections.Generic;
using System.Net.Http;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    /// <summary>
    /// View model that represents navigation action from the top bar of the administration panel.
    /// </summary>
    public class NavigationActionViewModel
    {
        /// <summary>
        /// Visualization name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Visualization icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Action URL.
        /// </summary>
        public string ActionUrl { get; set; }

        /// <summary>
        /// Represents a flag that indicates the URL be opened on separated page.
        /// </summary>
        public bool SeparatePage { get; set; }

        /// <summary>
        /// HTTP method of the action.
        /// </summary>
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        /// <summary>
        /// Parameters for the action.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Indicates that whether to be shown a confirmation popup.
        /// </summary>
        public bool HasConfirmation { get; set; }

        /// <summary>
        /// Confirmation popup title.
        /// </summary>
        public string ConfirmationTitle { get; set; }

        /// <summary>
        /// Confirmation popup message.
        /// </summary>
        public string ConfirmationMessage { get; set; }
    }
}
