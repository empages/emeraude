using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Emeraude.Application.Common;
using Emeraude.Identity;
using Emeraude.Pages;
using Emeraude.Pages.Pages;
using Emeraude.Pages.Results;

namespace Emeraude.Application.Pages.AssignPermissions;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
[EmRoute("/~/users/{userId}/assign-permissions")]
public class AssignPermissionsPage : EmFormPage<AssignPermissionsPageModel>
{
    private readonly IEmIdentityService identityService;

    public AssignPermissionsPage(IEmIdentityService identityService, IEmPagesOptions options)
        : base(options)
    {
        this.identityService = identityService;
    }

    public override async Task SetupAsync()
    {
        this.Permissions.Add(ApplicationPermissions.IdentityManagement);
    }

    public override string ComputeTitle(AssignPermissionsPageModel model) =>
        $"Assign Permissions For {model.UserName}";

    public override async Task<EmFormPageResult<AssignPermissionsPageModel>> FetchDataAsync(EmPageRequest request)
    {
        var userId = request.GetRouteParameter<Guid>("userId");
        var user = await this.identityService.FindUserAsync(userId);

        return new EmFormPageResult<AssignPermissionsPageModel>
        {
            Model = new AssignPermissionsPageModel
            {
                Id = user.Id.ToString(),
                UserName = user.Name,
                UserEmail = user.Email,
                UserPermissions = user.Permissions,
            },
        };
    }
}