namespace Definux.Emeraude.MobileSdk.Services
{
    public static class EmStaticServiceProvider
    {
        public static T GetService<T>()
        {
            return (T)Prism.PrismApplicationBase.Current.Container.Resolve(typeof(T));
        }
    }
}
