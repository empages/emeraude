using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Files.Validation.Handlers;
using Definux.Utilities.Enumerations;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Definux.Emeraude.Files.Validation
{
    public class FilesValidationProvider : IFilesValidationProvider
    {
        private const int MaxAllowedFileSize = 20971520;
        private const int MaxAllowedImageFileSize = 10485760;
        private const int MaxAllowedVideoFileSize = 209715200;

        private readonly List<FileExtensions> AllowedFileFormatExtensions = new List<FileExtensions>
        {
            FileExtensions._Jpeg,
            FileExtensions._Jpg,
            FileExtensions._Gif,
            FileExtensions._Png,
            FileExtensions._Mp4,
            FileExtensions._Avi,
            FileExtensions._Mov,
            FileExtensions._Flv,
            FileExtensions._Wmv,
            FileExtensions._Zip,
            FileExtensions._7z,
            FileExtensions._Rar,
            FileExtensions._Pdf
        };

        private readonly List<FileExtensions> AllowedImageFormatExtensions = new List<FileExtensions>
        {
            FileExtensions._Jpeg,
            FileExtensions._Jpg,
            FileExtensions._Gif,
            FileExtensions._Png,
        };

        private readonly List<FileExtensions> AllowedVideoFormatExtensions = new List<FileExtensions>
        {
            FileExtensions._Mp4,
            FileExtensions._Avi,
            FileExtensions._Mov,
            FileExtensions._Flv,
            FileExtensions._Wmv,
        };

        private readonly List<string> AllowedFilesMimeTypes = new List<string>
        {
            "image/jpg",
            "image/jpeg",
            "image/pjpeg",
            "image/gif",
            "image/x-png",
            "image/png",
            "video/x-flv",
            "video/mp4",
            "video/quicktime",
            "video/x-msvideo",
            "video/x-ms-wmv",
            "application/zip",
            "application/x-7z-compressed",
            "application/vnd.rar",
            "application/pdf"
        };

        private readonly List<string> AllowedImageMimeTypes = new List<string>
        {
            "image/jpg",
            "image/jpeg",
            "image/pjpeg",
            "image/gif",
            "image/x-png",
            "image/png",
        };

        private readonly List<string> AllowedVideoMimeTypes = new List<string>
        {
            "video/x-flv",
            "video/mp4",
            "video/quicktime",
            "video/x-msvideo",
            "video/x-ms-wmv"
        };

        public ValidationResult ValidateFormFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? AllowedFileFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? AllowedFilesMimeTypes : customMimeTypes;
            long maxAllowedFileSize = customMaxFileSize == 0 ? MaxAllowedFileSize : customMaxFileSize;

            var startupHandler = new StartupHandler<IFormFile>();
            var fileExtensionHandler = new FileExtensionHandler(allowedFileExtensions);
            var fileMimeTypesHandler = new FileMimeTypesHandler(allowedMimeTypes);
            var fileSizeHandler = new FileSizeHandler(maxAllowedFileSize);

            startupHandler
                .SetNext(fileExtensionHandler)
                .SetNext(fileMimeTypesHandler)
                .SetNext(fileSizeHandler);

            ValidationResult validationResult = new ValidationResult();
            string resultMessage = string.Empty;
            validationResult.Success = startupHandler.Handle(formFile, out resultMessage) != null;
            validationResult.Message = resultMessage;
            if (validationResult.Success)
            {
                validationResult.Message = "File is valid.";
            }

            return validationResult;
        }

        public ValidationResult ValidateFormImageFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? AllowedImageFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? AllowedImageMimeTypes : customMimeTypes;
            long maxAllowedFileSize = customMaxFileSize == 0 ? MaxAllowedImageFileSize : customMaxFileSize;

            var startupHandler = new StartupHandler<IFormFile>();
            var fileExtensionHandler = new FileExtensionHandler(allowedFileExtensions);
            var fileMimeTypesHandler = new FileMimeTypesHandler(allowedMimeTypes);
            var fileSizeHandler = new FileSizeHandler(maxAllowedFileSize);
            var imageBoxingHandler = new ImageBoxingHandler();

            startupHandler
                .SetNext(fileExtensionHandler)
                .SetNext(fileMimeTypesHandler)
                .SetNext(fileSizeHandler)
                .SetNext(imageBoxingHandler);

            ValidationResult validationResult = new ValidationResult();
            string resultMessage = string.Empty;
            validationResult.Success = startupHandler.Handle(formFile, out resultMessage) != null;
            validationResult.Message = resultMessage;
            if (validationResult.Success)
            {
                validationResult.Message = "Image file is valid.";
            }

            return validationResult;
        }

        public ValidationResult ValidateFormVideoFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? AllowedVideoFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? AllowedVideoMimeTypes : customMimeTypes;
            long maxAllowedFileSize = customMaxFileSize == 0 ? MaxAllowedVideoFileSize : customMaxFileSize;

            var startupHandler = new StartupHandler<IFormFile>();
            var fileExtensionHandler = new FileExtensionHandler(allowedFileExtensions);
            var fileMimeTypesHandler = new FileMimeTypesHandler(allowedMimeTypes);
            var fileSizeHandler = new FileSizeHandler(maxAllowedFileSize);

            startupHandler
                .SetNext(fileExtensionHandler)
                .SetNext(fileMimeTypesHandler)
                .SetNext(fileSizeHandler);

            ValidationResult validationResult = new ValidationResult();
            string resultMessage = string.Empty;
            validationResult.Success = startupHandler.Handle(formFile, out resultMessage) != null;
            validationResult.Message = resultMessage;
            if (validationResult.Success)
            {
                validationResult.Message = "Video file is valid.";
            }

            return validationResult;
        }
    }
}
