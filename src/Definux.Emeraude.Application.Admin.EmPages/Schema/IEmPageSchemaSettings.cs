using System.Collections.Generic;
using System.Reflection;

namespace Definux.Emeraude.Application.Admin.EmPages.Schema
{
    /// <summary>
    /// Contract for EmPage schema settings.
    /// </summary>
    public interface IEmPageSchemaSettings
    {
        /// <summary>
        /// Operation where the settings are being transformed in unified format for proper usage.
        /// </summary>
        /// <param name="targetAssemblies"></param>
        /// <returns></returns>
        EmPageSchemaDescription BuildDescription(IEnumerable<Assembly> targetAssemblies);
    }
}