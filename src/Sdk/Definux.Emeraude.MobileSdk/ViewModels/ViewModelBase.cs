using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Resources;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        protected ISystemSettingsStore SystemSettingsStore { get; private set; }

        public ILocalizer Localizer { get; private set; }

        public ViewModelBase(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer)
        {
            NavigationService = navigationService;
            SystemSettingsStore = systemSettingsStore;
            SystemSettingsStore.LanguageChanged += OnLanguageChanged;
            Localizer = localizer;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        protected virtual void OnLanguageChanged(object sender, LanguageChangedEventArgs e)
        {
            RaisePropertyChanged(nameof(Localizer));
        }

        protected async Task DisplayAlert(string title, string message, string cancel)
        {
            await Prism.PrismApplicationBase.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        protected string GetTranslation(string key)
        {
            return this.Localizer.GetTranslation(key);
        }
    }
}
