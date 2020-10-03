using System;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute used for rendering the details card of the details action of admin entity controller.
    /// </summary>
    public class DetailsCardAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="title"></param>
        /// <param name="uiElementType"></param>
        public DetailsCardAttribute(int order, string title, Type uiElementType)
        {
            this.Order = order;
            this.Title = title;
            this.UIElementType = uiElementType;
        }

        /// <summary>
        /// Order of the rendered item.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Label of the rendered item.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// UI element type that implemented <see cref="IDetailsCardElement"/>.
        /// </summary>
        public Type UIElementType { get; }
    }
}
