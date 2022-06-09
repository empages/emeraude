using System;
using EmPages.Application.Pages.AssignPermissions;
using EmPages.Application.Pages.RegisterUser;
using EmPages.Application.Pages.Users;
using EmPages.Pages;
using Essentials.Extensions;
using FluentAssertions;
using Xunit;

namespace EmPages.Application.Tests;

public class PagesTests
{
    [InlineData(typeof(UsersPage), "/~/users")]
    [InlineData(typeof(RegisterUserPage), "/~/users/register")]
    [InlineData(typeof(AssignPermissionsPage), "/~/users/{userId}/assign-permissions")]
    [Theory]
    public void Setup_PredefinedPages_ShouldBeWithCorrectRoutes(Type pageType, string expectedRoute)
    {
        var routeAttribute = pageType.GetAttribute<EmRouteAttribute>();
        
        routeAttribute
            .Template
            .Should()
            .Be(expectedRoute);
    }
}