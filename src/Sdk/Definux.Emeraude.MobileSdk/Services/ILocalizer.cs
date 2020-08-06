namespace Definux.Emeraude.MobileSdk.Services
{
    public interface ILocalizer
    {
        string GetTranslation(string key);

        string this[string key] { get; }
    }
}
