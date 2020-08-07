using System.Collections.Generic;
using System.Net.Http;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    public class NavigationActionViewModel
    {
        public string Name { get; set; }

        public string Icon { get; set; }

        public string ActionUrl { get; set; }

        public bool SeparatePage { get; set; }

        public HttpMethod Method { get; set; } = HttpMethod.Get;

        public Dictionary<string, string> Parameters { get; set; }

        public bool HasConfirmation { get; set; }

        public string ConfirmationTitle { get; set; }

        public string ConfirmationMessage { get; set; }
    }
}
