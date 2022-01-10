using System.Net.Http;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Components.Mutators;
using Emeraude.Application.Admin.EmPages.Components.Renderers;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Defaults.Extensions;
using FluentValidation;

namespace EmDoggo.Admin.EmPages.Shop;

public class ShopEmPageSchema : IEmPageSchema<ShopEmPageModel>
{
    public async Task<EmPageSchemaSettings<ShopEmPageModel>> SetupAsync()
    {
        var settings = new EmPageSchemaSettings<ShopEmPageModel>
        {
            Route = "shops",
            Title = "Shop",
            Description = @"Shop description.",
        };

        settings
            .ConfigureIndexView(indexView =>
            {
                indexView
                    .Use(x => x.Name, item =>
                    {
                        item.SetComponent<EmPageTextRenderer>();
                    });

                indexView.OrderProperties["Name"] = "Name";
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
                    .Use(x => x.Description, item =>
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
                    .Use(x => x.Description, item =>
                    {
                        item.Required = true;
                        item.SetComponent<EmPageTextMutator>();
                    });
                
                formView.ConfigureModelValidator((type, validator) =>
                {
                    validator
                        .RuleFor(x => x.Name)
                        .NotEmpty()
                        .WithMessage("Shop name is required");
                    
                    validator
                        .RuleFor(x => x.Description)
                        .NotEmpty()
                        .WithMessage("Shop description is required")
                        .MinimumLength(20)
                        .WithMessage("Minimum length of description must be 20");
                });
            })
            .ApplyDefaultEmPageBreadcrumbs()
            .ApplyDefaultEmPageActions();

        return settings;
    }
}