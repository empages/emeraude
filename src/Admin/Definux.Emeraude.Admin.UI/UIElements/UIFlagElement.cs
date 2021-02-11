using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for flags.
    /// </summary>
    public abstract class UIFlagElement : UIElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIFlagElement"/> class.
        /// </summary>
        public UIFlagElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            bool castedDataSource = Convert.ToBoolean(this.DataSource);
            this.HtmlBuilder = new FlagHtmlBuilder(castedDataSource);
        }
    }
}
