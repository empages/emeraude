using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using System;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions
{
    public abstract class VueScaffoldModule : ScaffoldModule
    {
        public VueScaffoldModule(string name, bool locked)
            : base(name, InstanceType.WebModule, locked)
        {
            Icon = Convert.ToBase64String(Resources.vuejs);
            ScaffoldTypeName = "Vue";
            ParentModuleId = "vue.scaffold.module";
        }
    }
}
