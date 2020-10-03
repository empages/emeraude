using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <inheritdoc cref="IUIElement"/>
    public abstract class UIElement : IUIElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIElement"/> class.
        /// </summary>
        public UIElement()
        {
            this.HtmlBuilder = new HtmlBuilder.HtmlBuilder();
        }

        /// <inheritdoc/>
        public object DataSource { get; set; }

        /// <inheritdoc cref="IHtmlBuilder"/>
        protected IHtmlBuilder HtmlBuilder { get; set; }

        /// <inheritdoc cref="IServiceProvider"/>
        protected IServiceProvider ServiceProvider { get; set; }

        /// <inheritdoc/>
        public IHtmlContent RenderHtmlString()
        {
            if (this.HtmlBuilder != null)
            {
                try
                {
                    this.DefineHtmlBuilder();
                }
                catch (Exception)
                {
                    this.ShowError();
                }

                return new HtmlString(this.HtmlBuilder.RenderHtml());
            }
            else
            {
                throw new NotImplementedException(
                    $"The HTML Builder for {this.GetType().FullName} is not implemented. " +
                    $"Check whether you are using the base constructor of the inherit class.");
            }
        }

        /// <inheritdoc/>
        public void LoadServiceProvider(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        public abstract void DefineHtmlBuilder();

        /// <summary>
        /// Method that apply an error into HTML builder of the element.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ShowError(string message = "Invalid Property or Attribute definition.")
        {
            this.HtmlBuilder = new ErrorNotificationHtmlBuilder(message);
        }
    }
}
