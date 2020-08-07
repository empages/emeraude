using Microsoft.AspNetCore.Html;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public interface IUIElement
    {
        object DataSource { get; set; }

        IHtmlContent RenderHtmlString();

        void DefineHtmlBuilder();

        void LoadServiceProvider(IServiceProvider serviceProvider);
    }
}
