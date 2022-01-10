using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Components.Mutators;
using Emeraude.Application.Admin.EmPages.Components.Renderers;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Defaults.Extensions;
using Emeraude.Defaults.ValuePipes;

namespace EmDoggo.Admin.EmPages.Food;

public class FoodEmPageSchema : IEmPageSchema<FoodEmPageModel>
{
    public async Task<EmPageSchemaSettings<FoodEmPageModel>> SetupAsync()
    {
        var settings = new EmPageSchemaSettings<FoodEmPageModel>
        {
            Route = "foods",
            Title = "Food",
            Description = @"Food description.",
        };

        settings
            .ConfigureIndexView(indexView =>
            {
                indexView
                    .Use(x => x.Name, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.Manufacturer, item =>
                    {
                        item.SetComponent<EmPageEnumRenderer>();
                    })
                    .Use(x => x.PackageDate, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.ExpirationDate, item =>
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
                    .Use(x => x.Name, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.ImageUrl, item =>
                    {
                        item.Title = "Image";
                        item.SetComponent<EmPageImageRenderer>();
                    })
                    .Use(x => x.Manufacturer, item =>
                    {
                        item.SetComponent<EmPageEnumRenderer>();
                    })
                    .Use(x => x.PackageDate, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    })
                    .Use(x => x.ExpirationDate, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    });
            })
            .ConfigureFormView(formView =>
            {
                formView
                    .Use(x => x.Name, item =>
                    {
                        item.Required = true;
                        item.SetComponent<EmPageTextMutator>();
                    })
                    .Use(x => x.Manufacturer, item =>
                    {
                        item.Required = true;
                        item.SetComponent<EmPageEnumMutator>();
                    })
                    .Use(x => x.ImageUrl, item =>
                    {
                        item.Title = "Image";
                        item.SetComponent<EmPageFileMutator>();
                    })
                    .Use(x => x.PackageDate, item =>
                    {
                        item.Required = true;
                        item.SetComponent<EmPageDateMutator>();
                    })
                    .Use(x => x.ExpirationDate, item =>
                    {
                        item.Required = true;
                        item.SetComponent<EmPageDateMutator>();
                    });
            })
            .ApplyDefaultEmPageBreadcrumbs()
            .ApplyDefaultEmPageActions();

        return settings;
    }
}