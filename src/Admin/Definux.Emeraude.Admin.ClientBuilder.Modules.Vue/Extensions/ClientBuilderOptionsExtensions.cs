using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.EmPages;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Routes;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.ServiceAgents;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.StaticContent;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.TranslationsResources;
using Definux.Emeraude.Admin.ClientBuilder.Options;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions
{
    public static class ClientBuilderOptionsExtensions
    {
        public static void AddDefaultVueModules(this ClientBuilderOptions options)
        {
            options.AddModule<VueServiceAgentsModule>();
            options.AddModule<VueEmPagesModule>();
            options.AddModule<VueRoutesModule>();
            options.AddModule<VueTranslationsResourcesModule>();
            options.AddModule<VueStaticContentModule>();
        }
    }
}
