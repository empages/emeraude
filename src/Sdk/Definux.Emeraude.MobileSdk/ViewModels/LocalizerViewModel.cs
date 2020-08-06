using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class LocalizerViewModel : ViewModelBase
    {
        public LocalizerViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
        }
    }
}
