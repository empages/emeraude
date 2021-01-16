using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Logger;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Definux.Emeraude.Files.Services
{
    /// <inheritdoc cref="IFoldersInitializer"/>
    public class FoldersInitializer : IFoldersInitializer
    {
        private const string ConfigurationFileName = "folders.json";
        private readonly IEmLogger logger;
        private readonly IHostingEnvironment hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersInitializer"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        public FoldersInitializer(
            IEmLogger logger,
            IHostingEnvironment hostingEnvironment)
        {
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
        }

        /// <inheritdoc/>
        public async Task InitFoldersAsync()
        {
            try
            {
                var projectFolder = this.hostingEnvironment.ContentRootPath;
                string configurationFilePath = Path.Combine(projectFolder, ConfigurationFileName);
                if (File.Exists(configurationFilePath))
                {
                    var configurationFileContent = await File.ReadAllTextAsync(configurationFilePath);
                    var foldersForInit = JsonConvert.DeserializeObject<IEnumerable<InitFolder>>(configurationFileContent);
                    CreateRootPathsRecursively(projectFolder, null, foldersForInit);
                }
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }
        }

        private static void CreateRootPathsRecursively(string contentRootPath, string rootFolder, IEnumerable<InitFolder> folders)
        {
            if (folders == null)
            {
                return;
            }

            foreach (var folder in folders)
            {
                string folderPath = folder.Name;
                if (!string.IsNullOrEmpty(rootFolder))
                {
                    folderPath = Path.Combine(rootFolder, folder.Name);
                    CreateContentRootPath(contentRootPath, rootFolder, folder.Name);
                }
                else
                {
                    CreateContentRootPath(contentRootPath, folder.Name);
                }

                CreateRootPathsRecursively(contentRootPath, folderPath, folder.Children);
            }
        }

        private static void CreateContentRootPath(string contentRootPath, params string[] folders)
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