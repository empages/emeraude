using System.Collections.Generic;
using Definux.Utilities.Enumerations;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Common.Interfaces.Files
{
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

        /// <summary>
        /// Validate video by default or custom criteria.
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="customFileExtensions"></param>
        /// <param name="customMimeTypes"></param>
        /// <param name="customMaxFileSize"></param>
        /// <returns></returns>
        ValidationResult ValidateFormVideoFile(IFormFile formFile, List<FileExtensions> customFileExtensions = null, List<string> customMimeTypes = null, long customMaxFileSize = 0);
    }
}
