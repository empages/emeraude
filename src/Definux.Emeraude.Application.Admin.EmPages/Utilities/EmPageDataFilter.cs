using System.Collections.Generic;
using System.Reflection;

namespace Definux.Emeraude.Application.Admin.EmPages.Utilities
{
    /// <summary>
    /// Utility that wraps property and value in single pair instance for the purposes of filtration.
    /// </summary>
    public class EmPageDataFilter : Dictionary<PropertyInfo, object>
    {
    }
}