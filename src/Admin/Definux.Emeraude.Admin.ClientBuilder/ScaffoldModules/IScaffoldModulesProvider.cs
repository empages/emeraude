using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules
{
    public interface IScaffoldModulesProvider
    {
        List<ScaffoldModule> Modules { get; }

        List<ScaffoldModule> WebModules { get; }

        List<ScaffoldModule> MobileModules { get; }

        List<ScaffoldModule> GetModulesByParentModuleId(string parentModuleId);

        bool GenerateModule(string moduleId, out string errorMessage);
    }
}
