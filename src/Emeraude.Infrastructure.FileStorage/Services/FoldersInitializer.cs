using System;
using System.Collections.Generic;
using System.IO;
using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.FileStorage.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.FileStorage.Services;

/// <inheritdoc cref="IFoldersInitializer"/>
public class FoldersInitializer : IFoldersInitializer
{
    private readonly EmFilesOptions options;
    private readonly ILogger<FoldersInitializer> logger;
    private readonly IWebHostEnvironment hostEnvironment;

    /// <summary>
    /// Initializes a new instance of the <see cref="FoldersInitializer"/> class.
    /// </summary>
    /// <param name="optionsProvider"></param>
    /// <param name="logger"></param>
    /// <param name="hostEnvironment"></param>
    public FoldersInitializer(
        IEmOptionsProvider optionsProvider,
        ILogger<FoldersInitializer> logger,
        IWebHostEnvironment hostEnvironment)
    {
        this.options = optionsProvider.GetFilesOptions();
        this.logger = logger;
        this.hostEnvironment = hostEnvironment;
    }

    /// <inheritdoc/>
    public void InitFolders()
    {
        try
        {
            var projectFolder = this.hostEnvironment.ContentRootPath;
            if (this.options.InitFolders != null && this.options.InitFolders.Count > 0)
            {
                foreach (var initFolderPaths in this.options.InitFolders)
                {
                    CreateContentRootPath(projectFolder, initFolderPaths);
                }
            }
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An error occured during startup folders initialization");
        }
    }

    private static void CreateContentRootPath(string contentRootPath, string[] folders)
    {
        var foldersList = new List<string> { contentRootPath };
        foldersList.AddRange(folders);
        string folderPath = Path.Combine(foldersList.ToArray());

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
    }
}