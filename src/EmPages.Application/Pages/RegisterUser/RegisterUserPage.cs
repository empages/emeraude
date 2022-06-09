using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EmPages.Application.Common;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmPages.Application.Pages.RegisterUser;

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