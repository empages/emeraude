﻿using System.Linq;
using System.Threading.Tasks;
using EmDoggo.Core.Data;
using EmPages.Pages;
using EmPages.Pages.Components.Renderers;
using EmPages.Pages.Pages.Table;
using Microsoft.EntityFrameworkCore;

namespace EmDoggo.EmConfig.Pages.Dogs;

[EmNavigationItem(100, "Dogs", "dogs")]
[EmRoute("/dogs")]
public class DogsPage : EmTablePage<DogsPageModel>
{
    private readonly EntityContext context;

    public DogsPage(EntityContext context)
    {
        this.context = context;
    }

    public override async Task SetupAsync()
    {
        this.Title = "Dogs";

        this.ViewContext.Exclude(x => x.Id);

        this.ViewContext.Configure(x => x.Active, item =>
        {
            item.SetComponent<EmTextRenderer>();
        });
        
        this.AddAction((_, _) => new EmAction
        {
            Title = "Create",
            Order = 1,
            Type = PageActionType.Redirection,
            Target = "/dogs/create"
        });
        
        this.AddRowAction((model, _) => new EmAction
        {
            Title = "Details",
            Order = 0,
            Type = PageActionType.Redirection,
            Target = $"/dogs/{model.Id}"
        });
        
        this.AddRowAction((model, _) => new EmAction
        {
            Title = "Modify",
            Order = 1,
            Type = PageActionType.Redirection,
            Target = $"/dogs/{model.Id}/edit"
        });
        
        this.AddRowAction((_, _) => new EmAction
        {
            Title = "Delete",
            Order = 2,
            Type = PageActionType.Command,
            Target = nameof(DogsPageDeleteCommand),
            RequiresConfirmation = true,
        });
    }

    public override async Task<EmTablePageResult> FetchDataAsync(EmPageRequest request)
    {
        var page = request.GetPaginationPageIndex();
        var pageSize = request.GetPaginationPageSize();
        var skipCount = (page - 1) * pageSize;
        
        var dogsQuery = this.context.Dogs;

        var dogsCount = await dogsQuery.CountAsync();

        var dogs = await dogsQuery
            .Skip(skipCount)
            .Take(pageSize)
            .Select(x => new DogsPageModel
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                Breed = x.Breed,
            })
            .ToListAsync();

        return new EmTablePageResult
        {
            Models = dogs,
            SkippedCount = skipCount,
            TakenCount = pageSize,
            TotalCount = dogsCount,
        };
    }
}