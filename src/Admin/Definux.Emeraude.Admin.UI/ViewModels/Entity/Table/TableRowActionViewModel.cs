using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Utilities;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of a table row action.
    /// </summary>
    public class TableRowActionViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowActionViewModel"/> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <param name="urlStringFormat"></param>
        /// <param name="rawParameters"></param>
        /// <param name="method"></param>
        public TableRowActionViewModel(string title, string icon, string urlStringFormat, List<string> rawParameters, TableRowActionMethod method = TableRowActionMethod.Get)
        {
            this.Title = title;
            this.Icon = icon;
            this.UrlStringFormat = urlStringFormat;
            this.RawParameters = rawParameters;
            this.Method = method;
        }

        /// <summary>
        /// Title of the action.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// HTTP method of the action.
        /// </summary>
        public TableRowActionMethod Method { get; set; }

        /// <summary>
        /// Flag that shows or not a confirmation modal if the method is <see cref="TableRowActionMethod.Post"/>.
        /// </summary>
        public bool HasConfirmation { get; set; }

        /// <summary>
        /// Icon of the action button.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Title of the confirmation modal.
        /// </summary>
        public string ConfirmationTitle { get; set; }

        /// <summary>
        /// Message of the confirmation modal.
        /// </summary>
        public string ConfirmationMessage { get; set; }

        /// <summary>
        /// URL of the action.
        /// </summary>
        public string Url
        {
            get
            {
                return string.Format(this.UrlStringFormat, this.Parameters.ToArray());
            }
        }

        /// <summary>
        /// URL template with placeholders.
        /// </summary>
        public string UrlStringFormat { get; set; }

        /// <summary>
        /// Parameters for the URL template (<see cref="UrlStringFormat"/>) that can be hardcoded value (something-123) or property value ([SomeProperty]) where 'SomeProperty' is property of the target entity.
        /// </summary>
        public List<string> RawParameters { get; set; }

        /// <summary>
        /// Parameters for the URL template with their actual values (processed <see cref="RawParameters"/>).
        /// </summary>
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Method that set confirmation modal.
        /// </summary>
        /// <param name="confirmationTitle"></param>
        /// <param name="confirmationMessage"></param>
        public void SetConfirmation(string confirmationTitle, string confirmationMessage)
        {
            this.HasConfirmation = true;
            this.ConfirmationTitle = confirmationTitle;
            this.ConfirmationMessage = confirmationMessage;
        }
    }
}
