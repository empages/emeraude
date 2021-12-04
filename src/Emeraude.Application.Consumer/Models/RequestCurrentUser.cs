namespace Emeraude.Application.Consumer.Models;

/// <summary>
/// Encapsulated class that contains information about the identity user for the current request.
/// </summary>
public class RequestCurrentUser
{
    /// <summary>
    /// Flag that indicates whether user is authenticated or not.
    /// </summary>
    public bool IsAuthenticated { get; set; }

    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email address of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Array with the roles of the user.
    /// </summary>
    public string[] Roles { get; set; }
}