using System;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions
{
    /// <summary>
    /// Abstract Xamarin module for generation of files supporting Xamarin applications.
    /// </summary>
    public abstract class XamarinScaffoldModule : ScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinScaffoldModule"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="locked"></param>
        public XamarinScaffoldModule(string name, bool locked)
            : base(name, InstanceType.MobileModule, locked)
        {
            this.Icon = Convert.ToBase64String(Resources.xamarin);
            this.ScaffoldTypeName = "Xamarin";
            this.ParentModuleId = "xamarin.scaffold.module";
        }
    }
}
