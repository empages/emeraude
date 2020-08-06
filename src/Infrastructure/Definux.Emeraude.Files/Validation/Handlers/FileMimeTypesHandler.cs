using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Files.Validation.Handlers
{
    internal class FileMimeTypesHandler : Handler<IFormFile>
    {
        List<string> allowedMimeTypes;

        public FileMimeTypesHandler(List<string> allowedMimeTypes)
        {
            if (allowedMimeTypes == null || allowedMimeTypes.Count == 0)
            {
                throw new NullReferenceException("Allowed mime types list must be valid list with at least 1 element in.");
            }
            this.allowedMimeTypes = allowedMimeTypes;
        }

        protected override string HandleProcessAction()
        {
            bool isFileValid = false;
            foreach (var mimeType in this.allowedMimeTypes)
            {
                if (this.requestObject.ContentType.Equals(mimeType, StringComparison.OrdinalIgnoreCase))
                {
                    isFileValid = true;
                    break;
                }
            }

            string resultMessage = string.Empty;
            if (!isFileValid)
            {
                this.requestObject = null;
                resultMessage = "File mime type is incorrect. ";
            }

            return resultMessage;
        }
    }
}
