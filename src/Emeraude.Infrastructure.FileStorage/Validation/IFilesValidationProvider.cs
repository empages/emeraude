using System.Collections.Generic;
using Emeraude.Essentials.Enumerations;
using Emeraude.Essentials.Validation;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.FileStorage.Validation;

/// <summary>
/// Provider service of file validators.
/// </summary>
public interface IFilesValidationProvider
{
    /// <summary>
    /// Validate file by default or custom criteria.
    /// </summary>
    /// <param name="formFile"></param>
    /// <param name="customFileExtensions"></param>
    /// <param name="customMimeTypes"></param>
    /// <param name="customMaxFileSize"></param>
    /// <returns></returns>
    ValidationResult ValidateFormFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0);

    /// <summary>
    /// Validate image by default or custom criteria.
    /// </summary>
    /// <param name="formFile"></param>
    /// <param name="customFileExtensions"></param>
    /// <param name="customMimeTypes"></param>
    /// <param name="customMaxFileSize"></param>
    /// <returns></returns>
    ValidationResult ValidateFormImageFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0);
}