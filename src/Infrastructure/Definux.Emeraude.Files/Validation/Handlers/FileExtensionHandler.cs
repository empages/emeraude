using Definux.Utilities.Enumerations;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Files.Validation.Handlers
{
    internal class FileExtensionHandler : Handler<IFormFile>
    {
        private readonly List<FileExtensions> allowedFileExtensions;

        public FileExtensionHandler(List<FileExtensions> allowedFileExtensions)
        {
            if (allowedFileExtensions == null || allowedFileExtensions.Count == 0)
            {
                throw new NullReferenceException("Allowed file extensions list must be valid list with at least 1 element in.");
            }
            this.allowedFileExtensions = allowedFileExtensions;
        }
        protected override string HandleProcessAction()
        {
            bool isFileValid = false;
            foreach (var fileExtension in this.allowedFileExtensions)
            {
                if (this.requestObject.FileName.EndsWith($".{fileExtension.ToString().Replace("_", "").ToLower()}"))
                {
                    isFileValid = true;
                    break;
                }
            }

            string resultMessage = string.Empty;
            if (!isFileValid)
            {
                this.requestObject = null;
                resultMessage = "File extension is not allowed. ";
            }

            return resultMessage;
        }
    }
}
