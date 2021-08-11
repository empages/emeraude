using System.Collections.Generic;

namespace Definux.Emeraude.ClientBuilder.ScaffoldModules
{
    /// <summary>
    /// Provider service for scaffold modules of Client Builder.
    /// </summary>
    public interface IScaffoldModulesProvider
    {
        /// <summary>
        /// List of all scaffold modules.
        /// </summary>
        List<ScaffoldModule> Modules { get; }

        /// <summary>
        /// List of all web scaffold modules.
        /// </summary>
        List<ScaffoldModule> WebModules { get; }

        /// <summary>
        /// List of all mobile scaffold modules.
        /// </summary>
        List<ScaffoldModule> MobileModules { get; }

        /// <summary>
        /// Get modules by parent module id.
        /// </summary>
        /// <param name="parentModuleId"></param>
        /// <returns></returns>
        List<ScaffoldModule> GetModulesByParentModuleId(string parentModuleId);

        /// <summary>
        /// Trigger specified module generation.
        /// </summary>
        /// <param name="moduleId"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        bool GenerateModule(string moduleId, out string errorMessage);
    }
}
