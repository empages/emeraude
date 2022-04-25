using System;
using Emeraude.Application.Pages.AssignPermissions;
using Emeraude.Application.Pages.RegisterUser;
using Emeraude.Application.Pages.Users;
using Emeraude.Pages;
using Essentials.Extensions;
using FluentAssertions;
using Xunit;

namespace Emeraude.Application.Tests;

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