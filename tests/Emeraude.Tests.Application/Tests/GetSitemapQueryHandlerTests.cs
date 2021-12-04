using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Application.Consumer.Models;
using Emeraude.Application.Consumer.Requests.Seo.Queries.GetSitemap;
using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Emeraude.Infrastructure.Localization.Services;
using Emeraude.Tests.Application.Fakes;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace Emeraude.Tests.Application.Tests;

public class GetSitemapQueryHandlerTests
{
    [Fact]
    public async Task Handle_OnCorrectSetup_CorrectSitemapResult()
    {
        var queryHandler = this.GetSubject();
        var result = await queryHandler.Handle(new GetSitemapQuery(), CancellationToken.None);
        string baseUrl = "https://emeraude.dev";
            
        result
            .Urls
            .Should()
            .HaveCount(6);

        result
            .Urls
            .Select(x => x.Location)
            .Should()
            .BeEquivalentTo(new List<string>
            {
                $"{baseUrl}/home",
                $"{baseUrl}/en/home",
                $"{baseUrl}/entities/1",
                $"{baseUrl}/en/entities/1",
                $"{baseUrl}/entities/2",
                $"{baseUrl}/en/entities/2",
            });
            
        result
            .Urls
            .Select(x => x.ChangeFrequency)
            .Should()
            .BeEquivalentTo(new List<string>
            {
                SeoChangeFrequencyTypes.Monthly.ToString(),
                SeoChangeFrequencyTypes.Monthly.ToString(),
                SeoChangeFrequencyTypes.Daily.ToString(),
                SeoChangeFrequencyTypes.Daily.ToString(),
                SeoChangeFrequencyTypes.Daily.ToString(),
                SeoChangeFrequencyTypes.Daily.ToString(),
            });
            
        result
            .Urls
            .Select(x => x.LastModification)
            .Should()
            .BeEquivalentTo(new List<string>
            {
                string.Empty,
                string.Empty,
                new DateTime(2020, 1, 1).ToString("o"),
                new DateTime(2020, 1, 1).ToString("o"),
                new DateTime(2020, 2, 2).ToString("o"),
                new DateTime(2020, 2, 2).ToString("o"),
            });
    }

    private GetSitemapQuery.GetSitemapQueryHandler GetSubject()
    {
        var languageStoreMock = new Mock<ILanguageStore>();
        languageStoreMock
            .Setup(x => x.GetLanguages())
            .Returns(new List<Language>
            {
                new()
                {
                    IsDefault = true,
                    Code = "bg"
                },
                new()
                {
                    Code = "en"
                }
            });

        var httpContextAccessorMock = new Mock<IHttpContextAccessor>();
        var httpContext = new DefaultHttpContext();
        httpContextAccessorMock
            .Setup(x => x.HttpContext)
            .Returns(httpContext);

        return new GetSitemapQuery.GetSitemapQueryHandler(httpContextAccessorMock.Object, new FakeSitemapComposition(languageStoreMock.Object));
    }
}