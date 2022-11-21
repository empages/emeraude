using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using EmPages.Application.Common;
using EmPages.Identity;
using EmPages.Pages;
using EmPages.Pages.Extensions;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmPages.Application.Pages.Users;

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
            Type = PageActionType.Redirection,
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

    public override async Task<EmTablePageResult> FetchDataAsync(EmPageRequest request)
    {
        var searchText = request.GetParameter<string>("searchText");
        var pageSize = request.GetPaginationPageSize();
        var page = request.GetPaginationPageIndex();
        var skippedCount = (page - 1) * pageSize;
        var totalUsersCount = await this.identityService.CountUsersAsync(searchText);
        var users = await this.identityService.FetchUsersAsync(searchText, skippedCount, pageSize);

        return new EmTablePageResult
        {
            Models = users.Select(x => new UsersPageModel
            {
                Id = x.Id.ToString(),
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