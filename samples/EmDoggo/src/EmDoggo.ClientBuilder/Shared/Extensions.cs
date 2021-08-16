using Definux.Emeraude.ClientBuilder.Options;

namespace EmDoggo.ClientBuilder.Shared
{
    public static class Extensions
    {
        public static string GetVueClientAppPath(this EmClientBuilderOptions options) => options.GetClientApplicationPath("VueClientApp");
    }
}