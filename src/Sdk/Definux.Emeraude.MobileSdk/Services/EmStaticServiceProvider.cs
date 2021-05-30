namespace Definux.Emeraude.MobileSdk.Services
{
    /// <summary>
    /// Emeraude static service used for resolve a service from the services container.
    /// </summary>
    public static class EmStaticServiceProvider
    {
        /// <summary>
        /// Get a service from services container.
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            return (T)Prism.PrismApplicationBase.Current.Container.Resolve(typeof(T));
        }
    }
}
