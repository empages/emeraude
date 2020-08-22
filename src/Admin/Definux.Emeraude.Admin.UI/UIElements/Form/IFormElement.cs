using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form
{
    public interface IFormElement : IUIElement
    {
        string Label { get; set; }

        string TargetProperty { get; set; }

        string VisibleKey { get; set; }

        object Value { get; set; }

        bool IsNullable { get; }

        bool Hidden { get; }
    }
}
