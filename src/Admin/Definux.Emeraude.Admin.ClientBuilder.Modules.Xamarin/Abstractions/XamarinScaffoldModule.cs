using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using System;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions
{
    public abstract class XamarinScaffoldModule : ScaffoldModule
    {
        public XamarinScaffoldModule(string name, bool locked)
            : base(name, InstanceType.MobileModule, locked)
        {
            Icon = Convert.ToBase64String(Resources.xamarin);
            ScaffoldTypeName = "Xamarin";
            ParentModuleId = "xamarin.scaffold.module";
        }
    }
}
