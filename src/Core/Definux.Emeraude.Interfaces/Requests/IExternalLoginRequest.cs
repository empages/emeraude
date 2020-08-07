namespace Definux.Emeraude.Interfaces.Requests
{
    public interface IExternalLoginRequest
    {
        string Provider { get; set; }

        string AccessToken { get; set; }
    }
}
