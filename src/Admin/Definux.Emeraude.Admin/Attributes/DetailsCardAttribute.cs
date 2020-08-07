using System;

namespace Definux.Emeraude.Admin.Attributes
{
    public class DetailsCardAttribute : Attribute
    {
        public DetailsCardAttribute(int order, string title, Type uiElementType)
        {
            Order = order;
            Title = title;
            UIElementType = uiElementType;
        }

        public int Order { get; }

        public string Title { get; }

        /// <summary>
        /// UI element type which inherit Definux.Emeraude.Admin.UI.UIElements.DetailsCard.IDetailsCardElement
        /// </summary>
        public Type UIElementType { get; }
    }
}
