using System.Threading.Tasks;
using Definux.Emeraude.Interfaces.Services;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Mvvm;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// Abstract MVVM ViewModel that contains all needed services and methods.
    /// </summary>
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="localizer"></param>
        public ViewModelBase(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer)
        {
            this.NavigationService = navigationService;
            this.SystemSettingsStore = systemSettingsStore;
            this.SystemSettingsStore.LanguageChanged += this.OnLanguageChanged;
            this.Localizer = localizer;
        }

        /// <inheritdoc cref="INavigationService"/>
        protected INavigationService NavigationService { get; private set; }

        /// <inheritdoc cref="ISystemSettingsStore"/>
        protected ISystemSettingsStore SystemSettingsStore { get; private set; }

        /// <inheritdoc cref="ILocalizer"/>
        protected ILocalizer Localizer { get; private set; }

        /// <summary>
        /// Method triggered on initialization of the view model.
        /// </summary>
        /// <param name="parameters"></param>
        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        /// <summary>
        /// Method triggered on navigated from the view model.
        /// </summary>
        /// <param name="parameters"></param>
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        /// <summary>
        /// Method triggered on navigated to the view model.
        /// </summary>
        /// <param name="parameters"></param>
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        /// <summary>
        /// Method triggered on destroy of the view model.
        /// </summary>
        public virtual void Destroy()
        {
        }

        /// <summary>
        /// Method triggered when current language is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnLanguageChanged(object sender, LanguageChangedEventArgs e)
        {
            this.RaisePropertyChanged(nameof(this.Localizer));
        }

        /// <summary>
        /// Method that wrap current page display alert.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        protected async Task DisplayAlert(string title, string message, string cancel)
        {
            await Prism.PrismApplicationBase.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        /// <summary>
        /// Method that returns translation for specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected string GetTranslation(string key)
        {
            return this.Localizer.TranslateKey(key);
        }
    }
}
