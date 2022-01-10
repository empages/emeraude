using System;
using System.IO;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Essentials.Helpers;
using Emeraude.Infrastructure.FileStorage.Common;
using Emeraude.Infrastructure.FileStorage.Services;
using MediatR;

namespace EmDoggo.Admin.EmPages.Food;

public class FoodEmPageDataManager : EmPageDataManager<FoodEmPageModel>
{
    private readonly ISystemFilesService systemFilesService;

    public FoodEmPageDataManager(
        FoodEmPageDataStrategy dataStrategy,
        IMediator mediator,
        IEmPageService emPageService,
        ISystemFilesService systemFilesService)
        : base(dataStrategy, mediator, emPageService)
    {
        this.systemFilesService = systemFilesService;
    }

    protected override async Task BeforeCreateAsync(FoodEmPageModel model)
    {
        await this.HandleFormFileAsync(model);
    }

    protected override async Task BeforeEditAsync(string modelId, FoodEmPageModel model)
    {
        await this.HandleFormFileAsync(model);
    }

    private async Task HandleFormFileAsync(FoodEmPageModel model)
    {
        var targetDirectory = Path.Combine("uploads", "images");
        var fileId = model.ImageUrl;
        if (Guid.TryParse(fileId, out var parsedFileId) && this.systemFilesService.MoveTemporaryFileToPublicDirectory(parsedFileId, targetDirectory))
        {
            var fileName = this.systemFilesService.GetTemporaryFile(parsedFileId);
            model.ImageUrl = UrlHelpers.BuildRelativeUrl("uploads", "images", fileName);
        }
        else
        {
            model.ImageUrl = null;
        }
    }
}