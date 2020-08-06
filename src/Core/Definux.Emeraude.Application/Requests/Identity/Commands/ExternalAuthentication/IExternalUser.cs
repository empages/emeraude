namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    public interface IExternalUser
    {
        string Id { get; set; }

        string Name { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string EmailAddress { get; set; }

        string Provider { get; set; }

        string PictureUrl { get; }
    }
}
