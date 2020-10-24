using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Resources;
using EmDoggoDev.Application.Common.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmDoggoDev.Infrastructure.Services
{
    public class HelperService : IHelperService
    {
        public const string FoodsGalleryFolderName = "foods";
        private readonly string foodsGalleryFolderPath;

        private readonly ISystemFilesService systemFilesService;
        private readonly IEmLogger logger;
        public HelperService(
            ISystemFilesService systemFilesService,
            IEmLogger logger,
            IHostEnvironment hostEnvironment)
        {
            this.systemFilesService = systemFilesService;
            this.logger = logger;

            this.foodsGalleryFolderPath = this.systemFilesService.GetPathFromPublicRoot(
                    Folders.UploadFolderName,
                    Folders.ImagesFolderName,
                    FoodsGalleryFolderName);
        }

        public void CreateFoodGalleryFolder(Guid foodId)
        {
            try
            {
                string folderPath = GetFoodGalleryFolderPath(foodId);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
            }
        }

        public List<string> GetFoodPictures(Guid foodId)
        {
            try
            {
                string folderPath = GetFoodGalleryFolderPath(foodId);
                List<string> resultPictures = Directory
                    .GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(x => x.Replace(this.systemFilesService.PublicRootDirectory, string.Empty).Replace(Path.DirectorySeparatorChar, '/'))
                    .ToList();

                return resultPictures;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        public void DeleteFoodGalleryFolder(Guid foodId)
        {
            try
            {
                string folderPath = GetFoodGalleryFolderPath(foodId);
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
            }
        }

        private string GetFoodGalleryFolderPath(Guid foodId)
        {
            string folderName = foodId.ToString();
            string sportAreaFolderPath = Path.Combine(this.foodsGalleryFolderPath, folderName);

            return sportAreaFolderPath;
        }
    }
}
