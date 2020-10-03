using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// ViewModel used for the language switcher.
    /// </summary>
    public class LocalizerViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizerViewModel"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="localizer"></param>
        public LocalizerViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
        }
    }
}
