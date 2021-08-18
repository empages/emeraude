using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Files.Extensions;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Definux.Emeraude.Files.Services
{
    /// <inheritdoc cref="IFoldersInitializer"/>
    public class FoldersInitializer : IFoldersInitializer
    {
        private readonly EmFilesOptions options;
        private readonly IEmLogger logger;
        private readonly IHostingEnvironment hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersInitializer"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        public FoldersInitializer(
            IEmOptionsProvider optionsProvider,
            IEmLogger logger,
            IHostingEnvironment hostingEnvironment)
        {
            this.options = optionsProvider.GetFilesOptions();
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
        }

        /// <inheritdoc/>
        public async Task InitFoldersAsync()
        {
            try
            {
                var projectFolder = this.hostingEnvironment.ContentRootPath;
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
                await this.logger.LogErrorAsync(ex);
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
}