using System.Collections.Generic;
using EmPages.Pages.Services;
using Moq;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmRouterTests
{
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData("/", null)]
    [InlineData("/dogs", "dogs")]
    [InlineData("/dogs/123", "dogs/{dogId}")]
    [InlineData("/dogs/04a70309-45e7-43fa-80ba-8de7aaf2206b", "dogs/{dogId}")]
    [InlineData("/dogs/2/123", null)]
    [InlineData("/dogs/2/owners", "dogs/{dogId}/owners")]
    [InlineData("/dogs/2/modify", "dogs/{dogId}/modify")]
    [InlineData("/dogs/2/modify/2", null)]
    [InlineData("/dogs/2/owners/2", "dogs/{dogId}/owners/{ownerId}")]
    [InlineData("/folder/test/docs/xml/file.xml", "folder/{folder1}/{folder2}/{folder3}/{file1}")]
    [Theory]
    public void RouteToPage(string route, string expectedTemplate)
    {
        var router = this.GetSubject();
        var resultPage = router.RouteToPage(route);
        
        Assert.Equal(expectedTemplate, resultPage?.PageRoute?.Template);
    }

    private IEmRouter GetSubject()
    {
        var pageStoreMock = new Mock<IEmPageStore>();
        pageStoreMock
            .Setup(x => x.PageDescriptors)
            .Returns(new List<EmPageDescriptor>
            {
                this.BuildPageDescriptor("/dogs"),
                this.BuildPageDescriptor("/dogs/{dogId}"),
                this.BuildPageDescriptor("/dogs/{dogId}/modify"),
                this.BuildPageDescriptor("/dogs/{dogId}/owners"),
                this.BuildPageDescriptor("/dogs/{dogId}/owners/{ownerId}"),
                this.BuildPageDescriptor("/folder/{folder1}/{folder2}/{folder3}/{file1}"),
            });
        
        return new EmRouter(pageStoreMock.Object);
    }

    private EmPageDescriptor BuildPageDescriptor(string route) =>
        new()
        {
            PageRoute = new EmPageRoute(route),
        };
}