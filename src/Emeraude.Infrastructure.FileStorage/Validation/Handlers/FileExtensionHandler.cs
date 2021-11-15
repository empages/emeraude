using System;
using System.Collections.Generic;
using Definux.Utilities.Enumerations;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.FileStorage.Validation.Handlers
{
    /// <summary>
    /// File validation handler for file extension.
    /// </summary>
    internal class FileExtensionHandler : Handler<IFormFile>
    {
        private readonly List<FileExtensions> allowedFileExtensions;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileExtensionHandler"/> class.
        /// </summary>
        /// <param name="allowedFileExtensions"></param>
        public FileExtensionHandler(List<FileExtensions> allowedFileExtensions)
        {
            if (allowedFileExtensions == null || allowedFileExtensions.Count == 0)
            {
                throw new NullReferenceException("Allowed file extensions list must be valid list with at least 1 element in.");
            }

            this.allowedFileExtensions = allowedFileExtensions;
        }

        /// <inheritdoc/>
        protected override string HandleProcessAction()
        {
            bool isFileValid = false;
            foreach (var fileExtension in this.allowedFileExtensions)
            {
                if (this.RequestObject.FileName.ToLower().EndsWith($".{fileExtension.ToString().Replace("_", string.Empty).ToLower()}"))
                {
                    isFileValid = true;
                    break;
                }
            }

            string resultMessage = string.Empty;
            if (!isFileValid)
            {
                this.RequestObject = null;
                resultMessage = "File extension is not allowed. ";
            }

            return resultMessage;
        }
    }
}
