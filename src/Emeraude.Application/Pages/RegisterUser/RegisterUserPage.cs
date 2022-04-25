using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Emeraude.Application.Common;
using Emeraude.Pages;
using Emeraude.Pages.Pages;
using Emeraude.Pages.Results;

namespace Emeraude.Application.Pages.RegisterUser;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
[EmRoute("/~/users/register")]
public class RegisterUserPage : EmFormPage<RegisterUserPageModel>
{
    public RegisterUserPage(IEmPagesOptions options)
        : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        this.Title = "Register User";
        this.Permissions.Add(ApplicationPermissions.IdentityManagement);
    }

    public override async Task<EmFormPageResult<RegisterUserPageModel>> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}