using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.SchemaModels;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Admin.Controllers.Api
{
    /// <summary>
    /// Api controller for providing data for users entities.
    /// </summary>
    public class AdminUsersDataController : AdminEntityDataController<User, UserAdminSchemaModel>
    {
    }
}