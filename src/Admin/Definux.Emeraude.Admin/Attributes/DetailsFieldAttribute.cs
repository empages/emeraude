using System;
using System.Runtime.CompilerServices;
using Definux.Emeraude.Admin.UI.UIElements.Details;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute used for rendering the details card of the details action of admin entity controller.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DetailsFieldAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="title"></param>
        /// <param name="uiElementType"></param>
        public DetailsFieldAttribute(int order, string title, Type uiElementType)
        {
            this.Order = order;
            this.Title = title;
            this.UIElementType = uiElementType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="uiElementType"></param>
        /// <param name="propertyName"></param>
        public DetailsFieldAttribute(int order, Type uiElementType, [CallerMemberName] string propertyName = "")
        {
            this.Order = order;
            this.Title = StringFunctions.SplitWordsByCapitalLetters(propertyName);
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
        /// UI element type that implemented <see cref="IDetailsFieldElement"/>.
        /// </summary>
        public Type UIElementType { get; }
    }
}
