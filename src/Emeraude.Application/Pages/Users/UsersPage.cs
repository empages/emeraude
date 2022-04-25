using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Common;
using Emeraude.Identity;
using Emeraude.Pages;
using Emeraude.Pages.Pages;
using Emeraude.Pages.Results;

namespace Emeraude.Application.Pages.Users;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
[EmRoute("/~/users")]
public class UsersPage : EmTablePage<UsersPageModel>, IEmLayoutItem
{
    private readonly IEmIdentityService identityService;

    public UsersPage(
        IEmIdentityService identityService,
        IEmPagesOptions options)
        : base(options)
    {
        this.identityService = identityService;
    }

    public override async Task SetupAsync()
    {
        this.Title = "Identity";
        this.Permissions.Add(ApplicationPermissions.IdentityManagement);

        this.AddRowAction((model, _) => new EmAction
        {
            Title = "Assign Permissions",
            Order = 1,
            Type = PageActionType.Routing,
            Target = $"/~/users/{model.Id}/assign-permissions",
        });

        this.AddRowAction((_, _) => new EmAction
        {
            Title = "Delete",
            Order = 5,
            Type = PageActionType.Command,
            RequiresConfirmation = true,
            Target = nameof(UsersPageDeleteCommand),
        });
    }

    public override async Task<EmTablePageResult<UsersPageModel>> FetchDataAsync(EmPageRequest request)
    {
        var searchText = request.GetQueryParameter<string>("searchText");
        var pageSize = request.GetQueryParameter<int>("pageSize");
        var page = request.GetQueryParameter<int>("page");
        var skippedCount = (page - 1) * pageSize;
        var totalUsersCount = await this.identityService.CountUsersAsync(searchText);
        var users = await this.identityService.FetchUsersAsync(searchText, skippedCount, pageSize);

        return new EmTablePageResult<UsersPageModel>
        {
            Models = users.Select(x => new UsersPageModel
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                Email = x.Email,
                IsLockedOut = x.IsLockedOut,
                TwoFactorEnabled = x.TwoFactorEnabled,
            }),
            SkippedCount = skippedCount,
            TakenCount = pageSize,
            TotalCount = totalUsersCount,
        };
    }

    public EmLayoutContext BuildLayoutContext() =>
        new ()
        {
            Title = this.Title,
            Icon = "account-group",
            Order = int.MaxValue,
            Permissions = this.Permissions.ToList(),
        };
}