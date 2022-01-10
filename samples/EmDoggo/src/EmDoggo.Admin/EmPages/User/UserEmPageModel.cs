using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Mapping;

namespace EmDoggo.Admin.EmPages.User;

public class UserEmPageModel : IEmPageModel, IMapFrom<Emeraude.Infrastructure.Identity.Entities.User>
{
    public string Id { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public object RegistrationDate { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public bool IsLockedOut { get; set; }

    public bool EmailConfirmed { get; set; }
}