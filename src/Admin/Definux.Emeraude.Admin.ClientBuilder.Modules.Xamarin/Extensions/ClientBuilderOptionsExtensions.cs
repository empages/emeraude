using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources;
using Definux.Emeraude.Admin.ClientBuilder.Options;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ClientBuilderOptions"/>.
    /// </summary>
    public static class ClientBuilderOptionsExtensions
    {
        /// <summary>
        /// Add default build-in Xamarin Client Builder modules.
        /// </summary>
        /// <param name="options"></param>
        public static void AddDefaultXamarinModules(this ClientBuilderOptions options)
        {
            options.AddModule<XamarinTranslationsResourcesModule>();
            options.AddModule<XamarinDataTransferObjectsModule>();
            options.AddModule<XamarinServiceAgentsModule>();
        }
    }
}
