using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Html;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public abstract class UIElement : IUIElement
    {
        public UIElement()
        {
            HtmlBuilder = new HtmlBuilder.HtmlBuilder();
        }

        public object DataSource { get; set; }

        protected IHtmlBuilder HtmlBuilder { get; set; }

        protected IServiceProvider ServiceProvider { get; set; }

        public IHtmlContent RenderHtmlString()
        {
            if (HtmlBuilder != null)
            {
                try
                {
                    DefineHtmlBuilder();
                }
                catch (Exception)
                {
                    ShowError();
                }
                
                return new HtmlString(HtmlBuilder.RenderHtml());
            }
            else
            {
                throw new NotImplementedException(
                    $"The HTML Builder for {this.GetType().FullName} is not implemented. " +
                    $"Check whether you are using the base constructor of the inherit class.");
            }
        }

        public void LoadServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public abstract void DefineHtmlBuilder();

        protected virtual void ShowError(string message = "Invalid Property or Attribute definition.")
        {
            HtmlBuilder = new ErrorNotificationHtmlBuilder(message);
        }
    }
}
