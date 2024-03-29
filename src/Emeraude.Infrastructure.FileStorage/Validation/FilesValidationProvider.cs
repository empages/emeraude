﻿using System.Collections.Generic;
using Emeraude.Configuration.Options;
using Emeraude.Essentials.Enumerations;
using Emeraude.Essentials.Validation;
using Emeraude.Infrastructure.FileStorage.Extensions;
using Emeraude.Infrastructure.FileStorage.Options;
using Emeraude.Infrastructure.FileStorage.Validation.Handlers;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.FileStorage.Validation;

/// <inheritdoc cref="IFilesValidationProvider"/>
public class FilesValidationProvider : IFilesValidationProvider
{
    private readonly List<FileExtensions> allowedFileFormatExtensions = new ()
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

    private readonly List<FileExtensions> allowedImageFormatExtensions = new ()
    {
        FileExtensions._Jpeg,
        FileExtensions._Jpg,
        FileExtensions._Gif,
        FileExtensions._Png,
    };

    private readonly List<string> allowedFilesMimeTypes = new ()
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

    private readonly List<string> allowedImageMimeTypes = new ()
    {
        "image/jpg",
        "image/jpeg",
        "image/pjpeg",
        "image/gif",
        "image/x-png",
        "image/png",
    };

    private readonly EmFilesOptions options;

    /// <summary>
    /// Initializes a new instance of the <see cref="FilesValidationProvider"/> class.
    /// </summary>
    /// <param name="optionsProvider"></param>
    public FilesValidationProvider(IEmOptionsProvider optionsProvider)
    {
        this.options = optionsProvider.GetFilesOptions();
    }

    /// <inheritdoc/>
    public ValidationResult ValidateFormFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
    {
        List<FileExtensions> allowedFileExtensions = customFileExtensions ?? this.allowedFileFormatExtensions;
        List<string> allowedMimeTypes = customMimeTypes ?? this.allowedFilesMimeTypes;
        long maxAllowedFileSize = customMaxFileSize == 0 ? this.options.MaxAllowedFileSize : customMaxFileSize;

        var startupHandler = new StartupHandler<IFormFile>();
        var fileExtensionHandler = new FileExtensionHandler(allowedFileExtensions);
        var fileMimeTypesHandler = new FileMimeTypesHandler(allowedMimeTypes);
        var fileSizeHandler = new FileSizeHandler(maxAllowedFileSize);

        startupHandler
            .SetNext(fileExtensionHandler)
            .SetNext(fileMimeTypesHandler)
            .SetNext(fileSizeHandler);

        ValidationResult validationResult = new ValidationResult();
        validationResult.Succeeded = startupHandler.Handle(formFile, out var resultMessage) != null;
        validationResult.Message = resultMessage;
        if (validationResult.Succeeded)
        {
            validationResult.Message = "File is valid.";
        }

        return validationResult;
    }

    /// <inheritdoc/>
    public ValidationResult ValidateFormImageFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0)
    {
        List<FileExtensions> allowedFileExtensions = customFileExtensions ?? this.allowedImageFormatExtensions;
        List<string> allowedMimeTypes = customMimeTypes ?? this.allowedImageMimeTypes;
        long maxAllowedFileSize = customMaxFileSize == 0 ? this.options.MaxAllowedImageFileSize : customMaxFileSize;

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
        validationResult.Succeeded = startupHandler.Handle(formFile, out var resultMessage) != null;
        validationResult.Message = resultMessage;
        if (validationResult.Succeeded)
        {
            validationResult.Message = "Image file is valid.";
        }

        return validationResult;
    }
}