using System;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Definition of view rendering abstraction by using source data and predefined HTML builder.
    /// </summary>
    public interface IUIElement
    {
        /// <summary>
        /// Data source of the element.
        /// </summary>
        object DataSource { get; set; }

        /// <summary>
        /// Method that returns the HTML result.
        /// </summary>
        /// <returns></returns>
        IHtmlContent RenderHtmlString();

        /// <summary>
        /// Method which purpose is to be used for UI element HTML builder.
        /// </summary>
        void DefineHtmlBuilder();

        /// <summary>
        /// Method used for loading the application service provider (<see cref="IServiceProvider"/>).
        /// </summary>
        /// <param name="serviceProvider"></param>
        void LoadServiceProvider(IServiceProvider serviceProvider);
    }
}
