using Definux.Emeraude.MobileSdk.ServiceAgents;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Settings;
using Definux.Emeraude.MobileSdk.Stores;
using Definux.Emeraude.MobileSdk.ViewModels;
using Prism.Ioc;
using System;
using System.Resources;
using Xamarin.Forms;

namespace Definux.Emeraude.MobileSdk.Extensions
{
    public static class ContainerRegistryExtensions
    {
        public static IContainerRegistry RegisterEmeraudeCore(this IContainerRegistry containerRegistry, Action<EmeraudeMobileSettings> settingsAction = null)
        {
            var settings = new EmeraudeMobileSettings();
            if (settingsAction != null)
            {
                settingsAction.Invoke(settings);
            }
            else
            {
                throw new ArgumentNullException("Emeraude mobile settings are not defined.");
            }

            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterInstance<ISettingsProvider>(settings);

            containerRegistry.RegisterSingleton<IRequestHeaderHelper, RequestHeaderHelper>();
            containerRegistry.RegisterSingleton<IHttpClientFactory, HttpClientFactory>();

            containerRegistry.RegisterSingleton<IAuthenticationServiceAgent, AuthenticationServiceAgent>();
            containerRegistry.RegisterSingleton<ILoggingServiceAgent, LoggingServiceAgent>();

            containerRegistry.RegisterSingleton<ISystemSettingsStore, SystemSettingsStore>();
            containerRegistry.RegisterSingleton<IAuthenticationStore, AuthenticationStore>();
            containerRegistry.RegisterSingleton<ILoggingStore, LoggingStore>();

            return containerRegistry;
        }

        public static IContainerRegistry RegisterEmeraudeLocalizer(this IContainerRegistry containerRegistry, ResourceManager resourceManager, ISystemSettingsStore systemSettingsStore)
        {
            containerRegistry.RegisterInstance<ILocalizer>(new Localizer(resourceManager, systemSettingsStore));
            containerRegistry.RegisterSingleton<LocalizerViewModel>();
            return containerRegistry;
        }
    }
}
