using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Components.Renderers;
using Emeraude.Application.Admin.EmPages.Schema;

namespace Emeraude.Tests.Application.Fakes;

public class FakeSimpleEmPageSchema : IEmPageSchema<FakeEmPageModel>
{
    public async Task<EmPageSchemaSettings<FakeEmPageModel>> SetupAsync()
    {
        var settings = new EmPageSchemaSettings<FakeEmPageModel>
        {
            Route = "fake",
            Title = "Fake",
            Description = "Fake description"
        };

        settings
            .ConfigureIndexView(indexView =>
            {
                indexView
                    .Use(x => x.String, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.Double, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    });
            })
            .ConfigureDetailsView(detailsView =>
            {
                detailsView
                    .Use(x => x.Id, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.String, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.Double, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    });
            });
        
        return await Task.FromResult(settings);
    }
}