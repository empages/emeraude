using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Resources;
using EmDoggoDev.Application.Common.Interfaces;
using EmDoggoDev.Application.Common.Interfaces.Persistance;
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

        private readonly IHostEnvironment hostEnvironment;
        private readonly ILogger logger;
        private readonly IEntityContext context;
        public HelperService(
            ILogger logger,
            IHostEnvironment hostEnvironment,
            IEntityContext context)
        {
            this.logger = logger;
            this.hostEnvironment = hostEnvironment;
            this.context = context;

            this.foodsGalleryFolderPath = Path.Combine(
                    this.hostEnvironment.ContentRootPath,
                    Folders.PublicRootFolderName,
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
                string publicRootPath = Path.Combine(this.hostEnvironment.ContentRootPath, Folders.PublicRootFolderName);
                List<string> resultPictures = Directory
                    .GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(x => x.Replace(publicRootPath, string.Empty).Replace(Path.DirectorySeparatorChar, '/'))
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
