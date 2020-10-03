using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Helpers
{
    /// <summary>
    /// Dictionary definition that helps to be created custom data extraction for the purposes of UI element rendering.
    /// </summary>
    public interface IFormElementDatabaseView : IDictionary<Guid, string>
    {
    }
}
