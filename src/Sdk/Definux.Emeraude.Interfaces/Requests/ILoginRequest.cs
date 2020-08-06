namespace Definux.Emeraude.Interfaces.Requests
{
    public interface ILoginRequest
    {
        string Email { get; set; }

        string Password { get; set; }
    }
}
