using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Key value pair definition that helps to be created custom data extraction for the purposes of UI element rendering.
    /// </summary>
    public interface ICustomEntityDataPair : IDictionary<Guid, string>
    {
    }
}
