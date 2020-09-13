using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources;
using Definux.Emeraude.Admin.ClientBuilder.Options;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions
{
    public static class ClientBuilderOptionsExtensions
    {
        public static void AddDefaultXamarinModules(this ClientBuilderOptions options)
        {
            options.AddModule<XamarinTranslationsResourcesModule>();
            options.AddModule<XamarinDataTransferObjectsModule>();
            options.AddModule<XamarinServiceAgentsModule>();
        }
    }
}
