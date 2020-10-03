using System.Collections.Generic;
using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Files.Validation.Handlers;
using Definux.Utilities.Enumerations;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Files.Validation
{
    /// <inheritdoc cref="IFilesValidationProvider"/>
    public class FilesValidationProvider : IFilesValidationProvider
    {
        private const int MaxAllowedFileSize = 20971520;
        private const int MaxAllowedImageFileSize = 10485760;
        private const int MaxAllowedVideoFileSize = 209715200;

        private readonly List<FileExtensions> allowedFileFormatExtensions = new List<FileExtensions>
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
            FileExtensions._Pdf,
        };

        private readonly List<FileExtensions> allowedImageFormatExtensions = new List<FileExtensions>
        {
            FileExtensions._Jpeg,
            FileExtensions._Jpg,
            FileExtensions._Gif,
            FileExtensions._Png,
        };

        private readonly List<FileExtensions> allowedVideoFormatExtensions = new List<FileExtensions>
        {
            FileExtensions._Mp4,
            FileExtensions._Avi,
            FileExtensions._Mov,
            FileExtensions._Flv,
            FileExtensions._Wmv,
        };

        private readonly List<string> allowedFilesMimeTypes = new List<string>
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
            "application/pdf",
        };

        private readonly List<string> allowedImageMimeTypes = new List<string>
        {
            "image/jpg",
            "image/jpeg",
            "image/pjpeg",
            "image/gif",
            "image/x-png",
            "image/png",
        };

        private readonly List<string> allowedVideoMimeTypes = new List<string>
        {
            "video/x-flv",
            "video/mp4",
            "video/quicktime",
            "video/x-msvideo",
            "video/x-ms-wmv",
        };

        /// <inheritdoc/>
        public ValidationResult ValidateFormFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? this.allowedFileFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? this.allowedFilesMimeTypes : customMimeTypes;
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

        /// <inheritdoc/>
        public ValidationResult ValidateFormImageFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? this.allowedImageFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? this.allowedImageMimeTypes : customMimeTypes;
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

        /// <inheritdoc/>
        public ValidationResult ValidateFormVideoFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
        {
            List<FileExtensions> allowedFileExtensions = customFileExtensions == null ? this.allowedVideoFormatExtensions : customFileExtensions;
            List<string> allowedMimeTypes = customMimeTypes == null ? this.allowedVideoMimeTypes : customMimeTypes;
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
