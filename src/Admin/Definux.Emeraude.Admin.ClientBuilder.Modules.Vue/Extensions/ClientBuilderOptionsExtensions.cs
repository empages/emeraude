using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesComponents;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesFolders;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesInitialStates;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Router;
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
            options.AddModule<VuePagesFoldersModule>();
            options.AddModule<VuePagesComponentsModule>();
            options.AddModule<VuePagesInitialStatesModule>();
            options.AddModule<VueRouterModule>();
            options.AddModule<VueTranslationsResourcesModule>();
            options.AddModule<VueStaticContentModule>();
        }
    }
}
