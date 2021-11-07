using System.Collections.Generic;
using Definux.Emeraude.Application.ClientBuilder.Shared;

namespace Definux.Emeraude.Application.ClientBuilder.ScaffoldModules
{
    /// <summary>
    /// Factory for scaffold modules of Client Builder.
    /// </summary>
    public interface IScaffoldModulesFactory
    {
        /// <summary>
        /// List of all scaffold modules.
        /// </summary>
        IList<ScaffoldModule> Modules { get; }

        /// <summary>
        /// Gets module by Id.
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        ScaffoldModule GetModule(string moduleId);

        /// <summary>
        /// Get modules by client id.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        IList<ScaffoldModule> GetModulesByClientId(string clientId);

        /// <summary>
        /// Get modules by instance type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IList<ScaffoldModule> GetModulesByInstance(InstanceType type);

        /// <summary>
        /// Trigger specified module generation.
        /// </summary>
        /// <param name="moduleId"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        bool GenerateModule(string moduleId, out string errorMessage);
    }
}
