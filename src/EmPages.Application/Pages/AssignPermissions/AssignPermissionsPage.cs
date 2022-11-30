using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EmPages.Application.Common;
using EmPages.Identity;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Pages.Form;

namespace EmPages.Application.Pages.AssignPermissions;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
[EmRoute("/~/users/{userId}/assign-permissions")]
public class AssignPermissionsPage : EmFormPage<AssignPermissionsPageModel>
{
    private readonly IEmIdentityService identityService;

    public AssignPermissionsPage(IEmIdentityService identityService)
    {
        this.identityService = identityService;
    }

    public override async Task SetupAsync()
    {
        this.Permissions.Add(ApplicationPermissions.IdentityManagement);
    }

    public override string ComputeTitle(AssignPermissionsPageModel model) =>
        $"Assign Permissions For {model.UserEmail}";

    public override async Task<EmFormPageResult> FetchDataAsync(EmPageRequest request)
    {
        var userId = request.GetParameter<Guid>("userId");
        var user = await this.identityService.FindUserAsync(userId);

        return new EmFormPageResult
        {
            Model = new AssignPermissionsPageModel
            {
                Id = user.Id.ToString(),
                UserEmail = user.Email,
                UserPermissions = user.Permissions,
            },
        };
    }
}