using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Table
{
    public class TableRowActionViewModel
    {
        public TableRowActionViewModel(string title, string icon, string urlStringFormat, List<string> rawParameters, TableRowActionMethod method = TableRowActionMethod.Get)
        {
            Title = title;
            Icon = icon;
            UrlStringFormat = urlStringFormat;
            RawParameters = rawParameters;
            Method = method;

        }

        public string Title { get; set; }

        public TableRowActionMethod Method { get; set; }

        public bool HasConfirmation { get; set; }

        public string Icon { get; set; }

        public string ConfirmationTitle { get; set; }

        public string ConfirmationMessage { get; set; }

        public string Url
        {
            get
            {
                return string.Format(UrlStringFormat, Parameters.ToArray());
            }
        }

        public string UrlStringFormat { get; set; }

        public List<string> RawParameters { get; set; }

        public List<string> Parameters { get; set; }

        public void SetConfirmation(string confirmationTitle, string confirmationMessage)
        {
            HasConfirmation = true;
            ConfirmationTitle = confirmationTitle;
            ConfirmationMessage = confirmationMessage;
        }
    }

    public enum TableRowActionMethod
    {
        Get = 0,
        Post = 1
    }
}
